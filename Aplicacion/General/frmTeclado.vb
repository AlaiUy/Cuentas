Imports System.Windows.Forms

Public Class frmTeclado

    Private _Numero As Decimal = -1

    Public ReadOnly Property Retorno() As Decimal
        Get
            Return _Numero
        End Get
    End Property
    Private Sub TextBox1_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If (e.KeyCode = Windows.Forms.Keys.Enter) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            If TextBox1.Text.Length > 0 Then
                _Numero = Convert.ToDecimal(TextBox1.Text)
            End If

        End If

        If (e.KeyCode = Windows.Forms.Keys.Escape) Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        If DialogResult = DialogResult.Cancel Or _Numero > -1 Then
            Close()
        End If
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
            SendKeys.Send(".")
            Return
        End If
    End Sub
End Class