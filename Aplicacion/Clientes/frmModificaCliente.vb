Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Windows.Forms

Public Class frmModificaCliente

    Private _Cliente As ClienteActivo
    'Private _Anterior As ClienteActivo
    Private _Clave As String = ""





    Private Sub CargarCampos()
        PopularTabs()
        ChkDic.Checked = _Cliente.DIC
        txtCedula.Text = _Cliente.Cedula
        txtactvidad.Text = _Cliente.CamposLibres.Actividad
        txtCuenta.Text = _Cliente.IdCliente
        txtnombre.Text = _Cliente.Nombre
        txtnombrecomercial.Text = _Cliente.NombreComercial
        txtEmail.Text = _Cliente.CamposLibres.Email
        txtTelefono.Text = _Cliente.Telefono
        txtCelular.Text = _Cliente.Celular
        If _Cliente.Fecha.ToShortDateString <= Date.MinValue.ToShortDateString Then
            dtpnacimiento.Value = dtpnacimiento.MinDate
        Else
            dtpnacimiento.Value = _Cliente.Fecha.ToShortDateString
        End If
        txtPais.Text = _Cliente.Pais
        txtDpto.Text = _Cliente.Dpto
        txtpostal.Text = _Cliente.Postal
        txtcobrador.Text = _Cliente.Cobrador
        txtfax.Text = _Cliente.Fax
        txtDireccion.Text = _Cliente.Direccion
        txtdireccionalternativa.Text = _Cliente.DireccionAlternativa
        CBType.SelectedIndex = BuscarCombo(CBType, _Cliente.Type)
        txtcierre.Text = _Cliente.Cierre
        txtactconyuge.Text = _Cliente.CamposLibres.ConyugeActividad
        txtingconyuge.Text = _Cliente.CamposLibres.ConyugeIngresos
        txtcargoconyuge.Text = _Cliente.CamposLibres.ConyugeCargo
        txtactconyuge.Text = _Cliente.CamposLibres.ConyugeActividad
        txtactvidad.Text = _Cliente.CamposLibres.Actividad
        txtingreso.Text = _Cliente.CamposLibres.Ingresos
        txtcargo.Text = _Cliente.CamposLibres.Cargo
        txtantiguedad.Text = _Cliente.CamposLibres.Antiguedad
        txtcivil.Text = _Cliente.CamposLibres.Civil
        txtalquiler.Text = _Cliente.CamposLibres.Alquiler
        txtbienes.Text = _Cliente.CamposLibres.Bienes
        txtvehiculos.Text = _Cliente.CamposLibres.Vehiculos
        txtplasticos.Text = _Cliente.CamposLibres.Plasticos
        txtcomerciales.Text = _Cliente.CamposLibres.Comerciales
        txtobs.Text = _Cliente.Observaciones
        txtobs1.Text = _Cliente.CamposLibres.OtrasObservaciones
        txtRuta.Text = _Cliente.Ruta
        Dim Index As Integer = 0

        Dim FP As FPago = Nothing
        'FP = GEmpresa.getInstance().getFPagoByID(_Cliente.FormaPago.Nombre)
        If Not IsNothing(_Cliente.FormaPago) Then

            Index = BuscarCombo(CBFpagos, _Cliente.FormaPago.Nombre)
            CBFpagos.SelectedIndex = Index
        Else
            FP = GCobros.getInstance().getFPagoByID(2)
            Index = BuscarCombo(CBFpagos, FP.Nombre)
            CBFpagos.SelectedIndex = Index
        End If

        If Not IsNothing(_Cliente.Moneda) Then
            Index = BuscarCombo(CBMonedas, _Cliente.Moneda.ToString())
            CBMonedas.SelectedIndex = Index
        End If

        If Not IsNothing(_Cliente.Tarifa) Then
            Index = BuscarCombo(CBTarifasVenta, _Cliente.Tarifa.Nombre)
            CBTarifasVenta.SelectedIndex = Index
        End If


        chk_activo.Checked = _Cliente.isActivo
        chk_dia.Checked = _Cliente.isActivoDia
        chk_fidelizado.Checked = _Cliente.isFidelizado
        chk_moneda.Checked = _Cliente.isMonedaUnica
        chk_orden.Checked = _Cliente.isOrden
        chkBloqueo.Checked = _Cliente.IsBloqueo
        TabPAListBoxSC.DataSource = _Cliente.SubCuentas
        chkSolotit.Checked = _Cliente.SoloTitular
        chkCerrada.Checked = _Cliente.Cerrada
    End Sub

    Private Sub PopularTabs()
        If _Cliente.Interno Then
            For Each T As TabPage In TabDatos.TabPages
                If (T.Name <> "TabPersonales") Then
                    T.Parent = Nothing
                End If
            Next
            Return
        Else
            If TabDatos.TabPages.Count < 2 Then
                TabDatos.TabPages.Add(TabCuenta)
                TabDatos.TabPages.Add(TabConyuge)
                TabDatos.TabPages.Add(TabCampos)
                TabDatos.TabPages.Add(TabPersonasA)
            End If
        End If
    End Sub

    Public Function BuscarCombo(ByVal Combo As ComboBox, ByVal xTexto As String)
        For Index As Integer = 0 To Combo.Items.Count - 1
            If xTexto = Combo.Items(Index).ToString() Then
                Return Index
            End If
        Next
        Return -1
    End Function

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal xCliente As ClienteActivo)
        InitializeComponent()
        CBFpagos.DataSource = GCobros.getInstance().getFormasPago()
        CBTarifasVenta.DataSource = GCobros.getInstance().getTarifasVenta()
        CBMonedas.DataSource = GCobros.getInstance().getMonedas()
        _Cliente = xCliente

        CargarCampos()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frmFiltro As New frmGrillaClientes
        frmFiltro.ShowDialog()
        If (frmFiltro.DialogResult = Windows.Forms.DialogResult.OK) Then
            _Cliente = frmFiltro.Cliente
            CargarCampos()
            frmFiltro.Close()

        End If
    End Sub

    Private Sub frmModificaCliente_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
        If e.KeyCode = Keys.F10 Then
            Dim frPass As New frmClave()
            frPass.TopMost = True
            frPass.ShowDialog()
            If frPass.DialogResult = DialogResult.OK Then
                _Clave = frPass.Clave()

            End If
            If frPass.DialogResult = DialogResult.Cancel Then
                frPass.Close()
            End If
        End If
    End Sub

    Private Sub Autorizar()
        chkSolotit.Enabled = True
        chk_moneda.Enabled = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If IsNothing(_Cliente) Then
            Return
        End If

        If _Cliente.IdCliente = Val(txtCuenta.Text) Then
            _Cliente.Nombre = txtnombre.Text
            _Cliente.NombreComercial = txtnombrecomercial.Text
            _Cliente.IsBloqueo = chkBloqueo.Checked
            _Cliente.DIC = ChkDic.Checked
            _Cliente.Descatalogado = False
            _Cliente.Direccion = txtDireccion.Text
            _Cliente.DireccionAlternativa = txtdireccionalternativa.Text
            _Cliente.CamposLibres.Email = txtEmail.Text
            _Cliente.Telefono = txtTelefono.Text
            _Cliente.Celular = txtCelular.Text
            _Cliente.Fecha = dtpnacimiento.Value
            _Cliente.Pais = txtPais.Text
            _Cliente.Dpto = txtDpto.Text
            _Cliente.Postal = Val(txtpostal.Text)
            _Cliente.Cobrador = txtcobrador.Text
            _Cliente.FormaPago = DirectCast(CBFpagos.SelectedItem, FPago)
            _Cliente.Type = CBType.SelectedItem.ToString()
            _Cliente.Cierre = Val(txtcierre.Text)
            _Cliente.Tarifa = DirectCast(CBTarifasVenta.SelectedItem, Tarifa)
            _Cliente.NombreComercial = txtnombrecomercial.Text
            _Cliente.Fax = Val(txtfax.Text)
            _Cliente.Moneda = DirectCast(CBMonedas.SelectedItem, Moneda)
            _Cliente.CamposLibres.ConyugeActividad = txtactconyuge.Text
            _Cliente.CamposLibres.ConyugeIngresos = Val(txtingconyuge.Text)
            _Cliente.CamposLibres.ConyugeCargo = txtcargoconyuge.Text
            _Cliente.CamposLibres.ConyugeAntiguedad = txtantigconyuge.Text
            _Cliente.CamposLibres.Actividad = txtactvidad.Text
            _Cliente.CamposLibres.Ingresos = Val(txtingreso.Text)
            _Cliente.CamposLibres.Cargo = txtcargo.Text
            _Cliente.CamposLibres.Antiguedad = txtantiguedad.Text
            _Cliente.CamposLibres.Civil = txtcivil.Text
            _Cliente.CamposLibres.Alquiler = txtalquiler.Text
            _Cliente.CamposLibres.Vehiculos = txtvehiculos.Text
            _Cliente.CamposLibres.Plasticos = txtplasticos.Text
            _Cliente.CamposLibres.Comerciales = txtcomerciales.Text
            _Cliente.Observaciones = txtobs.Text
            _Cliente.CamposLibres.OtrasObservaciones = txtobs1.Text
            _Cliente.CamposLibres.Conyuge = txtcDocumento.Text
            _Cliente.isActivo = chk_activo.Checked
            _Cliente.isActivoDia = chk_dia.Checked
            _Cliente.isFidelizado = chk_fidelizado.Checked
            _Cliente.isMonedaUnica = chk_moneda.Checked
            _Cliente.isOrden = chk_orden.Checked
            _Cliente.Cedula = LTrim(RTrim(txtCedula.Text))
            _Cliente.Ruta = txtRuta.Text
            _Cliente.SoloTitular = chkSolotit.Checked
            _Cliente.Cerrada = chkCerrada.Checked
            _Cliente.CamposLibres.Bienes = txtbienes.Text
            Try
                GCliente.Instance().Actualizar(_Cliente, _Clave)
                MsgBox("Cliente actualizado con exito")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub txtCuenta_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtCuenta.Text.ToString().Length < 1 Then
                Return
            End If
            Dim IdCliente As String = txtCuenta.Text
            Try
                _Cliente = GCliente.Instance().getByID(IdCliente, False)
                CargarCampos()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Error!")
            End Try
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frmModificaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsNothing(_Cliente) Then
            Try
                CBFpagos.DataSource = GCobros.getInstance().getFormasPago()
                CBTarifasVenta.DataSource = GCobros.getInstance().getTarifasVenta()
                CBMonedas.DataSource = GCobros.getInstance().getMonedas()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TabPAListBoxSC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabPAListBoxSC.SelectedIndexChanged
        Dim SC As SubCuenta = TryCast(TabPAListBoxSC.SelectedItem, SubCuenta)
        tabPAlistboxPA.DataSource = SC.Autorizados
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNothing(_Cliente) Then
            MsgBox("Debe seleccionar un cliente primero", vbOKOnly, "Error!")
            Return
        End If

        If TabPAListBoxSC.SelectedIndex = -1 Then
            Return
        End If

        Dim SC As SubCuenta = TabPAListBoxSC.SelectedItem

        If Not IsNothing(SC) Then
            Dim frmModificar As New frmSubCuentaMod(SC)
            frmModificar.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not IsNothing(_Cliente) Then
            Dim SubNueva As frmSubCuentaNueva = New frmSubCuentaNueva(_Cliente)
            SubNueva.ShowDialog()
            If SubNueva.DialogResult = Windows.Forms.DialogResult.OK Then
                _Cliente.SubCuentas = GCliente.Instance().getSubCuentasByCliente(_Cliente.IdCliente)
                TabPAListBoxSC.DataSource = _Cliente.SubCuentas
            End If
        Else
            MsgBox("Debe cargar un cliente primero", vbOKOnly, "Verificar!")
            Return
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNothing(_Cliente) Then
            MsgBox("Debe cargar un cliente primero", vbOKOnly, "Error!")
            Return
        End If
        If TabPAListBoxSC.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar una Sub Cuenta", vbOKOnly, "Error")
            Return
        End If
        Dim SC As SubCuenta = TryCast(TabPAListBoxSC.SelectedItem, SubCuenta)
        Dim PANueva As New frmAsociadoNuevo(_Cliente)
        PANueva.ShowDialog()
        If PANueva.DialogResult = Windows.Forms.DialogResult.OK Then
            _Cliente = GCliente.Instance().getByID(_Cliente.IdCliente, False)
            TabPAListBoxSC.DataSource = _Cliente.SubCuentas
        End If
    End Sub

  

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim xmod As New frmAsociadosModificar(_Cliente, tabPAlistboxPA.SelectedItem, TryCast(TabPAListBoxSC.SelectedItem, SubCuenta).Codigo)
        xmod.ShowDialog()

    End Sub

    Private Sub ChkDic_CheckedChanged(sender As Object, e As EventArgs) Handles ChkDic.CheckedChanged

    End Sub

    Private Sub chk_activo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_activo.CheckedChanged

    End Sub

    Private Sub chkCerrada_CheckedChanged(sender As Object, e As EventArgs) Handles chkCerrada.CheckedChanged

    End Sub

    Private Sub TabPersonasA_Click(sender As Object, e As EventArgs) Handles TabPersonasA.Click

    End Sub

    Private Sub chk_dia_CheckedChanged(sender As Object, e As EventArgs) Handles chk_dia.CheckedChanged

    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub
End Class