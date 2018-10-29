Imports System.Collections.Generic
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Reflection
Imports System.Threading
Imports Aguiñagalde.Tools
Imports System.Windows.Forms
Imports Aguiñagalde

Public Class frmClienteNuevo

    Private _ProcesoFondo As Thread

    Private _Cliente As ClienteActivo = Nothing


    Private Sub frmClienteNuevo_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LinkLabel1.LinkColor = Drawing.Color.Red

        _ProcesoFondo = New Thread(AddressOf Me.CargarDatos)
        _ProcesoFondo.Start()
        If Not IsNothing(_Cliente) Then
            CargarCampos()
        End If
    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged
        If (Len(sender.text) = 8) Then
            If (Aguiñagalde.Tools.Numeros.Cedula(Val(sender.text))) Then
                LinkLabel1.LinkColor = Drawing.Color.Blue
            End If
        End If
    End Sub



    Private Sub CargarDatos()
        CBFpagos.DataSource = GCobros.getInstance().getFormasPago()
        CBTarifasVenta.DataSource = GCobros.getInstance().getTarifasVenta()
        CBMonedas.DataSource = GCobros.getInstance().getMonedas()
        CBType.SelectedIndex = 0
        Dim Index As Integer = 0
        Index = BuscarCombo(CBFpagos, "CREDITO MES + 30 DIAS")
        CBFpagos.SelectedIndex = Index
        Index = BuscarCombo(CBTarifasVenta, "CREDITO")
        CBTarifasVenta.SelectedIndex = Index
        txtcierre.Text = 25

    End Sub

    Public Function BuscarCombo(ByVal Combo As ComboBox, ByVal xTexto As String)
        For Index As Integer = 0 To Combo.Items.Count - 1
            If xTexto = Combo.Items(Index).ToString() Then
                Return Index
            End If
        Next
        Return -1
    End Function

    'CREDITO MES + 30 DIAS

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        If (Len(txtCuenta.Text) = 5 And IsNumeric(txtCuenta.Text)) Or Tools.Numeros.Cedula(Val(txtCuenta.Text)) Then
            Dim objCliente = New ClienteActivo(txtCuenta.Text, txtnombre.Text, txtCedula.Text)
            objCliente.Apertura = Today
            objCliente.Descatalogado = False
            objCliente.Rut = txtrut.Text
            objCliente.Direccion = txtDireccion.Text
            objCliente.DireccionAlternativa = txtdireccionalternativa.Text
            objCliente.Cedula = txtCedula.Text
            objCliente.CamposLibres.Email = txtEmail.Text
            objCliente.Telefono = txtTelefono.Text
            objCliente.Celular = txtCelular.Text
            objCliente.Fecha = dtpnacimiento.Value
            objCliente.Pais = txtPais.Text
            objCliente.Dpto = txtDpto.Text
            objCliente.Postal = txtpostal.Text
            objCliente.Cobrador = txtcobrador.Text
            objCliente.FormaPago = DirectCast(CBFpagos.SelectedItem, FPago)
            objCliente.Type = Convert.ToInt32(CBType.SelectedItem.ToString())
            objCliente.Tope = Val(txtriesgo.Text)
            objCliente.Lineacredito = Val(txtlinea.Text)
            objCliente.Cierre = Val(txtcierre.Text)
            objCliente.Tarifa = DirectCast(CBTarifasVenta.SelectedItem, Tarifa)
            objCliente.NombreComercial = txtnombre.Text
            objCliente.Fax = txtfax.Text
            objCliente.Moneda = DirectCast(CBMonedas.SelectedItem, Moneda)
            objCliente.CamposLibres.ConyugeActividad = txtactconyuge.Text
            objCliente.CamposLibres.ConyugeIngresos = Val(txtingconyuge.Text)
            objCliente.CamposLibres.ConyugeCargo = txtcargoconyuge.Text
            objCliente.CamposLibres.ConyugeAntiguedad = txtantigconyuge.Text
            objCliente.CamposLibres.Actividad = txtactvidad.Text
            objCliente.CamposLibres.Ingresos = Val(txtingreso.Text)
            objCliente.CamposLibres.Cargo = txtcargo.Text
            objCliente.CamposLibres.Antiguedad = txtantiguedad.Text
            objCliente.CamposLibres.Civil = txtcivil.Text
            objCliente.CamposLibres.Alquiler = txtalquiler.Text
            objCliente.CamposLibres.Vehiculos = txtvehiculos.Text
            objCliente.CamposLibres.Plasticos = txtplasticos.Text
            objCliente.CamposLibres.Comerciales = txtcomerciales.Text
            objCliente.Observaciones = txtobs.Text
            objCliente.CamposLibres.OtrasObservaciones = txtobs1.Text
            objCliente.CamposLibres.Conyuge = txtcDocumento.Text
            objCliente.Ruta = txtRuta.Text
            objCliente.isActivo = True
            objCliente.isActivoDia = chk_dia.Checked
            objCliente.IsBloqueo = chkBloqueo.Checked
            objCliente.isFidelizado = chk_fidelizado.Checked
            objCliente.isMonedaUnica = chk_moneda.Checked
            objCliente.isOrden = chk_orden.Checked
            objCliente.SoloTitular = chkSolotit.Checked
            objCliente.CamposLibres.Bienes = txtbienes.Text
            Try
                GCliente.Instance.addCliente(objCliente)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try
            MsgBox("Cliente creado con exito", vbOKOnly, "Exito!")
            Return
        End If
    End Sub

    Private Sub CargarCampos()
        txtrut.Text = _Cliente.Rut
        txtactvidad.Text = _Cliente.CamposLibres.Actividad
        txtCuenta.Text = _Cliente.IdCliente
        txtnombre.Text = _Cliente.Nombre
        txtEmail.Text = _Cliente.Email
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
        ''txttype.Text = _Cliente.Type
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
        txtEmail.Text = _Cliente.Email
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        If (Len(txtCuenta.Text) = 5 And IsNumeric(txtCuenta.Text)) Or Tools.Numeros.Cedula(Val(txtCuenta.Text)) Then
            Dim objCliente = New ClienteActivo(txtCuenta.Text, txtnombre.Text, txtCedula.Text)
            objCliente.Apertura = Today
            objCliente.Descatalogado = False
            objCliente.Rut = txtrut.Text
            objCliente.Direccion = txtDireccion.Text
            objCliente.DireccionAlternativa = txtdireccionalternativa.Text
            objCliente.Cedula = txtCedula.Text
            objCliente.CamposLibres.Email = txtEmail.Text
            objCliente.Telefono = txtTelefono.Text
            objCliente.Celular = txtCelular.Text
            objCliente.Fecha = dtpnacimiento.Value
            objCliente.Pais = txtPais.Text
            objCliente.Dpto = txtDpto.Text
            objCliente.Postal = txtpostal.Text
            objCliente.Cobrador = txtcobrador.Text
            objCliente.FormaPago = DirectCast(CBFpagos.SelectedItem, FPago)
            objCliente.Type = Convert.ToInt32(CBType.SelectedItem.ToString())
            objCliente.Tope = Val(txtriesgo.Text)
            objCliente.Lineacredito = Val(txtlinea.Text)
            objCliente.Cierre = Val(txtcierre.Text)
            objCliente.Tarifa = DirectCast(CBTarifasVenta.SelectedItem, Tarifa)
            objCliente.NombreComercial = Today
            objCliente.Fax = txtfax.Text
            objCliente.Moneda = DirectCast(CBMonedas.SelectedItem, Moneda)
            objCliente.CamposLibres.ConyugeActividad = txtactconyuge.Text
            objCliente.CamposLibres.ConyugeIngresos = Val(txtingconyuge.Text)
            objCliente.CamposLibres.ConyugeCargo = txtcargoconyuge.Text
            objCliente.CamposLibres.ConyugeAntiguedad = txtantigconyuge.Text
            objCliente.CamposLibres.Actividad = txtactvidad.Text
            objCliente.CamposLibres.Ingresos = Val(txtingreso.Text)
            objCliente.CamposLibres.Cargo = txtcargo.Text
            objCliente.CamposLibres.Antiguedad = txtantiguedad.Text
            objCliente.CamposLibres.Civil = txtcivil.Text
            objCliente.CamposLibres.Alquiler = txtalquiler.Text
            objCliente.CamposLibres.Vehiculos = txtvehiculos.Text
            objCliente.CamposLibres.Plasticos = txtplasticos.Text
            objCliente.CamposLibres.Comerciales = txtcomerciales.Text
            objCliente.Observaciones = txtobs.Text
            objCliente.CamposLibres.OtrasObservaciones = txtobs1.Text
            objCliente.CamposLibres.Conyuge = txtcDocumento.Text
            objCliente.Ruta = txtRuta.Text
            objCliente.isActivo = True
            objCliente.isActivoDia = chk_dia.Checked
            objCliente.IsBloqueo = chkBloqueo.Checked
            objCliente.isFidelizado = chk_fidelizado.Checked
            objCliente.isMonedaUnica = chk_moneda.Checked
            objCliente.isOrden = chk_orden.Checked
            objCliente.SoloTitular = chkSolotit.Checked
            objCliente.CamposLibres.Bienes = txtbienes.Text
            Try
                GCliente.Instance.addCliente(objCliente)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return
            End Try
            MsgBox("Cliente creado con exito", vbOKOnly, "Exito!")
            Return
        End If
    End Sub
End Class