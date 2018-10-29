Friend Class Loader
    <STAThread()>
    Shared Sub Main()

        Try
            Dim Parametro As String
            If Environment.GetCommandLineArgs.Length <= 1 Then
                Dim p As ProcessStartInfo
                p = New ProcessStartInfo(".\Updater.exe")
                Process.Start(p)
                Return
            End If
            Parametro = Environment.GetCommandLineArgs(1)
            ''WeLiveSafe
            If Parametro = MD5EncryptPass("WeLiveSafe") Then
                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)

                Dim Login As Form = New frmLoader()
                Login.ShowDialog()
                If (Login.DialogResult = DialogResult.OK) Then
                    Dim MainForm As Form = New Main()
                    Application.Run(MainForm)
                Else
                    Return
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
