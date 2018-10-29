Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Windows.Forms
Imports Aguiñagalde.Interfaces

Public Class frmCuentasMain
    Private _Cliente As ClienteActivo

    Private Sub frmCuentasMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            _Cliente = GCliente.Instance.getByID(txtCuenta.Text, False)
            GridCuentas.DataSource = _Cliente.SubCuentas
            txtnombre.Text = _Cliente.Nombre
            txtdireccion.Text = _Cliente.Direccion
            With GridCuentas
                '.Columns("DOCUMENTO").Visible = False
                .Columns("Nombre").DisplayIndex = 0
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
    End Sub

    Private Sub LinkNuevo_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkNuevo.LinkClicked
        If IsNothing(_Cliente) Then
            MsgBox("Debe seleccionar un cliente primero", vbOKOnly, "Error!")
            Return
        End If
        Dim frmNuevo As New frmSubCuentaNueva(_Cliente)
        frmNuevo.Show()
    End Sub

    Private Sub txtCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                _Cliente = GCliente.Instance().getByID(txtCuenta.Text, False)
                GridCuentas.DataSource = _Cliente.SubCuentas
                txtnombre.Text = _Cliente.Nombre
                txtdireccion.Text = _Cliente.Direccion
                With GridCuentas
                    '.Columns("DOCUMENTO").Visible = False
                    .Columns("Nombre").DisplayIndex = 0
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If IsNothing(_Cliente) Then
            MsgBox("Debe seleccionar un cliente primero", vbOKOnly, "Error!")
            Return
        End If
        Dim SubCta As Integer = GridCuentas.Item("CODIGO", GridCuentas.CurrentRow.Index).Value


        Dim SC As SubCuenta = getSubCuenta(SubCta)

        If Not IsNothing(SC) Then
            Dim frmModificar As New frmSubCuentaMod(SC)
            frmModificar.Show()
        End If
        
    End Sub

    Private Function getSubCuenta(ByVal xId As Integer) As SubCuenta
        For Each SC In _Cliente.SubCuentas
            If SC.Codigo = xId Then
                Return SC
            End If
        Next
        Return Nothing
    End Function
End Class