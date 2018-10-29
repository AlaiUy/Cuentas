Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmAgendaCobros
    Dim _Cliente As ClienteActivo

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        Try
            GCobros.getInstance.addAgendaLin(txtCliente.Text, dtvisita.Value.ToShortDateString, GCobros.getInstance.Caja.Usuario.CodUsuario, txtDireccionVisita.Text, txtComentario.Text)
            MsgBox("Agenda agregada exitosamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                _Cliente = GCliente.Instance.getByID(txtCliente.Text, True)
                CargarDatos()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CargarDatos()
        txtDireccion.Text = _Cliente.Direccion
        txtDireccionVisita.Text = _Cliente.Direccion
        txtNombre.Text = _Cliente.Nombre
    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged

    End Sub

    Private Sub frmAgendaCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmAgendaCobros_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class