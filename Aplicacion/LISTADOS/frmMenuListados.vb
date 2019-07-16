Imports System.Data
Imports System.Windows.Forms
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes

Public Class frmMenuListados
    Private Sub frmMenuListados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmMenuListados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnListarInco_Click(sender As Object, e As EventArgs) Handles btnListarInco.Click
        Try
            Dim ruta As String = "C:/INFORMES/inco.xlsx"
            Dim Inco As DataTable
            Inco = GCliente.Instance().getClientesIncobrables()
            Dim Imp As Impresion = New Impresion()
            Imp.export(Inco, ruta)
            System.Diagnostics.Process.Start(ruta)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class