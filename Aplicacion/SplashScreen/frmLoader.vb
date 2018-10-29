Imports System.Windows.Forms
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Interfaces
Public Class frmLoader
    Implements IObserver

    Private Sub btn_OK_Click(sender As Object, e As EventArgs) Handles btn_OK.Click
        If (txtPassword.Text.Length < 1 Or txtUser.Text.Length < 1) Then
            MsgBox("Ingrese datos de usuario", vbOKOnly, "Error!")
            Return
        End If
        Try
            TryCast(sender, Button).Enabled = False
            GCobros.getInstance().Register(Me)
            GCliente.Instance()
            GEmpresa.getInstance()
            If GCobros.getInstance().Iniciar(txtUser.Text, txtPassword.Text) Then
                DialogResult = DialogResult.OK
            Else
                DialogResult = DialogResult.Cancel
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            txtInformacion.Text = ""
        Finally
            TryCast(sender, Button).Enabled = True
        End Try
    End Sub

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtInformacion_TextChanged(sender As Object, e As EventArgs) Handles txtInformacion.TextChanged
        Application.DoEvents()
        Me.Refresh()
    End Sub

    Private Sub frmSplashScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.F11 Then
            Dim fpar As New frmParametros()
            fpar.Show()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btn_OK.PerformClick()
        End If
    End Sub

    Public Sub Actualizar(O As Object) Implements IObserver.Update
        If TypeOf O Is String Then
            txtInformacion.Text = TryCast(O, String)
        End If
    End Sub


End Class