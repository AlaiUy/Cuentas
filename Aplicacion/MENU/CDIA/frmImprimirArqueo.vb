Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmImprimirArqueo
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        If txtNumeroArqueo.Text.Length < 1 Then
            Return
        End If
        If Not IsNumeric(txtNumeroArqueo.Text) Then
            Return
        End If
        Try
            Dim A As Arqueo = GCobros.getInstance.ObtenerArqueoByID(Val(txtNumeroArqueo.Text), GCobros.getInstance.CajaDia.Id)
            GCobros.getInstance.ImprimirArqueo(A)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmImprimirArqueo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmImprimirArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class