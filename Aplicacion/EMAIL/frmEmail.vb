Imports Aguiñagalde.Entidades
Imports System.Net.Mail
Imports Aguiñagalde.Gestoras



Public Class frmEmail
    Private _Cliente As ClienteActivo
    Private _Adjunto As Attachment
    Public Sub New(ByVal xCliente As ClienteActivo, ByVal xAdjunto As Attachment)
        InitializeComponent()
        _Cliente = xCliente
        _Adjunto = xAdjunto
    End Sub


    Private Sub DibujarLinea()
        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Red)
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = Me.CreateGraphics()
        formGraphics.DrawLine(myPen, 0, 0, 200, 200)
        myPen.Dispose()
        formGraphics.Dispose()
    End Sub

    Private Sub frmEmail_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtReceptor.Text = _Cliente.CamposLibres.Email
        If Not IsNothing(_Adjunto) Then
            lblAdjunto.Text = _Adjunto.Name
        End If
    End Sub

    Private Sub btnEnviarEmail_Click(sender As Object, e As EventArgs) Handles btnEnviarEmail.Click
        Try
            GEmpresa.getInstance().EnviarCorreo(txtReceptor.Text, txtAsunto.Text, txtMensaje.Text, _Adjunto)
            MsgBox("El correo fue enviado correctamente", vbOKOnly, "Exito!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class