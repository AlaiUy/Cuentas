Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes

Public Class frmAgendaCobros
    Dim _Cliente As ClienteActivo

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            GCobros.getInstance.addAgendaLin(txtCliente.Text, dtvisita.Value.ToShortDateString, GCobros.getInstance.Caja.Usuario.CodUsuario, txtDireccionVisita.Text, txtComentario.Text)
            MsgBox("Agenda agregada exitosamente")
            BorrarCampos()
        Catch ex As Exception
            MsgBox(ex.Message)
            BorrarCampos()
        End Try
    End Sub



    Private Sub BorrarCampos()
        txtCliente.Text = ""
        txtDireccion.Text = ""
        txtDireccion.BackColor = Drawing.Color.White
        txtDireccionVisita.Text = ""
        txtNombre.Text = ""
        txtNombre.BackColor = Drawing.Color.White
        txtCliente.Focus()
        dtvisita.Value = Now.ToShortDateString()
    End Sub

    Private Sub CargarDatos()
        txtDireccion.Text = _Cliente.Direccion
        txtDireccion.BackColor = Drawing.Color.White
        txtDireccionVisita.Text = _Cliente.Direccion
        txtNombre.Text = _Cliente.Nombre
        txtNombre.BackColor = Drawing.Color.White
    End Sub



    Private Sub frmAgendaCobros_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub





    Private Sub txtCliente_LostFocus(sender As Object, e As EventArgs) Handles txtCliente.LostFocus
        Try
            If (txtCliente.Text <> String.Empty) Then
                _Cliente = GCliente.Instance.getByID(txtCliente.Text, True)
                CargarDatos()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        Try
            Dim A As Agenda = GCobros.getInstance().getAgenda(Today.ToShortDateString)
            Dim Imp As New Impresion()
            Imp.Imprimir(A, True, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If (txtCliente.Text <> String.Empty) Then
                    _Cliente = GCliente.Instance.getByID(txtCliente.Text, True)
                    CargarDatos()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPrintAgend_Click(sender As Object, e As EventArgs) Handles btnPrintAgend.Click
        Try
            Dim A As Agenda = GCobros.getInstance().getAgenda(DatePick.Value.ToShortDateString())
            Dim Imp As New Impresion()
            Imp.Imprimir(A, True, Nothing)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class