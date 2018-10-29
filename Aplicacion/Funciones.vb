Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

Module Funciones

    Public Function isUpdated() As Boolean
        Dim HashLocal As String = hash_generator("md5", ".\Config.ini")
        Dim HashFTP As String = hash_generator("md5", "C:\Config.ini")
        If Not HashFTP.Equals(HashLocal) Then
            Return False
        End If
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

    Public Function DownloadConfig(ByVal xFichero As String, ByVal xUser As String, ByVal xPassword As String, ByVal xDestino As String) As Boolean

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


    Public Sub DoubleBuffered(ByVal dgv As DataGridView, ByVal setting As Boolean)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)


    End Sub

    Public Function MD5EncryptPass(ByVal StrPass As String) As String

        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strPassOutput As String
        Dim i As Integer
        strPassOutput = ""

        md5 = New MD5CryptoServiceProvider

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strPassOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return strPassOutput

    End Function

    Public Function FormatearImporte(ByVal xImporte As Decimal) As String
        If xImporte < 10 Then
            Return String.Format(CultureInfo.InvariantCulture, "{0:0.00}", xImporte)
        Else
            Return String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", xImporte)
        End If

    End Function
End Module
