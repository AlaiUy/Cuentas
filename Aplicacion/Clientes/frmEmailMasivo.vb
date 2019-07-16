Imports System.Collections.Generic
Imports System.Data
Imports System.Globalization
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
        If Not IsNothing(tClientes) Then
            GCliente.Instance().Update()
        End If
        tClientes = GCliente.Instance().TablaClientes
        dgClientes.DataSource = tClientes
    End Sub

    Private Sub btnFiltro_Click(sender As Object, e As EventArgs) Handles btnFiltro.Click
        mFiltro = ""
        Try

            tClientes = (From Cliente In tClientes.AsEnumerable()
                         Where Cliente("EMAIL").Contains("@") And (Cliente("TIPO") <> 7 And Cliente("TIPO") <> 20) And (Cliente("ZONA") <> "99" And Cliente("ZONA") <> "69") And (Not Cliente("EMAIL").Contains(";") Or Cliente("EMAIL").Contains(",")) And Cliente("EMAILENVIADO") = 0
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

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each r As DataGridViewRow In dgClientes.SelectedRows
            dgClientes.Rows.Remove(r)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Lista As List(Of String) = New List(Of String)
        Dim body As String = "Adjuntamos un comunicado para nuestros clientes."
        Try
            For Each Row As DataGridViewRow In dgClientes.Rows
                Dim email As String = Row.Cells("EMAIL").Value
                Lista.Add(email)

            Next
            GEmpresa.getInstance().EnvioECMensual(Lista, "C:\Com\1.pdf", "COMUNICADO.pdf", "COMUNICADO", body)
            MsgBox("El correo fue enviado correctamente", vbOKOnly, "Exito!")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellContentClick

    End Sub

    Private Sub dgClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgClientes.CellClick
        Dim zSuma As Decimal = 0
        For Each Row As DataGridViewRow In dgClientes.SelectedRows
            zSuma += 1
        Next
        Label2.Text = zSuma
    End Sub
End Class