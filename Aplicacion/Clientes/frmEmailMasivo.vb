Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Net.Mail
Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes

Public Class frmEmailMasivo
    Private tClientes As DataTable = GCliente.Instance().TablaClientes
    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""



    Private Sub btngetClientes_Click(sender As Object, e As EventArgs) Handles btngetClientes.Click
        tClientes = GCliente.Instance().TablaClientes
        dgClientes.DataSource = tClientes
    End Sub

    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        mFiltro = ""
        Try

            tClientes = (From Cliente In tClientes.AsEnumerable()
                         Where Cliente("EMAIL").Contains("@")
                         Select Cliente).CopyToDataTable()
            dgClientes.DataSource = tClientes
            lblCantidad.Text = "cuentas: " & dgClientes.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub frmEmailMasivo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim Lista As List(Of Integer) = New List(Of Integer)

        Try
            For Each Row As DataGridViewRow In dgClientes.Rows
                Dim xCodCliente As Integer = Row.Cells("CODIGO").Value
                Lista.Add(xCodCliente)

            Next

            GEmpresa.getInstance().EnvioECMensual(Lista)
            MsgBox("El correo fue enviado correctamente", vbOKOnly, "Exito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each r As DataGridViewRow In dgClientes.SelectedRows
            dgClientes.Rows.Remove(r)
        Next
    End Sub
End Class