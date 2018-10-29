Imports System.Globalization
Imports System.Net.Mail
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes
Imports Aguiñagalde.Tools
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmEC

    Private Cliente As ClienteActivo = Nothing
    Private ECActivo As EstadoCuenta = Nothing
    Private Saldos As CalcularSaldos = Nothing
    Private Sub frmEC_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Cliente = GCliente.Instance().getByID(txtCliente.Text, True)
            Catch ex As Exception
                MsgBox(ex.Message, vbOK, "Error")
            End Try

            If Not IsNothing(Cliente) Then
                lblNombre.Text = Cliente.Nombre
                lblDireccion.Text = Cliente.Direccion
                txtDate.Focus()
            End If

        End If
    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtDate_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub frmEC_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub ConfigurarGrilla()

        With DGMovimientos
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.None
            .Columns("TOTAL").DefaultCellStyle.BackColor = Color.LightBlue
            .Columns("TOTAL").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Debe").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Haber").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Dim x As Decimal = .Columns("Debe").Width
            .Columns("Movimiento").Width = 109
            .Columns("Fecha").Width = 65
            .Columns("TOTAL").Width = 135
            .Columns("Serie").Width = 71
            .Columns("Numero").Width = 85
            .Columns("Debe").Width = 72
            .Columns("Haber").Width = 72

            .Columns("Estado").Visible = False
        End With

    End Sub

    Private Sub txtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            LimpiarDatos()
            Try
                Cliente = GCliente.Instance().getByID(txtCliente.Text, True)
                If Not IsNothing(Cliente) Then
                    Dim D As Date = Convert.ToDateTime(txtDate.Text)
                    ECActivo = GCliente.Instance.GenerarEstadoCuenta(D, Cliente, 0)
                    DGMovimientos.DataSource = ECActivo.getInforme(1)
                    ConfigurarGrilla()
                    PopularSaldos()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LimpiarDatos()
        lbl_D30.Text = ""
        lbl_D60.Text = ""
        lbl_D90.Text = ""
        lbl_P30.Text = ""
        lbl_P60.Text = ""
        lbl_P90.Text = ""
        DGMovimientos.DataSource = Nothing
        DGMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DGMovimientos.Refresh()
    End Sub

    Private Sub PopularSaldos()
        Saldos = New CalcularSaldos(ECActivo.Pendientes())
        Try
            lbl_P30.Text = FormatearImporte(Saldos.z30(1))
            lbl_P60.Text = FormatearImporte(Saldos.z60(1))
            lbl_P90.Text = FormatearImporte(Saldos.z90(1))


            lbl_D30.Text = FormatearImporte(Saldos.z30(2))
            lbl_D60.Text = FormatearImporte(Saldos.z60(2))
            lbl_D90.Text = FormatearImporte(Saldos.z90(2))

        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

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

    Private Sub txtDate_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        If IsNothing(ECActivo) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return
        Else
            Try
                TryCast(sender, Button).Enabled = False
                Application.DoEvents()
                Dim Imp As New Impresion()
                Imp.Imprimir(ECActivo, True, Nothing)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                TryCast(sender, Button).Enabled = True
            End Try
        End If
    End Sub

    Private Sub btn_GenPDF_Click(sender As Object, e As EventArgs) Handles btn_GenPDF.Click
        If IsNothing(ECActivo) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return
        Else
            TryCast(sender, Button).Enabled = False
            Application.DoEvents()
            Dim PDF As New PDF()
            Dim rptDoc As ReportDocument
            rptDoc = New repEstadoCuenta
            CargarCamposReporte(rptDoc, Cliente, ECActivo)
            rptDoc.SetDataSource(ECActivo.Impresion())
            Try
                PDF.ExportToPdfReport(rptDoc, "EC" & Cliente.IdCliente, True)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                TryCast(sender, Button).Enabled = True
            End Try
        End If
    End Sub

    Private Sub CargarCamposReporte(ByRef xReport As ReportDocument, ByVal xCliente As ClienteActivo, ByVal xEstadoCuenta As EstadoCuenta)
        Dim CampoMod As TextObject


        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repLCredito")
        If xCliente.Lineacredito < 1 Then
            CampoMod.Text = 0
        Else
            CampoMod.Text = Format(xCliente.Lineacredito, "##,##.00")
        End If


        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repCta")
        CampoMod.Text = xEstadoCuenta.Cliente.IdCliente

        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repVencidoPesos")
        If xEstadoCuenta.VencidoPesos < 0 Then
            CampoMod.Text = 0.00
        Else
            CampoMod.Text = Format(xEstadoCuenta.VencidoPesos, "##,##.00")
        End If


        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repVencidoDolares")
        If xEstadoCuenta.VencidoDolares < 0 Then
            CampoMod.Text = 0.00
        Else
            CampoMod.Text = Format(xEstadoCuenta.VencidoDolares, "##,##.00")
        End If




        CampoMod = xReport.ReportDefinition.ReportObjects.Item("nomcliente")
        CampoMod.Text = xCliente.Nombre

        CampoMod = xReport.ReportDefinition.ReportObjects.Item("direccion")
        CampoMod.Text = xCliente.Direccion

        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repDisponible")
        Dim Disponible As Decimal = 0
        Disponible = (xCliente.Lineacredito - (xEstadoCuenta.Pendiente(1) + (xEstadoCuenta.Pendiente(2) * xEstadoCuenta.Cotizacion)))
        If (Disponible < 0) Then
            CampoMod.Text = 0
        Else
            CampoMod.Text = Disponible
        End If




        'CampoMod = xReport.ReportDefinition.ReportObjects.Item("repVencidoPesos")
        'If xEstadoCuenta.VencidoPesos < 1 Then
        '    CampoMod.Text = 0
        'Else
        '    CampoMod.Text = Format(xEstadoCuenta.VencidoPesos, "##,##.00")

        'End If


        'CampoMod = xReport.ReportDefinition.ReportObjects.Item("repVencidoDolares")
        'If xEstadoCuenta.VencidoDolares < 1 Then
        '    CampoMod.Text = 0
        'Else
        '    CampoMod.Text = Format(xEstadoCuenta.VencidoDolares, "##,##.00")
        'End If



        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repDescuentoPesos")
        If xEstadoCuenta.DescuentoPesos < 1 Then
            CampoMod.Text = 0
        Else
            CampoMod.Text = Format(xEstadoCuenta.DescuentoPesos, "##,##.00")
        End If

        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repSaldoPesos")

        CampoMod.Text = Format(xEstadoCuenta.Pendiente(1) + xEstadoCuenta.getMora(1), "##,##.00")


        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repSaldoDolares")
        CampoMod.Text = Format(xEstadoCuenta.Pendiente(2) + xEstadoCuenta.getMora(2), "##,##.00")




        CampoMod = xReport.ReportDefinition.ReportObjects.Item("repDescuentoDolares")
        If xEstadoCuenta.DescuentoDolares < 1 Then
            CampoMod.Text = 0
        Else
            CampoMod.Text = Format(xEstadoCuenta.DescuentoDolares, "##,##.00")
        End If

        CampoMod = xReport.ReportDefinition.ReportObjects.Item("txtTotalD")
        CampoMod.Text = Format(xEstadoCuenta.Pendiente(2) + xEstadoCuenta.getMora(2), "##,##.00")

        CampoMod = xReport.ReportDefinition.ReportObjects.Item("txtTotalP")
        CampoMod.Text = Format(xEstadoCuenta.Pendiente(1) + xEstadoCuenta.getMora(1), "##,##.00")
    End Sub

    Private Sub btnEnvioMail_Click(sender As Object, e As EventArgs) Handles btnEnvioMail.Click
        If IsNothing(ECActivo) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return
        Else
            Try
                TryCast(sender, Button).Enabled = False
                Application.DoEvents()
                Dim PDF As New PDF()
                Dim FileNombre As String = "EC" & Cliente.IdCliente
                Dim rptDoc As ReportDocument
                Dim Path As String = "C:/EstadosCuentaPDF/"
                Dim Ex As String = ".pdf"
                rptDoc = New repEstadoCuenta
                CargarCamposReporte(rptDoc, Cliente, ECActivo)
                rptDoc.SetDataSource(ECActivo.Impresion())
                PDF.ExportToPdfReport(rptDoc, FileNombre, False)

                Dim Adjunto = New Attachment(Path & FileNombre & Ex)
                Adjunto.Name = "EstadoCuenta.pdf"
                Dim femail = New frmEnvioEmail(Cliente, Adjunto)
                femail.ShowDialog()
                If femail.DialogResult = DialogResult.Cancel Then
                    Adjunto.Dispose()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Error!")
            Finally
                TryCast(sender, Button).Enabled = False
            End Try
        End If
    End Sub

    Private Sub btnMostrarDolares_Click(sender As Object, e As EventArgs) Handles btnMostrarDolares.Click
        If Not IsNothing(ECActivo) Then
            DGMovimientos.DataSource = Nothing
            DGMovimientos.Refresh()
            DGMovimientos.DataSource = ECActivo.getInforme(2)
            ConfigurarGrilla()
        End If
    End Sub

    Private Sub btnMostrarPesos_Click(sender As Object, e As EventArgs) Handles btnMostrarPesos.Click
        If Not IsNothing(ECActivo) Then
            DGMovimientos.DataSource = Nothing
            DGMovimientos.Refresh()
            DGMovimientos.DataSource = ECActivo.getInforme(1)
            ConfigurarGrilla()
        End If
    End Sub
End Class

