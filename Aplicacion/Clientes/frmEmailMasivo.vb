Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmEmailMasivo
    Private tClientes As DataTable = GCliente.Instance().TablaClientes
    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""



    Private Sub btngetClientes_Click(sender As Object, e As EventArgs) Handles btngetClientes.Click
        tClientes = GCliente.Instance().TablaClientes

    End Sub

    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        mFiltro = ""
        '' mActiva = (sender.Columns(e.ColumnIndex).Name)
        'With sender
        '    .Columns(mIndex).DefaultCellStyle.BackColor = Color.White
        '    .Columns(e.ColumnIndex).DefaultCellStyle.BackColor = Color.Beige
        'End With
        'mIndex = e.ColumnIndex


        Try

            tClientes = (From Cliente In tClientes.AsEnumerable()
                         Where Cliente("EMAIL").Contains("@")
                         Select Cliente).CopyToDataTable()
            dgClientes.DataSource = tClientes
            lblCantidad.Text = "cuentas: " & dgClientes.Rows.Count

        Catch ex As Exception


        End Try
    End Sub

    Private Sub frmEmailMasivo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Close()
        End If
    End Sub
End Class