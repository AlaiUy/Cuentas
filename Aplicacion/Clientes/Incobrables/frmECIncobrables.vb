Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes

Public Class frmECIncobrables

    Private _EstadoCuenta As EstadoCuenta
    Private _Cliente As ClienteInco
    Private _FechaInicio As Date
    Private _fechaFinal As Date
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If Len(txtCuenta.Text) < 1 Then
            MsgBox("El documento no puede ser vacio", vbOKOnly, "Error!")
            Return
        End If

        If Not Tools.Numeros.IsNumeric(txtCuenta.Text) Then
            MsgBox("El documento debe contener solo numeros", vbOKOnly, "Error!")
            Return
        End If

        If DateDesde.Value > (DateHasta.Value.AddMinutes(1)) Then
            MsgBox("Las fechas ingresadas no son validas", vbOKOnly, "Error - Fecha Inicio mayor a final")
            Return
        End If

        If _FechaInicio = DateDesde.Value.ToShortDateString And _fechaFinal = DateHasta.Value.ToShortDateString Then
            Return
        End If

        _FechaInicio = DateDesde.Value.ToShortDateString
        _fechaFinal = DateHasta.Value.ToShortDateString

        Try
            Me.btnGenerar.Enabled = False
            Application.DoEvents()
            If IsNothing(_Cliente) Then
                _Cliente = GInco.getInstance().getByID(Convert.ToInt32(txtCuenta.Text), False)
            End If

            CargarDatos()
            _EstadoCuenta = GInco.getInstance().GenerarEstadoCuenta(_FechaInicio, _fechaFinal, _Cliente, 0)
            DGMovimientos.DataSource = _EstadoCuenta.getInforme(1)
            OrdernarGridMoneda()
            lbltotalparcial.Text = "Total ($)"
            txtTotalParcial.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1) + _EstadoCuenta.getMora(1))
            txtTotalDolares.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(2))
            txtTotalPesos.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1))
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error!")
        Finally
            Me.btnGenerar.Enabled = True
        End Try
    End Sub

    Private Sub CargarDatos()
        If Not IsNothing(_Cliente) Then
            txtNombre.Text = _Cliente.Nombre
            txtDireccion.Text = _Cliente.Direccion
            'If (_Cliente.SubCuentas.Count > 0) Then
            '    'cbSub.Items.Clear()
            '    'For Each S As SubCuenta In _Cliente.SubCuentas
            '    '    cbSub.Items.Add(S)
            '    '    cbSub.SelectedIndex = 0
            '    'Next
            'End If
        End If
    End Sub

    Private Sub frmECIncobrables_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
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
            .Columns("Estado").Visible = True

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

    Private Sub LinkPesos_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkPesos.LinkClicked
        If Not IsNothing(_EstadoCuenta) Then

            DGMovimientos.DataSource = _EstadoCuenta.getInforme(1)
            lbltotalparcial.Text = "Total ($)"
            txtTotalParcial.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _EstadoCuenta.Pendiente(1) + _EstadoCuenta.getMora(1))
            OrdernarGridMoneda()

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

    Private Sub LinkReporte_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkReporte.LinkClicked
        If IsNothing(_EstadoCuenta) Then
            MsgBox("No hay nada que mostrar, genere estado primero.", vbOKOnly, "Error")
            Return

        Else

            Me.LinkReporte.Enabled = False
            Application.DoEvents()
            Dim Imp As New Impresion()
            Imp.Imprimir(_EstadoCuenta, True, Nothing)
            'Dim rptDoc As ReportDocument
            'rptDoc = New repEstadoCuenta

            'CargarCamposReporte(rptDoc, _Cliente, _EstadoCuenta)
            'rptDoc.SetDataSource(_EstadoCuenta.Impresion())
            'Dim frmReport As New frmReporte
            'frmReport.CrystalReportViewer1.ReportSource = rptDoc
            'frmReport.Show()
            Me.LinkReporte.Enabled = True

        End If
    End Sub
End Class