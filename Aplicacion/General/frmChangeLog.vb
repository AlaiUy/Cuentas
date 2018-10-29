Imports Aguiñagalde.Gestoras
Imports System.Windows.Forms

Public Class frmChangeLog

    Private Sub frmChangeLog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmChangeLog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Close()
        End If
    End Sub

    Private Sub frmChangeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            wbCL.Navigate("\\SERVIDOR/Actualizaciones/CTAManager/Index.html")
            '  wbCL.Navigate(My.Resources.AguiResources.Index)

            Me.Select()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub wbCL_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbCL.DocumentCompleted

    End Sub

    Private Sub wbCL_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles wbCL.PreviewKeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class