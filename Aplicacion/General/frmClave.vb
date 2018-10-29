Imports System.Security.Cryptography
Imports System.Windows.Forms

Public Class frmClave

    Private _Clave As String

    Public ReadOnly Property Clave As String
        Get
            Return _Clave
        End Get

    End Property

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            _Clave = MD5EncryptPass(txtPassword.Text)
            Me.DialogResult = DialogResult.OK
        End If
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub frmClave_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Function MD5EncryptPass(ByVal StrPass As String) As String

        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strPassOutput As String
        Dim i As Integer
        strPassOutput = ""

        md5 = New MD5CryptoServiceProvider

        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            strPassOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return strPassOutput

    End Function
End Class