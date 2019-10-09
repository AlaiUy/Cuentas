Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmCambioMoneda
    Private _ClienteOrigen As ClienteActivo = Nothing
    Private _ClienteDestino As ClienteActivo = Nothing
    Private _Movimientos As List(Of MovimientoGeneral) = Nothing
    Private _Movimiento As MovimientoGeneral = Nothing

    Private Sub PopularForm()
        cbMonedaOrigen.DataSource = GCobros.getInstance().getMonedas()
        cbMonedaDestino.DataSource = GCobros.getInstance().getMonedas()
    End Sub

    Private Sub PopuparGrilla(ByVal xMoneda As Integer)

        Dim T As New DataTable("Movimientos")
        Dim ColFecha As DataColumn = New DataColumn("FECHA", Type.GetType("System.String"))
        Dim ColImporte As DataColumn = New DataColumn("IMPORTE", Type.GetType("System.String"))
        Dim ColFechaVecimiento As DataColumn = New DataColumn("FECHA VENCIMIENTO", Type.GetType("System.String"))
        Dim ColSerie As DataColumn = New DataColumn("SERIE", Type.GetType("System.String"))
        Dim ColLugar As DataColumn = New DataColumn("VENTA", Type.GetType("System.String"))
        Dim ColNumero As DataColumn = New DataColumn("NUMERO", Type.GetType("System.String"))
        Dim ColSel As DataColumn = New DataColumn("SELECCIONADA", Type.GetType("System.String"))
        Dim ColPos As DataColumn = New DataColumn("POSICION", Type.GetType("System.String"))

        T.Columns.Add(ColFecha)
        T.Columns.Add(ColFechaVecimiento)
        T.Columns.Add(ColSerie)
        T.Columns.Add(ColLugar)
        T.Columns.Add(ColNumero)
        T.Columns.Add(ColImporte)
        T.Columns.Add(ColSel)
        T.Columns.Add(ColPos)

        Dim Mov As New List(Of MovimientoGeneral)
        Mov = MostrarMovimientos(xMoneda)
        For Each M As MovimientoGeneral In Mov
            Dim Row As DataRow = T.NewRow()
            Row.Item("FECHA") = M.Fecha.ToString("dd/MM/yyyy")
            Row.Item("Fecha Vencimiento") = M.FechaVencimiento().ToString("dd/MM/yyyy")
            Row.Item("IMPORTE") = FormatearImporte(M.Importe)
            Row.Item("SERIE") = M.Serie
            Row.Item("VENTA") = M.Descripcion
            Row.Item("NUMERO") = M.Numero
            Row.Item("SELECCIONADA") = 0
            Row.Item("POSICION") = M.Posicion
            T.Rows.Add(Row)
        Next
        dgMovimientos.DataSource = T
    End Sub

    Private Function MostrarMovimientos(ByVal xMoneda As Integer) As List(Of MovimientoGeneral)
        If IsNothing(_Movimientos) Then
            Return Nothing
        End If
        Return _Movimientos.FindAll(Function(M As MovimientoGeneral) M.Moneda.Codmoneda = xMoneda And M.Importe < 0)
    End Function


    Private Sub PopularDatos()
        If IsNothing(_ClienteOrigen) Then
            Return
        End If
        _Movimientos = GCliente.Instance().MovimientosPendientes(_ClienteOrigen.IdCliente, True)

        txtClienteOrigen.Enabled = False
        txtNombreOrigen.Text = _ClienteOrigen.Nombre
        txtClienteOrigen.Text = _ClienteOrigen.IdCliente

        If Not IsNothing(_Movimientos) Then
            If Not IsNothing(cbMonedaOrigen.SelectedItem) Then
                PopuparGrilla(TryCast(cbMonedaOrigen.SelectedItem, Moneda).Codmoneda)
            End If

        End If
    End Sub





    Private Sub frmCambioMoneda_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub frmCambioMoneda_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Function getMovimientoFromPendientes(ByVal xSerie As String, ByVal xNumero As Integer, ByVal xPosicion As Integer) As MovimientoGeneral
        Return _Movimientos.Find(Function(M As MovimientoGeneral) M.Serie = xSerie And M.Numero = xNumero And M.Posicion = xPosicion)
    End Function

    Private Sub frmCambioMoneda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopularForm()
    End Sub

    Private Sub cbMonedas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonedaOrigen.SelectedIndexChanged
        If Not IsNothing(_Movimientos) Then
            PopuparGrilla(TryCast(cbMonedaOrigen.SelectedItem, Moneda).Codmoneda)
        End If
    End Sub

    Private Sub dgMovimientos_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles dgMovimientos.CellClick

        Dim Serie As String = dgMovimientos.Item(dgMovimientos.Columns("Serie").Index, dgMovimientos.CurrentRow.Index).Value
        Dim Numero As String = dgMovimientos.Item(dgMovimientos.Columns("Numero").Index, dgMovimientos.CurrentRow.Index).Value
        Dim Pos As String = dgMovimientos.Item(dgMovimientos.Columns("Posicion").Index, dgMovimientos.CurrentRow.Index).Value
        _Movimiento = getMovimientoFromPendientes(Serie, Numero, Pos)

        If Not IsNothing(_Movimiento) Then
            PopularCambio()
        End If
    End Sub

    Private Sub PopularCambio()
        Dim MonedaOrigen As Moneda = cbMonedaOrigen.SelectedItem
        Dim MonedaDestino As Moneda = cbMonedaDestino.SelectedItem
        Dim Cotizacion As Decimal = GCobros.getInstance().Caja.Cotizacion()
        txtImporteOrigen.Text = Math.Abs(_Movimiento.Importe)

        If MonedaOrigen.Codmoneda = MonedaDestino.Codmoneda Then
            txtImporteDestino.Text = Math.Abs(_Movimiento.Importe)
        ElseIf MonedaOrigen.Codmoneda = 1 Then
            txtImporteDestino.Text = Math.Abs(_Movimiento.Importe) / Cotizacion
        Else
            txtImporteDestino.Text = Math.Abs(_Movimiento.Importe) * Cotizacion
        End If
    End Sub

    Private Sub txtClienteDestino_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteDestino.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If IsNumeric(txtClienteOrigen.Text) Or Not String.IsNullOrEmpty(txtClienteOrigen.Text) Then
                Try
                    _ClienteDestino = GCliente.Instance().getByID(txtClienteDestino.Text, False)
                    PopularClienteDestino()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub PopularClienteDestino()
        If Not IsNothing(_ClienteDestino) Then
            txtNombreDestino.Text = _ClienteDestino.Nombre
            txtClienteDestino.Text = _ClienteDestino.IdCliente
        End If

    End Sub






    Private Sub btnDoIt_Click(sender As Object, e As EventArgs) Handles btnDoIt.Click



        If IsNothing(_ClienteOrigen) Then
            MsgBox("Debe ingresar un cliente Origen")
            Return
        End If

        If IsNothing(_ClienteDestino) Then
            MsgBox("Debe ingresar un cliente Origen")
            Return
        End If

        If cbMonedaDestino.Items.Count < 1 Then
            MsgBox("Debe seleccionar una moneda destino para hacer la conversion")
            Return
        End If

        Dim Mon As Moneda = cbMonedaDestino.SelectedItem
        Dim Serie As String = dgMovimientos.Item(dgMovimientos.Columns("Serie").Index, dgMovimientos.CurrentRow.Index).Value
        Dim Numero As String = dgMovimientos.Item(dgMovimientos.Columns("Numero").Index, dgMovimientos.CurrentRow.Index).Value
        Dim Pos As String = dgMovimientos.Item(dgMovimientos.Columns("Posicion").Index, dgMovimientos.CurrentRow.Index).Value

        Dim Mov As MovimientoGeneral = Nothing
        Mov = getMovimientoFromPendientes(Serie, Numero, Pos)

        If IsNothing(Mov) Then
            MsgBox("No se puede convertir ese movimiento")
            Return
        End If

        Try
            btnDoIt.Enabled = False
            GCobros.getInstance().ConversionMoneda(_ClienteOrigen, Mov, _ClienteDestino, Mon)
            MsgBox("Exito")
            ResetearForm()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            btnDoIt.Enabled = True
        End Try
    End Sub

    Private Sub ResetearForm()
        txtClienteOrigen.Enabled = True
        txtClienteOrigen.Text = ""
        txtNombreOrigen.Text = ""
        txtClienteDestino.Enabled = True
        txtClienteDestino.Text = ""
        txtNombreDestino.Text = ""
        btnDoIt.Enabled = True
    End Sub

    Private Sub cbMonedaDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonedaDestino.SelectedIndexChanged
        If Not IsNothing(_Movimiento) Then
            PopularCambio()
        End If
    End Sub

    Private Sub btnBuscarClienteOrigen_Click(sender As Object, e As EventArgs) Handles btnBuscarClienteOrigen.Click
        Dim frmFiltro As New frmGrillaClientes
        frmFiltro.ShowDialog()
        If (frmFiltro.DialogResult = Windows.Forms.DialogResult.OK) Then
            _ClienteOrigen = frmFiltro.Cliente


            frmFiltro.Close()

        End If
        PopularDatos()
    End Sub

    Private Sub txtClienteOrigen_KeyDown(sender As Object, e As KeyEventArgs) Handles txtClienteOrigen.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If IsNumeric(txtClienteOrigen.Text) Or Not String.IsNullOrEmpty(txtClienteOrigen.Text) Then
                Try
                    _ClienteOrigen = GCliente.Instance().getByID(txtClienteOrigen.Text, False)
                    PopularDatos()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub btnBuscarClienteDestino_Click(sender As Object, e As EventArgs) Handles btnBuscarClienteDestino.Click
        Dim frmFiltro As New frmGrillaClientes
        frmFiltro.ShowDialog()
        If (frmFiltro.DialogResult = Windows.Forms.DialogResult.OK) Then
            _ClienteDestino = frmFiltro.Cliente
            PopularClienteDestino()

            frmFiltro.Close()

        End If
    End Sub

    Private Sub txtClienteDestino_TextChanged(sender As Object, e As EventArgs) Handles txtClienteDestino.TextChanged

    End Sub
End Class