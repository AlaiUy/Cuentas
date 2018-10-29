Imports System.Net.Mail
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmEnvioEmail
    Private _Adjunto As Attachment
    Private _Cliente As ClienteActivo

    Public Sub New(ByVal xCliente As ClienteActivo, ByVal xAdjunto As Attachment)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _Adjunto = xAdjunto
        _Cliente = xCliente
    End Sub

    Private Sub frmEnvioEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmEnvioEmail_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopularFormulario()
    End Sub

    Private Sub PopularFormulario()
        txtEmailCliente.Text = _Cliente.CamposLibres.Email
        lblTextAdjunto.Text = _Adjunto.Name

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            TryCast(sender, Button).Enabled = False
            GEmpresa.getInstance().EnviarCorreo(txtEmailCliente.Text, txtAsunto.Text, txtCuerpo.Text, _Adjunto)
            MsgBox("El correo fue enviado correctamente", vbOKOnly, "Exito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            TryCast(sender, Button).Enabled = True
        End Try
    End Sub
End Class