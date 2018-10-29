Imports System.Windows.Forms

Public Class frmCtaDiaMenu
    Private Sub btnVerFacturas_Click(sender As Object, e As EventArgs) Handles btnVerFacturas.Click
        'For Each f As Form In Application.OpenForms
        '    If f.Name = "frmCreditoDiaMain" Then
        '        TryCast(f, frmCreditoDiaMain).Up()
        '        f.TopMost = True
        '        Return
        '    End If
        'Next
        Dim fMain As frmCreditoDiaMain = frmCreditoDiaMain.getInstance()
        fMain.Show()


    End Sub
End Class