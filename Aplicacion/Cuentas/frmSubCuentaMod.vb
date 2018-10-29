Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmSubCuentaMod
    Private _SubCuenta As SubCuenta

    Public Sub New(ByVal xSubCuenta As SubCuenta)
        InitializeComponent()
        _SubCuenta = xSubCuenta
        
    End Sub

    Private Sub CargarDatos()
        txtNombreCta.Text = _SubCuenta.Nombre
        txtDireccionCta.Text = _SubCuenta.Direccion
        txtRutCta.Text = _SubCuenta.Rut
        txtTelefonoCta.Text = _SubCuenta.Telefono
        cbTipo.DataSource = GCliente.Instance().TiposCta()
        chkDescatalogada.Checked = _SubCuenta.Descatalogado

    End Sub

    Private Sub frmSubCuentaMod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '//1- Usar cuentas corrientes
        '//2- Usar Cobros
        '//3- ver contados pendientes
        '//4- Imprimir recibos de personal
        '//5- cambios en modificar cliente
        '//6- permitir bonificacion en cuentas con tarifas contado
        '//7- cargar cuentas de personal
        '//8- Anular recibos

        _SubCuenta.Nombre = txtNombreCta.Text
        _SubCuenta.Direccion = txtDireccionCta.Text
        _SubCuenta.Telefono = txtTelefonoCta.Text
        _SubCuenta.Descatalogado = chkDescatalogada.Checked
        _SubCuenta.Rut = txtRutCta.Text
        '160075830019
        If _SubCuenta.Rut.Length < 11 Then
            _SubCuenta.Rut = txtRutCta.Text
        ElseIf (_SubCuenta.Rut <> _SubCuenta.Rut) And Not GCobros.getInstance().Caja.Usuario.Permiso(5) Then
            MsgBox("El rut no puede ser modificado", vbOKOnly, "Consultar!")
            Return
        End If

        Try
            GCliente.Instance().ModificarSubCuenta(_SubCuenta)
            MsgBox("Sub cuenta actualizada", vbOKOnly, "Exito!")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmSubCuentaMod_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub
End Class