Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Collections.Generic
Imports System.Globalization

Public Class frmLimiteCredito
    Private _Cliente As ClienteActivo
    Private _Pendientes As List(Of MovimientoGeneral) = Nothing
    Private _Mes As Decimal
    Private _Saldos As CalcularSaldos




    Private Class CalcularSaldos
        Private _TreintaPesos, _TreintaDolares As Decimal
        Private _SesentaPesos, _SesentaDolares As Decimal
        Private _NoventaPesos, _NoventaDolares As Decimal
        Private _MoraPesos, _MoraDolares, _Importe, _DescuentoPesos, _DescuentoDolares As Decimal
        Private _Movimientos As List(Of MovimientoGeneral)
        Private _MovP, _MovD As Integer


        Public Sub New(ByVal xMovimientos As List(Of MovimientoGeneral))
            _Movimientos = xMovimientos
            getSaldos()
        End Sub

        Public ReadOnly Property z30(ByVal xCodMonedas As Integer) As Decimal
            Get
                If (xCodMonedas = 1) Then
                    Return _TreintaPesos
                Else
                    Return _TreintaDolares
                End If
            End Get
        End Property
        Public ReadOnly Property z60(ByVal xCodMonedas As Integer) As Decimal
            Get
                If (xCodMonedas = 1) Then
                    Return _SesentaPesos
                Else
                    Return _SesentaDolares
                End If
            End Get
        End Property

        Public ReadOnly Property z90(ByVal xCodMonedas As Integer) As Decimal
            Get
                If (xCodMonedas = 1) Then
                    Return _NoventaPesos
                Else
                    Return _NoventaDolares
                End If
            End Get
        End Property

        Public ReadOnly Property Descuento(ByVal xCodMonedas As Integer) As Decimal
            Get
                If (xCodMonedas = 1) Then
                    Return _DescuentoPesos
                Else
                    Return _DescuentoDolares
                End If
            End Get
        End Property

        Public ReadOnly Property Mora(ByVal xCodMonedas As Integer) As Decimal
            Get
                If (xCodMonedas = 1) Then
                    Return _MoraPesos
                Else
                    Return _MoraDolares
                End If
            End Get
        End Property






        ''_Movimientos
        Private Sub getSaldos()
            _MovP = 0
            _MovD = 0
            If Not IsNothing(_Movimientos) Then
                For Each M As MovimientoGeneral In _Movimientos
                    Dim zImporte As Decimal = M.Importe
                        Dim Dias As Long = DateDiff(DateInterval.DayOfYear, M.Fecha, Today)
                        If M.Moneda.Codmoneda = 1 Then
                            _MovP += 1
                            If Dias < 31 Then
                                _TreintaPesos += zImporte
                                _MoraPesos = M.getMora()
                                _DescuentoPesos = M.getDescuento(GCobros.getInstance.Caja.NumeroDescuento)
                            ElseIf Dias < 61 Then
                                _SesentaPesos += zImporte
                                _MoraPesos = M.getMora()
                                _DescuentoPesos = M.getDescuento(GCobros.getInstance.Caja.NumeroDescuento)
                            Else
                                _NoventaPesos += zImporte
                                _MoraPesos = M.getMora()
                                _DescuentoPesos = M.getDescuento(GCobros.getInstance.Caja.NumeroDescuento)
                            End If
                        Else
                            _MovD += 1
                            If Dias < 31 Then
                                _TreintaDolares += zImporte
                                _MoraDolares = M.getMora()
                                _DescuentoDolares = M.getDescuento(GCobros.getInstance.Caja.NumeroDescuento)
                            ElseIf Dias < 61 Then

                                _SesentaDolares += zImporte
                                _MoraDolares = M.getMora()
                                _DescuentoDolares = M.getDescuento(GCobros.getInstance.Caja.NumeroDescuento)
                            Else

                                _NoventaDolares += zImporte
                                _MoraDolares = M.getMora()
                                _DescuentoDolares = M.getDescuento(GCobros.getInstance.Caja.NumeroDescuento)
                            End If
                        End If

                Next
            End If
        End Sub

        Public Function Total(ByVal xCodMoneda As Integer, ByVal xMora As Boolean, ByVal xDescuento As Boolean)
            Dim zSuma As Decimal = 0
            If xCodMoneda = 1 Then
                zSuma = _TreintaPesos + _SesentaPesos + _NoventaPesos
                If xMora Then
                    zSuma += _MoraPesos
                End If
                If xDescuento Then
                    zSuma += _DescuentoPesos
                End If
                Return zSuma
            Else
                zSuma = _TreintaDolares + _SesentaDolares + _NoventaDolares
                If xMora Then
                    zSuma += _MoraDolares
                ElseIf xDescuento Then
                    zSuma += _DescuentoDolares
                End If
                Return zSuma
            End If
        End Function
    End Class




    Private Sub frmLimiteCredito_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If

        If PanelOpc.Visible Then
            If e.KeyCode = Windows.Forms.Keys.F10 Then
                If IsNothing(_Cliente) Then
                    MsgBox("Debe cargar un cliente primero")
                    Return
                End If
                Dim PlusOpc = New frmOpcionesAdc(_Cliente)
                PlusOpc.ShowDialog()
            End If
        End If
    End Sub

    Private Sub frmLimiteCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsNothing(_Cliente) Then
            Return
        End If
        Dim cambio As New frmTeclado()
        cambio.ShowDialog()
        If (cambio.DialogResult = Windows.Forms.DialogResult.OK) Then
            If cambio.Retorno > 0 Then
                txtLimite.Text = cambio.Retorno
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmFiltro As New frmGrillaClientes
        frmFiltro.ShowDialog()
        If (frmFiltro.DialogResult = Windows.Forms.DialogResult.OK) Then
            _Cliente = frmFiltro.Cliente
            CargarMovimientos()

            PopularDatos()

            frmFiltro.Close()

        End If
    End Sub

    Private Sub CargarMovimientos()
        Try
            _Pendientes = GCliente.Instance().getPendientesByCliente(_Cliente.IdCliente, False)
            _Saldos = New CalcularSaldos(_Pendientes)
        Catch ex As Exception
            MsgBox(ex.Message )
        End Try

    End Sub

    Private Sub PopularDatos()

        Try
            lbl30.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.z30(1))
            lbl60.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.z60(1))
            lbl90.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.z90(1))

            lbld30.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.z30(2))
            lbld60.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.z60(2))
            lbld90.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.z90(2))

            lblDescuentoD.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.Descuento(2))
            lblDescuentoP.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.Descuento(1))

            lblMoraP.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.Mora(1))
            lblMoraD.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.Mora(2))

            lblsaldo.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.Total(1, chkMora.Checked, chkDescuento.Checked))
            lbldsaldo.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _Saldos.Total(2, chkMora.Checked, chkDescuento.Checked))
        Catch ex As Exception
            MsgBox(ex)
        End Try



        txtsituacion.Text = _Cliente.Tipo()
        txtsituacion.Enabled = False
        txtsituacion.BackColor = Drawing.Color.White
        txtcuenta.Text = _Cliente.IdCliente
        txtnombre.Text = _Cliente.Nombre
        txtdireccion.Text = _Cliente.Direccion
        txtLimite.Text = _Cliente.Lineacredito
        txtTope.Text = _Cliente.Tope
        lblestado.Text = "Tipo: " & _Cliente.Type()
        lblestado.Visible = True
        'lblsaldo.Text = GCuentas.Instance().getSaldoByIDCliente(_Cliente.IdCliente)
        LinkMovimientos.Text = "Pendientes ( " & _Pendientes.Count & " )"
        LinkMovimientos.Visible = True
        txtfeccompra.Text = _Cliente.UltimaCompra
        txtfecpago.Text = _Cliente.FecUltimoPago
        txtobs.Text = _Cliente.Observaciones
        MasInfo.SetToolTip(txtnombre, "Otras Observaciones:" & vbCrLf & _Cliente.CamposLibres.OtrasObservaciones)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If IsNothing(_Cliente) Then
            MsgBox("Debe seleccionar un cliente primero", vbOKOnly, "Error!")
            Return
        End If

        If _Cliente.DIC Then
            MsgBox("El cliente esta en DIC, no se puede modificar el limite", vbOKOnly, "Verifique la ficha")
            Return
        End If
        If (_Cliente.Type <> 1) And (_Cliente.Type <> 4) And (_Cliente.Type <> 9) Then
            MsgBox("No se puede modificar el limite a este tipo cliente")
            Return
        End If


        Dim NuevoTope As Decimal
        NuevoTope = Convert.ToDecimal(txtTope.Text)
        Dim NuevaLinea As Decimal
        NuevaLinea = Convert.ToDecimal(txtLimite.Text)
        Try
            GCliente.Instance().CambiarLimites(_Cliente, NuevoTope, NuevaLinea, txtcomentario.Text)
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Verifique")
            Return
        End Try

        MsgBox("Cambios realizados", vbOKOnly, "Exito!")
        'BorrarCampos()

    End Sub

    Private Sub BorrarCampos()
        _Cliente = Nothing
        txtcuenta.Text = ""
        txtcomentario.Text = ""
        txtdireccion.Text = ""
        txtnombre.Text = ""
        txtTope.Text = ""
        txtLimite.Text = ""
        lblestado.Text = ""
        lblestado.Visible = False
        _Cliente = Nothing
        lbl30.Text = ""
        lbl60.Text = ""
        lbl90.Text = ""
        lbld30.Text = ""
        lbld60.Text = ""
        lbld90.Text = ""
        lbldsaldo.Text = ""
        lblsaldo.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cambio As New frmTeclado()
        cambio.ShowDialog()
        If (cambio.DialogResult = Windows.Forms.DialogResult.OK) Then
            If cambio.Retorno > 0 Then
                txtTope.Text = cambio.Retorno
            End If
        End If
    End Sub

    Private Sub txtcuenta_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtcuenta.KeyDown
        If (e.KeyCode = Windows.Forms.Keys.Enter And Tools.Numeros.IsNumeric(txtcuenta.Text)) Then
            Try
                _Cliente = GCliente.Instance().getByID(txtcuenta.Text, False)
                CargarMovimientos()
                PopularDatos()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    Private Sub Panel4_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub CargarSaldos(ByVal xMonedas As Integer)

    End Sub

    Private Sub txtLimite_TextChanged(sender As Object, e As EventArgs) Handles txtLimite.TextChanged

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Not IsNothing(_Cliente) Then
            Dim frm As frmModificaCliente = New frmModificaCliente(_Cliente)
            frm.ShowDialog()
            If (frm.DialogResult = Windows.Forms.DialogResult.OK) Then
                CargarMovimientos()
                PopularDatos()
            End If
        End If
    End Sub

    Private Sub LinkMovimientos_LinkClicked(sender As Object, e As Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkMovimientos.LinkClicked
        Dim frmMovimientos As New frmPendientes(_Pendientes)
        frmMovimientos.ShowDialog()


    End Sub


    Private Sub chkMora_CheckedChanged(sender As Object, e As EventArgs) Handles chkMora.CheckedChanged
        If Not IsNothing(_Pendientes) Then
            PopularDatos()
        End If


    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If Not IsNothing(_Pendientes) Then
            PopularDatos()
        End If
    End Sub

    Private Sub txtcuenta_TextChanged(sender As Object, e As EventArgs) Handles txtcuenta.TextChanged

    End Sub



    Private Sub Panel7_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles PanelOpc.Paint

    End Sub
End Class