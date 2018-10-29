Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmNewKey
    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        Dim U As Usuario = GCobros.getInstance().Caja.Usuario
        U.Password = txtpass.Text
        Try
            GCobros.getInstance.CambiarCalve(U)
            MsgBox("Clave cambiada correctamente", vbOKOnly, "Exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmNewKey_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmNewKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class