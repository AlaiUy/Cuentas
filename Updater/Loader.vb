Imports System.Security.Cryptography


Public Class Loader
    <STAThread()>
    Shared Sub Main()
        If UBound(System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
            Return
        End If
        Dim Parametro As String = Nothing
        Dim Param As Integer = Environment.GetCommandLineArgs.Length
        Try
            Parametro = Environment.GetCommandLineArgs(1)
        Catch ex As Exception

        End Try
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim up = New Updater.Update()
        If Not up.goUpdate(Parametro) Then
            Dim p As ProcessStartInfo
            If up.Soft = "CTAMANAGER" Then
                p = New ProcessStartInfo(".\Cuentas Corrientes.exe", "57ca089205081040146f36a2fa6e3dcc")
            Else
                p = New ProcessStartInfo(".\COBROS.exe", "57ca089205081040146f36a2fa6e3dcc")
            End If
            Try
                Process.Start(p)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



End Class
