Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Collections
Imports System.Windows.Forms
Imports System.Linq

Public Class frmOrdenesCompra
    Private _Cliente As ClienteActivo

    Private Sub CargarDatos()
        cbSubCuentas.DataSource = _Cliente.SubCuentas
    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtCliente.Text < 0 Then
                MsgBox("El numero de cuenta no es correcto", vbOKOnly, "Error!")
                Return
            End If
            If Not Tools.Numeros.IsNumeric(txtCliente.Text) Then
                MsgBox("El numero de orden no es correcto", vbOKOnly, "Error!")
            End If
            If Val(txtCliente.Text) > 59999 And Val(txtCliente.Text) < 100000 Then
                Return
            End If
            If (txtCliente.Text.Length > 5 And txtCliente.Text.Length < 11) Then
                If Not Tools.Numeros.Cedula(Val(txtCliente.Text)) Then
                    Return
                End If
            End If
            _Cliente = GCliente.Instance().getByID(Val(txtCliente.Text), False)
            CargarDatos()
        End If
    End Sub




    Private Sub frmOrdenesCompra_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If IsNothing(_Cliente) Then
            MsgBox("Debe cargar un cliente antes de guardar una orden", vbOKOnly, "Error!")
            Return
        End If
        If txtNumOrden.Text.Length < 1 Or txtNumOrden.Text.Length > 15 Then
            MsgBox("El numero de orden no es correcto", vbOKOnly, "Error!")
            Return
        End If

        Dim Orden As New OrdenCompra(_Cliente.IdCliente, txtNumOrden.Text)
        Orden.SubCuenta = TryCast(cbSubCuentas.SelectedItem, SubCuenta).Codigo
        If txtDescripcion.Text.Length > 0 Then
            Orden.Descripcion = txtDescripcion.Text
        End If

        Try
            GCliente.Instance().AgregarOrden(Orden)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class