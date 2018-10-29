Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Collections
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms




Public Class frmAsociadosMain
    Private _Cliente As ClienteActivo

    Private Sub frmAsociadosMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

   

    Private Sub _Asociar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GTitular_Enter(sender As Object, e As EventArgs) Handles GTitular.Enter

    End Sub

    Private Sub CargarDatos()
        txtNombretitular.Text = _Cliente.Nombre
        txtdirecciontitular.Text = _Cliente.Direccion
        txttelefonotitular.Text = _Cliente.Telefono
        GridAutorizadas.DataSource = _Cliente.MisAutorizados
        With GridAutorizadas
            '.Columns("DOCUMENTO").Visible = False
            .Columns("Documento").DisplayIndex = 0
            .Columns("Nombre").DisplayIndex = 1
            .Columns("Direccion").DisplayIndex = 2
            .Columns("Telefono").DisplayIndex = 3
            .Columns("Cta").DisplayIndex = 4
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If Len(txtCuenta.Text) < 1 Then
            MsgBox("Debe indicar numero de cliente", vbOKOnly, "Error")
            Return
        End If
        Try
            _Cliente = GCliente.Instance.getByID(Convert.ToInt32(txtCuenta.Text), False)
            CargarDatos()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error!")
        End Try
    End Sub




    Private Sub LinkNuevo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNuevo.LinkClicked
        Dim frmNuevo As New frmAsociadoNuevo(_Cliente)
        frmNuevo.Show()
    End Sub



    Private Sub LinkModificar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim Doc As Integer
        Doc = GridAutorizadas.Item("Documento", GridAutorizadas.CurrentRow.Index).Value
        Dim Persona As PersonaAutorizada = Nothing
        For Each P As PersonaAutorizada In _Cliente.MisAutorizados
            If P.Documento = Doc Then
                Persona = P
            End If
        Next


        If Not IsNothing(Persona) Then
            'Dim frmModificar As New frmAsociadosModificar(Persona)
            'frmModificar.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            'frmModificar.Dock = DockStyle.Fill
            'frmModificar.TopLevel = False

            'frmModificar.Show()
        End If


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtdirecciontitular_TextChanged(sender As Object, e As EventArgs) Handles txtdirecciontitular.TextChanged

    End Sub

    Private Sub GridAutorizadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridAutorizadas.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub txtCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCuenta.Text.Length < 1 Then
                MsgBox("Indique numero de cliente", vbOKOnly, "Error!")
                Return
            End If
            Try
                _Cliente = GCliente.Instance.getByID(txtCuenta.Text, False)
                CargarDatos()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Error!")
            End Try
        End If
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If txtCuenta.Text.Length < 1 Then
            MsgBox("Indique numero de cliente", vbOKOnly, "Error!")
            Return
        End If
        Try
            _Cliente = GCliente.Instance.getByID(Convert.ToInt32(txtCuenta.Text), False)
            CargarDatos()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error!")
        End Try
    End Sub

    Private Sub LinkModificar_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkModificar.LinkClicked
        If IsNothing(_Cliente) Then
            MsgBox("Debe cargar una cuenta primero", vbOKOnly, "Error!")
            Return
        End If

        Dim SubCta As Integer = GridAutorizadas.Item("cta", GridAutorizadas.CurrentRow.Index).Value
        Dim Autorizada As Integer = GridAutorizadas.Item("Documento", GridAutorizadas.CurrentRow.Index).Value

        Dim PersonaAutorizada As PersonaAutorizada = PersonaAut(SubCta, Autorizada)

        Dim frmNuevo As New frmAsociadosModificar(_Cliente, PersonaAutorizada, SubCta)
        frmNuevo.Show()
    End Sub

    Private Function PersonaAut(ByVal xCuenta, ByVal xDocumento) As PersonaAutorizada
        For Each SC As SubCuenta In _Cliente.SubCuentas
            If SC.Codigo = xCuenta Then
                For Each PA As PersonaAutorizada In SC.Autorizados
                    If PA.Documento = xDocumento Then
                        Return PA
                    End If
                Next
            End If
        Next
        Return Nothing
    End Function
End Class