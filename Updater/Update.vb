Imports System.IO
Imports System.Net
Imports System.Text
Imports System.IO.Compression.GZipStream
Imports System.IO.Compression
Imports Ionic.Zip
Imports System.Threading
Imports Microsoft.Win32
Imports System.Security.Cryptography

Public Class Update : Implements IObservable
    Private _frmLoading As Form
    Private _FTP As String
    Private _User As String = "alai@aguinagalde.com.uy"
    Private _Pass As String = "#25106/jos"
    Private _File As String
    Private _Fondo As Thread = New Thread(AddressOf frmCargando)
    Private _Soft As String
    Private _ForceUpdate As Boolean = False
    Private _Observers As List(Of IObserver)




    Public ReadOnly Property Soft As String
        Get
            Return _Soft
        End Get

    End Property

    Public Sub New()
        If VerificarConecctionFTP() Then
            Try
                If Not File.Exists(".\Config.ini") Then
                    MsgBox("Falta el archivo de configuracion")
                    Return
                End If
                _Soft = LeerDato("SOFTWARE", "NOMBRE", "", ".\Config.ini")
                _FTP = "ftp://ftp.aguinagalde.com.uy/Alai/UPDATES/" + _Soft + "/Config.ini"
                _File = "ftp://ftp.aguinagalde.com.uy/Alai/UPDATES/" + _Soft + "/UP.zip"
                DownloadConfig(_FTP, _User, _Pass, "C:\")
                _Observers = New List(Of IObserver)
            Catch ex As Exception


            End Try
        End If
    End Sub




    Private Sub frmCargando()
        _frmLoading = New frmUpMain()
        Me.Register(_frmLoading)
        _frmLoading.ShowDialog()
    End Sub

    Public Function goUpdate(ByVal xParam As String) As Boolean
        Try
            _Fondo.Start()
            If xParam = MD5EncryptPass("WeLiveSafe") Then
                _ForceUpdate = True
            End If
            If IsNothing(_Soft) Then
                MsgBox("Algun dato de configuracion es erroneo", vbOKOnly, "Error - Comunicar")
                Return False
            End If
            If VerificarConecctionFTP() Then
                If Not isUpdated() Then
                    RemoveFilesUpdated()
                    FTPDownloadFile()
                    Decompress()
                    RemoveSoftwareFiles()
                    CopyNewFiles()
                    RemoveFilesUpdated()
                End If
                Return False
            ElseIf WithOutUpdate() Then
                AddValueOut()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            _Fondo.Abort()
        End Try
        Return True
    End Function

    Private Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        ' We declare the variable : hash
        Dim hash
        If hash_type.ToLower = "md5" Then
            ' Initializes a md5 hash object
            hash = MD5.Create
        ElseIf hash_type.ToLower = "sha1" Then
            ' Initializes a SHA-1 hash object
            hash = SHA1.Create()
        ElseIf hash_type.ToLower = "sha256" Then
            ' Initializes a SHA-256 hash object
            hash = SHA256.Create()
        Else
            MsgBox("Unknown type of hash : " & hash_type, MsgBoxStyle.Critical)
            Return False
        End If

        ' We declare a variable to be an array of bytes
        Dim hashValue() As Byte

        ' We create a FileStream for the file passed as a parameter
        Dim fileStream As FileStream = File.OpenRead(file_name)
        ' We position the cursor at the beginning of stream
        fileStream.Position = 0
        ' We calculate the hash of the file
        hashValue = hash.ComputeHash(fileStream)
        ' The array of bytes is converted into hexadecimal before it can be read easily
        Dim hash_hex = PrintByteArray(hashValue)

        ' We close the open file
        fileStream.Close()

        ' The hash is returned
        Return hash_hex

    End Function

    Private Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        ' We traverse the array of bytes
        Dim i As Integer
        For i = 0 To array.Length - 1

            ' We convert each byte in hexadecimal
            hex_value += array(i).ToString("X2")

        Next i

        ' We return the string in lowercase
        Return hex_value.ToLower

    End Function

    Private Sub RemoveSoftwareFiles()
        Dim FilePaths As String() = Directory.GetFiles(".\")
        For Each F As String In FilePaths
            If Not F = ".\DotNetZip.dll" And Not F = ".\Updater.dll" And Not F = ".\Updater.exe" And Not F = ".\Interfaces.dll" Then
                Try
                    File.Delete(F)
                Catch ex As Exception

                End Try

            End If
        Next
    End Sub

    Private Function VerificarConecctionFTP() As Boolean
        Dim ClienteFtp As New Sockets.TcpClient
        Try
            ClienteFtp.Connect("ftp.aguinagalde.com.uy", 21) ' ojo, solo IP del server FTP
            Return True ' si devuelve True significa que hay conexion
        Catch Ex As Exception
            Return False ' si devuelve False significa que tienes que ir corriendo a ver que pasa en el server
        End Try
    End Function

    Private Sub RemoveFilesUpdated()
        If Directory.Exists("C:\UP") Then
            System.IO.Directory.Delete("C:\UP", True)
        End If
        If File.Exists("C:\UP.zip") Then
            File.Delete("C:\UP.zip")
        End If

    End Sub

    Private Function WithOutUpdate() As Boolean
        Dim CountOut As Integer = 10
        Dim LugarRegistry As String = "SOFTWARE\\Alai\\" + _Soft
        Dim Reg As RegistryKey
        Reg = Registry.LocalMachine
        Reg = Reg.OpenSubKey(LugarRegistry, True)
        If IsNothing(Reg) Then
            Reg = Registry.LocalMachine.CreateSubKey(LugarRegistry)
        Else
            If Reg.GetValue("TimeOut") = Nothing Then
                Reg.SetValue("TimeOut", 0, RegistryValueKind.QWord)
            End If
        End If
        CountOut = Convert.ToInt32(Reg.GetValue("TimeOut"))
        If CountOut <= 10 Then
            Return True
        End If
        Return False
    End Function

    Private Sub AddValueOut()
        Dim Reg As RegistryKey
        Dim LugarRegistry As String = "SOFTWARE\\Alai\\" + _Soft
        Reg = Registry.LocalMachine.CreateSubKey(LugarRegistry)
        Dim ValorToUp = Reg.GetValue("TimeOut")
        Reg.SetValue("TimeOut", ValorToUp + 1, RegistryValueKind.QWord)
    End Sub

    Private Function isUpdated() As Boolean
        Dim HashLocal As String = hash_generator("md5", ".\Config.ini")
        Dim HashFTP As String = hash_generator("md5", "C:\Config.ini")
        If Not HashFTP.Equals(HashLocal) Then
            Return False
        End If
        Return True
    End Function

    Private Function DownloadConfig(ByVal xFichero As String, ByVal xUser As String, ByVal xPassword As String, ByVal xDestino As String) As Boolean

        Dim PathFTP As FtpWebRequest = CType(FtpWebRequest.Create(xFichero), FtpWebRequest)

        ' Los datos del usuario (credenciales)
        Dim Credenciales As New NetworkCredential(xUser, xPassword)
        PathFTP.Credentials = Credenciales

        ' El comando a ejecutar usando la enumeración de WebRequestMethods.Ftp
        PathFTP.Method = WebRequestMethods.Ftp.DownloadFile

        ' Obtener el resultado del comando
        Dim Reader As New StreamReader(PathFTP.GetResponse().GetResponseStream())

        ' Leer el stream (el contenido del archivo)
        Dim Result As String = Reader.ReadToEnd()
        ' Guardarlo localmente con la extensión .txt
        Dim PathLocal As String = Path.Combine(xDestino, Path.GetFileName("Config.ini"))
        Dim sw As New StreamWriter(PathLocal, False, Encoding.Default)
        sw.Write(Result)
        sw.Close()

        ' Cerrar el stream abierto.
        Reader.Close()
        Return True
    End Function

    Private Sub FTPDownloadFile()
        Try
            Dim request As New WebClient()
            request.Credentials = New NetworkCredential(_User, _Pass)
            Dim URL As Uri = New Uri(_File)
            request.DownloadFile(_File, "C:\UP.zip")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


    Private Sub Decompress()
        Dim zip As String = "C:\UP.zip"
        Using zip1 As ZipFile = ZipFile.Read(zip)
            AddHandler zip1.ExtractProgress, AddressOf MyExtractProgress
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract("c:\UP", ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using
    End Sub

    Private Sub CopyNewFiles()
        Dim RutaFiles As New DirectoryInfo("C:\UP")
        For Each MyFile In RutaFiles.GetFiles
            Try
                'System.IO.File.Copy(File.FullName, System.IO.Path.Combine(".\", System.IO.Path.GetFileName(RutaFiles.FullName)), True)
                File.Copy(Path.Combine("C:\UP", MyFile.ToString()), Path.Combine(".\", MyFile.ToString()), True)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub

    Private Sub MyExtractProgress(sender As Object, e As ExtractProgressEventArgs)
        If (e.EventType = ZipProgressEventType.Extracting_EntryBytesWritten) Then
            notifyObservers((e.BytesTransferred / (e.TotalBytesToTransfer * 0.01)))
        End If
    End Sub

    Public Sub Register(xObserver As IObserver) Implements IObservable.Register
        If Not _Observers.Contains(xObserver) Then
            _Observers.Add(xObserver)
        End If
    End Sub

    Public Sub UnRegister(xObserver As IObserver) Implements IObservable.UnRegister
        If _Observers.Contains(xObserver) Then
            _Observers.Remove(xObserver)
        End If
    End Sub

    Public Sub notifyObservers() Implements IObservable.notifyObservers
        Throw New NotImplementedException()
    End Sub

    Public Sub notifyObservers(Data As Object) Implements IObservable.notifyObservers
        For Each O As IObserver In _Observers
            O.Update(Data)
        Next
    End Sub
End Class