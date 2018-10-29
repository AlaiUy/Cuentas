Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

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

    Public Function BuscarCombo(ByVal Combo As ComboBox, ByVal xTexto As String)
        For Index As Integer = 0 To Combo.Items.Count - 1
            If xTexto = Combo.Items(Index).ToString() Then
                Return Index
            End If
        Next
        Return -1
    End Function

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

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        If IsNothing(_Cliente) Then
            Return
        End If

        If _Cliente.IdCliente = Val(txtCuenta.Text) Then
            _Cliente.Nombre = txtnombre.Text
            _Cliente.NombreComercial = txtnombre.Text
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
End Class