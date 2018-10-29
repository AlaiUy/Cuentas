Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras


Public Class frmAsociadosModificar

    Private _Titular As ClienteActivo
    Private _SubCta As Integer = -1
    Private _Autorizado As PersonaAutorizada

    Public Sub New(ByVal xPersona As ClienteActivo, ByVal xAutorizado As PersonaAutorizada, ByVal xSubCta As Integer)
        InitializeComponent()
        _Titular = xPersona
        _SubCta = xSubCta
        _Autorizado = xAutorizado
        txtAutorizadoDoc.Text = xAutorizado.Documento
        txtAutorizadoNombre.Text = xAutorizado.Nombre
        txtAutorizadoDireccion.Text = xAutorizado.Direccion
        txtAutorizadoCelular.Text = xAutorizado.Celular
        txtAutorizadoTelefono.Text = xAutorizado.Telefono
        txtAutorizadoEmail.Text = xAutorizado.Email
        chkDescatalogada.Checked = xAutorizado.Descatalogada

        'AutorizadoHasta.Value = xPersona.FechaFinal
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Tools.Numeros.Cedula(Val(txtAutorizadoDoc.Text)) Then
        Else
            MsgBox("El documento ingresado es incorrecto", vbOKOnly, "Revisar Documento!")
            Return
        End If
        _Autorizado.Nombre = txtAutorizadoNombre.Text
        _Autorizado.Celular = txtAutorizadoCelular.Text
        _Autorizado.Descatalogada = chkDescatalogada.CheckState
        _Autorizado.Direccion = txtAutorizadoDireccion.Text
        _Autorizado.Email = txtAutorizadoEmail.Text
        _Autorizado.FechaFinal = AutorizadoHasta.Value
        Try
            GCliente.Instance().ModificarAsociado(_Autorizado, _Titular.IdCliente)
            MsgBox("Actualizacion Correcta", vbOKOnly, "Exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles btnGuardar.KeyDown

    End Sub

    Private Sub frmAsociadosModificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmAsociadosModificar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class