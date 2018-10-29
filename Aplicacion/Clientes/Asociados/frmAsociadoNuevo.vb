Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Windows.Forms
Imports System.Collections.Generic

Imports Aguiñagalde.Tools






Public Class frmAsociadoNuevo

    Private _Titular As ClienteActivo
    'Private _Grilla As DataGridView


    Public Sub New(ByVal xCliente As ClienteActivo)
        InitializeComponent()
        _Titular = xCliente
        '_Grilla = Grilla
        For Each S As SubCuenta In xCliente.SubCuentas
            Cuentas.Items.Add(S)
        Next
    End Sub
    Private Sub GAutorizado_Enter(sender As Object, e As EventArgs)
        Me.Anchor = Windows.Forms.AnchorStyles.Bottom And Windows.Forms.AnchorStyles.Left And Windows.Forms.AnchorStyles.Right And Windows.Forms.AnchorStyles.Top
    End Sub


    Private Sub frmAsociadoNuevo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub frmAsociadoNuevo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel10.AutoScroll = True
    End Sub

  
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Lista As New List(Of SubCuenta)
        Dim Nombre As String
        Dim Doc As String
        Dim Direccion As String

        Nombre = txtAutorizadoNombre.Text
        Doc = txtAutorizadoDoc.Text
        Direccion = txtAutorizadoDireccion.Text
        Dim P As New PersonaAutorizada(Nombre, Direccion, Doc)
        P.Celular = Val(txtAutorizadoCelular.Text)


        P.Email = txtAutorizadoEmail.Text
        P.FechaFinal = AutorizadoHasta.Value
        P.Descatalogada = False


        P.Telefono = Val(txtAutorizadoTelefono.Text)
        For Each S As SubCuenta In Asociadas.Items
            Lista.Add(S)
        Next


        If Lista.Count > 0 Then
            Try
                If GCliente.Instance.addAsociado(_Titular, P, Lista) Then
                    MsgBox("Asociado agregado con exito")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No se seleccionaron cuentas para asociar.")
            Return
        End If
        




    End Sub


    Private Sub btnAsociarLista_Click(sender As Object, e As EventArgs) Handles btnAsociarLista.Click
        If (Cuentas.SelectedIndex > -1) Then
            Dim SC As SubCuenta = Nothing
            SC = Cuentas.SelectedItem
            Cuentas.Items.Remove(SC)
            Asociadas.Items.Add(SC)
        End If
    End Sub

  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Asociadas.SelectedIndex > -1) Then
            Dim SC As SubCuenta = Nothing
            SC = Asociadas.SelectedItem
            Asociadas.Items.Remove(SC)
            Cuentas.Items.Add(SC)
        End If
    End Sub

  
    Private Sub LinkDocumento_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDocumento.LinkClicked
        If Not Tools.Numeros.IsNumeric(txtAutorizadoDoc.Text) Then
            MsgBox("El documento ingresado no es valido", vbOK, "Error!")
            Return
        End If

        If Not (Tools.Numeros.Cedula(Val(txtAutorizadoDoc.Text))) Then
            MsgBox("El documento ingresado no es verificable", vbOK, "Error!")
            Return
        End If


        If Len(txtAutorizadoDoc.Text) <> 8 Then
            MsgBox("El documento ingresado no es valido", vbOK, "Error!")
            Return
        End If
        Dim NuevoCliente As ClienteActivo
        Try

            NuevoCliente = GCliente.Instance.getByID(txtAutorizadoDoc.Text, False)
            txtAutorizadoNombre.Text = NuevoCliente.Nombre
            txtAutorizadoDireccion.Text = NuevoCliente.Direccion

            txtAutorizadoCelular.Text = NuevoCliente.Celular

            txtAutorizadoTelefono.Text = NuevoCliente.Telefono
            txtAutorizadoEmail.Text = NuevoCliente.Email
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class