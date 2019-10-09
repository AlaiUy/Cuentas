Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports Updater

Public Class frmUpMain : Implements IObserver


    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub Actualizar(xData As Object) Implements IObserver.Update
        PBLoader.Value = xData
        Application.DoEvents()
    End Sub

    Private Sub Actualizar() Implements IObserver.Update
        Throw New NotImplementedException()
    End Sub

    Private Function Download(ByVal xFichero As String, ByVal xUser As String, ByVal xPassword As String, ByVal xDestino As String) As Boolean

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class