Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.Windows.Forms
Imports Aguiñagalde.Tools
Imports System.Net.Mail
Imports System.Drawing
Imports System.Globalization
Imports System.IO

Public Class frmEstadoCuenta

    Private _EstadoCuenta As EstadoCuenta
    Private _Cliente As ClienteActivo
    Private _FechaInicio As Date
    Private _fechaFinal As Date


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        FechaDesde.Text = DateTime.Parse(Today.AddMonths(-2).ToShortDateString()).ToString("dd/MM/yyyy")
        FechaHasta.Text = DateTime.Parse(Today.ToShortDateString()).ToString("dd/MM/yyyy")
    End Sub

    Public Sub New(ByVal xCliente As ClienteActivo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _Cliente = xCliente
        _FechaInicio = New Date(DateTime.Now.Year, DateTime.Now.Month - 2, DateTime.Now.Day)
        _fechaFinal = DateTime.Now
        CargarDatos()
        _EstadoCuenta = GCliente.Instance.GenerarEstadoCuenta(_FechaInicio, _Cliente, 1)
        DGMovimientos.DataSource = _EstadoCuenta.getInforme(1)
        OrdernarGridMoneda()
        lbltotalparcial.Text = "Total ($)"
        txtTotalParcial.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1) + _EstadoCuenta.getMora(1))
        txtTotalDolares.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(2) + _EstadoCuenta.getMora(2))
        txtTotalPesos.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1) + _EstadoCuenta.getMora(1))

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

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



    Private Sub frmEstadoCuenta_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub CargarDatos()
        If Not IsNothing(_Cliente) Then
            txtNombre.Text = _Cliente.Nombre
            txtDireccion.Text = _Cliente.Direccion
            If (_Cliente.SubCuentas.Count > 0) Then
                'cbSub.Items.Clear()
                'For Each S As SubCuenta In _Cliente.SubCuentas
                '    cbSub.Items.Add(S)
                '    cbSub.SelectedIndex = 0
                'Next
            End If
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If Len(txtCuenta.Text) < 1 Then
            MsgBox("El documento no puede ser vacio", vbOKOnly, "Error!")
            Return
        End If

        If Not Tools.Numeros.IsNumeric(txtCuenta.Text) Then
            MsgBox("El documento debe contener solo numeros", vbOKOnly, "Error!")
            Return
        End If

        Dim FD As DateTime = getFecha(FechaDesde.Text)
        Dim FH As DateTime = getFecha(FechaHasta.Text)



        If FD > FH.AddMinutes(1) Then
            MsgBox("Las fechas ingresadas no son validas", vbOKOnly, "Error - Fecha Inicio mayor a final")
            Return
        End If

        If _FechaInicio = FD And _fechaFinal = FH Then
            Return
        End If


        _FechaInicio = FD
        _fechaFinal = FH

        Try
            Me.btnGenerar.Enabled = False
            Application.DoEvents()
            If IsNothing(_Cliente) Then
                _Cliente = GCliente.Instance.getByID(Convert.ToInt32(txtCuenta.Text), False)
            End If

            CargarDatos()
            Me.btnGenerar.Enabled = True
            _EstadoCuenta = GCliente.Instance.GenerarEstadoCuenta(_FechaInicio, _Cliente, 0)
            DGMovimientos.DataSource = _EstadoCuenta.getInforme(1)
            OrdernarGridMoneda()
            lbltotalparcial.Text = "Total ($)"
            txtTotalParcial.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1) + _EstadoCuenta.getMora(1))
            txtTotalDolares.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(2))
            txtTotalPesos.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1))
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error!")

        End Try


        'PintarPendientes()


    End Sub





    Private Sub PintarPendientes()
        For Each R As DataGridViewRow In DGMovimientos.Rows
            If Not IsDBNull(R.Cells("Estado").Value) Then
                If R.Cells("Estado").Value = "P" Then
                    R.DefaultCellStyle.BackColor = Drawing.Color.Chocolate
                End If
            End If
        Next
    End Sub
    Private Sub LinkReporte_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkReporte.LinkClicked
        If IsNothing(_EstadoCuenta) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return
        Else
            Try
                Me.LinkReporte.Enabled = False
                Application.DoEvents()
                Dim Imp As New Impresion()
                Imp.Imprimir(_EstadoCuenta, True, Nothing)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Me.LinkReporte.Enabled = True
            End Try
        End If
    End Sub

    Private Sub OrdernarGridMoneda()

        Dim Estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
        Estilo.Font = New Font("Thaoma", 8, FontStyle.Underline)
        Estilo.ForeColor = Color.Blue
        Estilo.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim Izq As DataGridViewCellStyle = New DataGridViewCellStyle()
        Izq.Font = New Font("Thaoma", 8)
        Izq.Alignment = DataGridViewContentAlignment.MiddleLeft

        Dim Der As DataGridViewCellStyle = New DataGridViewCellStyle()
        Der.Font = New Font("Thaoma", 8)
        Der.Alignment = DataGridViewContentAlignment.MiddleRight



        With DGMovimientos
            '.Columns("DOCUMENTO").Visible = False
            .Columns("FECHA").DisplayIndex = 0
            .Columns("MOVIMIENTO").DisplayIndex = 1
            .Columns("SERIE").DisplayIndex = 2
            .Columns("NUMERO").DisplayIndex = 3
            .Columns("DEBE").DisplayIndex = 4
            .Columns("HABER").DisplayIndex = 5
            .Columns("TOTAL").DisplayIndex = 6
            .Columns("Estado").Visible = False

            'izq
            .Columns("FECHA").DefaultCellStyle = Izq
            .Columns("MOVIMIENTO").DefaultCellStyle = Izq

            'med
            .Columns("SERIE").DefaultCellStyle = Estilo


            'der
            .Columns("NUMERO").DefaultCellStyle = Der
            .Columns("DEBE").DefaultCellStyle = Der
            .Columns("HABER").DefaultCellStyle = Der
            .Columns("TOTAL").DefaultCellStyle = Der
        End With

        For Each Row As DataGridViewRow In DGMovimientos.Rows
            If Not IsDBNull(Row.Cells("Estado").Value) Then
                If Row.Cells("Estado").Value = "P" Then
                    Row.DefaultCellStyle.BackColor = Color.LightPink
                End If
            End If

        Next

    End Sub


    Private Sub InfPesos_Click(sender As Object, e As EventArgs)



    End Sub





    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If IsNothing(_EstadoCuenta) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return
        Else
            Try
                Me.LinkLabel3.Enabled = False
                Application.DoEvents()
                Dim PDF As New PDF()
                Dim FileNombre As String = "EC" & _Cliente.IdCliente
                Dim rptDoc As ReportDocument
                Dim Path As String = "C:/EstadosCuentaPDF/"
                Dim Ex As String = ".pdf"
                rptDoc = New repEstadoCuenta
                CargarCamposReporte(rptDoc, _Cliente, _EstadoCuenta)
                rptDoc.SetDataSource(_EstadoCuenta.Impresion())
                PDF.ExportToPdfReport(rptDoc, FileNombre, False)

                Dim Adjunto = New Attachment(Path & FileNombre & Ex)
                Adjunto.Name = "EstadoCuenta.pdf"
                Dim femail = New frmEmail(_Cliente, Adjunto)
                femail.ShowDialog()
                If femail.DialogResult = DialogResult.Cancel Then
                    Adjunto.Dispose()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Error!")
            Finally
                Me.LinkLabel3.Enabled = True
            End Try
        End If
    End Sub

    Private Sub LinkToPDF_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkToPDF.LinkClicked
        If IsNothing(_EstadoCuenta) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return
        Else
            'Me.LinkToPDF.Enabled = False
            'Application.DoEvents()
            'Dim PDF As New PDF()
            'Dim rptDoc As ReportDocument
            'rptDoc = New repEstadoCuenta
            'CargarCamposReporte(rptDoc, _Cliente, _EstadoCuenta)
            'rptDoc.SetDataSource(_EstadoCuenta.Impresion())
            'Try
            '    PDF.ExportToPdfReport(rptDoc, "EC" & _Cliente.IdCliente, True)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'Finally
            '    Me.LinkToPDF.Enabled = True
            'End Try
            Try
                Dim Im = New Impresion()
                Im.Imprimir(_EstadoCuenta, False, "PDF")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGMovimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMovimientos.CellContentClick
        If (e.RowIndex = -1) Then
            Return
        End If

        If e.ColumnIndex = DGMovimientos.Columns("SERIE").Index Then
            Dim xNumero As Integer = -1
            Dim xSerie As String = ""
            xNumero = DGMovimientos.Item("Numero", e.RowIndex).Value
            xSerie = DGMovimientos.Item("Serie", e.RowIndex).Value
            Dim frmDetalle As New verDetalleBoleta(xNumero, xSerie)
            frmDetalle.ShowDialog()
        End If

    End Sub



    Private Sub DGMovimientos_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGMovimientos.CellMouseEnter
        If e.ColumnIndex = DGMovimientos.Columns("SERIE").DisplayIndex Then
            Me.Cursor = System.Windows.Forms.Cursors.Hand
        End If

        If e.ColumnIndex = DGMovimientos.Columns("TOTAL").DisplayIndex Then
            If e.RowIndex <> -1 Then
                If DGMovimientos.Rows(e.RowIndex).Cells("Estado").Value = "P" Then
                    Try
                        DGMovimientos.Rows(e.RowIndex).Cells("Estado").Tag = "45"
                    Catch ex As Exception

                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub LinkDolares_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkDolares.LinkClicked
        If Not IsNothing(_EstadoCuenta) Then


            DGMovimientos.DataSource = _EstadoCuenta.getInforme(2)
            lbltotalparcial.Text = "Total (U$S)"
            txtTotalParcial.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(2) + _EstadoCuenta.getMora(2))
            OrdernarGridMoneda()
            'PintarPendientes()
        End If

    End Sub

    Private Sub LinkPesos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPesos.LinkClicked
        If Not IsNothing(_EstadoCuenta) Then

            DGMovimientos.DataSource = _EstadoCuenta.getInforme(1)
            lbltotalparcial.Text = "Total ($)"
            txtTotalParcial.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1) + _EstadoCuenta.getMora(1))
            OrdernarGridMoneda()

        End If
    End Sub



    Private Sub DGMovimientos_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGMovimientos.CellMouseLeave
        If e.ColumnIndex = DGMovimientos.Columns("SERIE").DisplayIndex Then
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
        End If
    End Sub

    Private Sub frmEstadoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Funciones.DoubleBuffered(DGMovimientos, True)
        Dim r As CultureInfo
        r = New System.Globalization.CultureInfo("es-UY")
        System.Threading.Thread.CurrentThread.CurrentCulture = r

    End Sub

    Private Sub LinkLbPendientes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLbPendientes.LinkClicked
        If IsNothing(_EstadoCuenta) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return
        Else
            Try
                Me.LinkReporte.Enabled = False
                Application.DoEvents()
                Dim Imp As New Impresion()
                Imp.ImprimirPendientes(_EstadoCuenta, True)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Me.LinkReporte.Enabled = True
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frmFiltro As New frmGrillaClientes
        frmFiltro.ShowDialog()
        If (frmFiltro.DialogResult = Windows.Forms.DialogResult.OK) Then
            _Cliente = frmFiltro.Cliente
            frmFiltro.Close()
            txtCuenta.Text = _Cliente.IdCliente
            CargarDatos()
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuenta.KeyPress

    End Sub

    Private Sub txtCuenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                _Cliente = GCliente.Instance.getByID(txtCuenta.Text, False)
                CargarDatos()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Error!")
            End Try
        End If
    End Sub

    Private Sub Panel10_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub DateDesde_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Function getFecha(MskText As String) As DateTime
        Dim Day As Integer = -1
        Dim Month As Integer = -1
        Dim Year As Integer = -1

        MskText = MskText.Replace(" ", "0")
        If MskText.Length = 9 Then
            MskText = MskText + "0"
        End If

        Day = MskText.Substring(0, 2)
        Month = MskText.Substring(3, 2)
        Year = MskText.Substring(6, 4)
        If (Day < 1 Or Day > 31) Then
            Day = 1
        End If
        If (Month < 1 Or Month > 12) Then
            Month = 1
        End If

        If (Year < 2004) Then
            Year = 2004
        End If




        Return New DateTime(Year, Month, Day)
    End Function

    Private Sub FechaDesde_Click(sender As Object, e As EventArgs) Handles FechaDesde.Click
        TryCast(sender, MaskedTextBox).Text = ""
        TryCast(sender, MaskedTextBox).SelectionStart = 0
    End Sub

    Private Sub FechaHasta_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles FechaHasta.MaskInputRejected

    End Sub

    Private Sub FechaHasta_KeyDown(sender As Object, e As KeyEventArgs) Handles FechaHasta.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.PerformClick()
        End If
    End Sub
End Class