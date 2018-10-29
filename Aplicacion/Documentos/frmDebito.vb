Imports Aguiñagalde.Entidades
Imports System.Collections.Generic
Imports Aguiñagalde.Gestoras
Imports System.Windows.Forms

Public Class frmDebito
    Private _Cliente As ClienteActivo
    Private _Movimientos As List(Of Movimiento) = Nothing
    Private _Moneda As Moneda
    Private Sub txtCliente_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtCliente.Text.Length < 1 Then
                MsgBox("Debe ingresar un numero de cliente", vbOKOnly, "Error!")
                Return
            End If
            Try
                _Cliente = GCliente.Instance().getByID(txtCliente.Text, False)
                CargarDatos()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Error!")
            End Try
        End If
    End Sub

    Private Sub txtCliente_MouseDown(sender As Object, e As Windows.Forms.MouseEventArgs) Handles txtCliente.MouseDown

    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged

    End Sub


    Private Sub CargarDatos()
        txtNombre.Text = _Cliente.Nombre
        txtDireccion.Text = _Cliente.Direccion
        txtNombre.ForeColor = Drawing.Color.Black
        txtDireccion.ForeColor = Drawing.Color.Black
        cbMonedas.DataSource = GCobros.getInstance().getMonedas()
        cbSubCuenta.DataSource = _Cliente.SubCuentas
    End Sub

    Private Sub frmDebito_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmDebito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("es-UY")
        R.NumberFormat.CurrencyDecimalSeparator = ","
        R.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = R
    End Sub

    Private Sub btnBonifGlobal_Click(sender As Object, e As EventArgs) Handles btnBonifGlobal.Click
        If (Convert.ToDecimal(tbimporte.Text) < 0) Then
            MsgBox("El importe ingresado no es correcto")
            Return
        End If
        If txtComentario.Text.Length < 1 Then
            MsgBox("Debe ingresar un comentario")
            Return
        End If

        Try
            If MsgBox("Desea hacer el debito", vbOKCancel, "Esta seguro") = MsgBoxResult.Cancel Then
                Return
            End If
            TryCast(sender, Button).Enabled = False
            Dim xImporte As Decimal = Convert.ToDecimal(tbimporte.Text)
            If txtLinea.Text.Length < 1 Then
                GCobros.getInstance().Debitar(xImporte, _Cliente, cbMonedas.SelectedItem, cbSubCuenta.SelectedItem, txtComentario.Text, chkImprimir.Checked, "DIFERENCIA DE VENTAS")
            Else
                GCobros.getInstance().Debitar(xImporte, _Cliente, cbMonedas.SelectedItem, cbSubCuenta.SelectedItem, txtComentario.Text, chkImprimir.Checked, txtLinea.Text)
            End If
            MsgBox("debito realizada con exito", vbOKOnly, "Exito!")
            TryCast(sender, Button).Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            TryCast(sender, Button).Enabled = True
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub tbimporte_TextChanged(sender As Object, e As EventArgs) Handles tbimporte.TextChanged

    End Sub

    Private Sub tbimporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbimporte.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
            SendKeys.Send(".")
            Return
        End If
    End Sub
End Class