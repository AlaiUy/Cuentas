Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmSubCuentaNueva
    Private _Cliente As ClienteActivo

    Public Sub New(ByVal xCliente As ClienteActivo)
        InitializeComponent()
        _Cliente = xCliente
    End Sub



    Private Sub CargarFormulario()
        If IsNothing(_Cliente) Then
            MsgBox("Debe cargar un cliente primero", vbOKOnly, "Error!")
            Return
        End If
        If _Cliente.SubCuentas.Count < 1 Then
            NombreCta.Text = _Cliente.Nombre
            DireccionCta.Text = _Cliente.Direccion
            TelefonoCta.Text = _Cliente.Telefono
            RutCta.Text = _Cliente.Rut
        End If
        cbTipo.DataSource = GCliente.Instance().TiposCta()
        cbTipo.DisplayMember = "Nombre"
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim SubCuenta As New SubCuenta(_Cliente.IdCliente, _Cliente.SubCuentas.Count + 1)
        SubCuenta.Descatalogado = False
        SubCuenta.Direccion = DireccionCta.Text
        SubCuenta.Tipo = DirectCast(cbTipo.SelectedItem, TipoSubCta).Codigo
        SubCuenta.Telefono = Val(TelefonoCta.Text)
        SubCuenta.Nombre = NombreCta.Text
        SubCuenta.Rut = RutCta.Text
        Try
            GCliente.Instance.AgregarSubCuenta(_Cliente, SubCuenta)
            MsgBox("Sub cuenta agregada exitosamente", vbOKOnly, "Error!")
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSubCuentaNueva_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub TelefonoCta_TextChanged(sender As Object, e As EventArgs) Handles TelefonoCta.TextChanged

    End Sub

    Private Sub frmSubCuentaNueva_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarFormulario()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class