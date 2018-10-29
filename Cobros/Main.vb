
Public Class Main

    Public Sub Iniciar()
        Try
            Dim Main As frmMain = New frmMain
            Main.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

End Class
