Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Aguiñagalde.Interfaces


Public Class frmBonificacion
    Implements IObserver
    Private _Cliente As ClienteActivo
    Private _Movimientos As List(Of MovimientoGeneral) = Nothing
    Private _Moneda As Moneda


    Private Sub frmBonificacion_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub frmBonificacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim R As System.Globalization.CultureInfo = New System.Globalization.CultureInfo("es-UY")
        R.NumberFormat.CurrencyDecimalSeparator = ","
        R.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture = R

        txtNombre.BackColor = Drawing.Color.White
        txtDireccion.BackColor = Drawing.Color.White

    End Sub



    Private Sub txtCliente_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            If txtCliente.Text.Length < 1 Then
                MsgBox("Debe ingresar un numero de cliente", vbOKOnly, "Error!")
                Return
            End If
            Try
                TryCast(sender, TextBox).Enabled = False
                _Cliente = GCliente.Instance().getByID(txtCliente.Text, False)
                CargarDatos()
                TryCast(sender, TextBox).Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly, "Error!")
            End Try
        End If
    End Sub
    Private Sub CargarDatos()

        txtNombre.Text = _Cliente.Nombre
        txtDireccion.Text = _Cliente.Direccion
        txtNombre.ForeColor = Drawing.Color.Black
        txtDireccion.ForeColor = Drawing.Color.Black
        cbMonedas.DataSource = GCobros.getInstance().getMonedas()

        cbSubCuenta.DataSource = _Cliente.SubCuentas.FindAll(Function(x) x.Descatalogado = False)
        CargarMovimientos()
        DGMovimientos.Columns("SELECCIONADA").Visible = False
        DGMovimientos.Columns("POSICION").Visible = False
    End Sub
    Private Sub CargarMovimientos()
        If Not IsNothing(_Movimientos) Then
            _Movimientos.Clear()
        End If

        _Movimientos = GCliente.Instance().MovimientosPendientes(_Cliente.IdCliente, True)
        DGMovimientos.DataSource = Nothing
        DGMovimientos.DataSource = Mostrar(DirectCast(cbMonedas.SelectedItem, Moneda).Codmoneda)
        DGMovimientos.ClearSelection()


    End Sub

    Public Function Mostrar(ByVal xMoneda As Integer) As DataTable
        Dim T As New DataTable("Movimientos")
        Dim ColFecha As DataColumn = New DataColumn("FECHA", Type.GetType("System.DateTime"))
        Dim ColImporte As DataColumn = New DataColumn("IMPORTE", Type.GetType("System.Single"))
        Dim ColFechaVecimiento As DataColumn = New DataColumn("FECHA VENCIMIENTO", Type.GetType("System.DateTime"))
        Dim ColSerie As DataColumn = New DataColumn("SERIE", Type.GetType("System.String"))
        Dim ColLugar As DataColumn = New DataColumn("VENTA", Type.GetType("System.String"))
        Dim ColNumero As DataColumn = New DataColumn("NUMERO", Type.GetType("System.Int32"))
        Dim ColSel As DataColumn = New DataColumn("SELECCIONADA", Type.GetType("System.Int32"))
        Dim ColPos As DataColumn = New DataColumn("POSICION", Type.GetType("System.Int32"))

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
            Row.Item("FECHA") = M.Fecha.ToShortDateString
            Row.Item("Fecha Vencimiento") = M.FechaVencimiento().ToShortDateString()
            Row.Item("IMPORTE") = M.Importe
            Row.Item("SERIE") = M.Serie
            Row.Item("VENTA") = M.Descripcion
            Row.Item("NUMERO") = M.Numero
            Row.Item("SELECCIONADA") = 0
            Row.Item("POSICION") = M.Posicion
            T.Rows.Add(Row)
        Next
        Return T
    End Function

    Private Function MostrarMovimientos(ByVal xMoneda As Integer) As List(Of MovimientoGeneral)
        If IsNothing(_Movimientos) Then
            Return Nothing
        End If
        Dim lts As List(Of MovimientoGeneral) = New List(Of MovimientoGeneral)()
        For Each M As MovimientoGeneral In _Movimientos
            If (M.Moneda.Codmoneda = xMoneda) Then
                lts.Add(M)
            End If
        Next
        Return lts
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DGMovimientos.CellClick
        If e.RowIndex = -1 Then
            Return
        End If
        PintarSeleccionados(e.RowIndex)
        Sumar()
    End Sub
    Private Sub PintarSeleccionados(ByVal Index As Integer)
        If Index < 0 Then
            Return
        End If

        Dim isSeleccionada As Integer = 0


        isSeleccionada = DGMovimientos.Rows(Index).Cells("SELECCIONADA").Value

        If isSeleccionada = 0 Then
            DGMovimientos.DefaultCellStyle.SelectionForeColor = Color.Black
            DGMovimientos.CurrentCell() = DGMovimientos.Rows(Index).Cells("IMPORTE")
            DGMovimientos.Rows(Index).Cells("IMPORTE").Style.BackColor = Color.LightGreen
            DGMovimientos.CellBorderStyle = DataGridViewCellBorderStyle.Single
            DGMovimientos.Rows(Index).Cells("SELECCIONADA").Value = 1

        Else
            DGMovimientos.Rows(Index).Cells("IMPORTE").Style.BackColor = Color.White
            DGMovimientos.CurrentCell() = DGMovimientos.Rows(Index).Cells("IMPORTE")
            'DGMovimientos.DefaultCellStyle.SelectionBackColor = Color.White
            DGMovimientos.DefaultCellStyle.SelectionForeColor = Color.Black
            DGMovimientos.Rows(Index).Cells("SELECCIONADA").Value = 0
        End If
        DGMovimientos.ClearSelection()
    End Sub


    Private Function ObtenerSeleccionados() As List(Of Object)
        Dim Adjudicar As List(Of Object) = New List(Of Object)
        For Each Row As DataGridViewRow In DGMovimientos.Rows
            If Row.Cells("SELECCIONADA").Value = 1 Then
                Dim M As MovimientoGeneral = getMovimientoFromPendientes(Row.Cells("Serie").Value, Row.Cells("Numero").Value, Row.Cells("Posicion").Value)
                If Not IsNothing(M) Then
                    Adjudicar.Add(M)
                End If
            End If
        Next
        Return Adjudicar
    End Function

    Private Sub btnAdjudicar_Click(sender As Object, e As EventArgs)
        ''Try
        ''    GCobros.getInstance().RealizarAdjudicacion(ObtenerSeleccionados())
        ''Catch ex As Exception
        ''    MsgBox(ex.Message, vbOKOnly, "Error!")
        ''End Try
        CargarDatos()
    End Sub

    Private Function getMovimientoFromPendientes(ByVal xSerie As String, ByVal xNumero As Integer, ByVal xPosicion As Integer) As MovimientoGeneral
        For Each M As MovimientoGeneral In _Movimientos
            If (M.Serie = xSerie And M.Numero = xNumero And M.Posicion = xPosicion) Then
                Return M
            End If
        Next
        Return Nothing
    End Function

    Private Sub cbMonedas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMonedas.SelectedIndexChanged
        Dim M As Moneda = cbMonedas.SelectedItem
        If IsNothing(_Movimientos) Then
            Return
        End If
        _Moneda = M
        DGMovimientos.DataSource = Mostrar(M.Codmoneda)
        DGMovimientos.ClearSelection()
    End Sub


    Private Sub DGMovimientos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGMovimientos.ColumnHeaderMouseClick
        DGMovimientos.ClearSelection()
    End Sub

    Private Sub btnBonificar_Click(sender As Object, e As EventArgs) Handles btnBonificar.Click
        Dim frClave As New frmClave()
        Dim xClave As String


        If ObtenerSeleccionados().Count < 1 Then
            MsgBox("Debe seleccionar algun movimiento", vbOKOnly, "Error!")
            Return
        End If
        If txtComentario.Text.Length < 1 Then
            MsgBox("Debe especificar un comentario", vbOKOnly, "Error!")
            Return
        End If
        If txtComentario.Text.Length < 1 Then
            MsgBox("Debe ingresar un comentario")
            Return
        End If
        If MsgBox("Desea hacer la bonificacion", vbOKCancel, "Esta seguro") = MsgBoxResult.Cancel Then
            Return
        End If
        If _Cliente.Tarifa.ID = 1 Then
            If frClave.ShowDialog = DialogResult.OK Then
                xClave = frClave.Clave
                If Not GEmpresa.getInstance().Clave(xClave) Then
                    MsgBox("No se puede realizar bonificacion")
                    Return
                End If
            End If
        End If
        Try
            btnBonificar.Enabled = False
            Application.DoEvents()
            GCobros.getInstance().Bonificar(ObtenerSeleccionados(), _Cliente, cbMonedas.SelectedItem, 0, Nothing, txtComentario.Text, chkImprimir.Checked)
            txtImporteBonificar.Text = ""
            CargarDatos()
            MsgBox("Bonificacion Realizada", MsgBoxStyle.Information)
            btnBonificar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error!")
        End Try
    End Sub

    Public Overloads Sub Update(O As Object) Implements IObserver.Update
        Dim F As New frmCargando()
        If TypeOf O Is String Then
            Dim Texto = TryCast(O, String)
            If Texto = "Iniciar" Then
                F.Show()
            ElseIf Texto = "Terminar" Then
                F.Dispose()
            End If
        End If
    End Sub


    Private Sub btnBonifGlobal_Click(sender As Object, e As EventArgs) Handles btnBonifGlobal.Click
        Dim frClave As New frmClave()
        Dim xClave As String

        If (Convert.ToDecimal(tbimporte.Text) < 0) Then
            MsgBox("El importe ingresado no es correcto")
            Return
        End If
        If txtComentario.Text.Length < 1 Then
            MsgBox("Debe ingresar un comentario")
            Return
        End If
        If _Cliente.Tarifa.ID = 1 Then
            If frClave.ShowDialog = DialogResult.OK Then
                xClave = frClave.Clave
                If Not GEmpresa.getInstance().Clave(xClave) Then
                    MsgBox("La clave para la bonificacion con tarifa contado no es valida")
                    Return
                End If
            End If
        End If
        Try
            If MsgBox("Desea hacer la bonificacion", vbOKCancel, "Esta seguro") = MsgBoxResult.Cancel Then
                Return
            End If
            Me.btnBonifGlobal.Enabled = False
            Dim xImporte As Decimal = Convert.ToDecimal(tbimporte.Text)
            Dim List As List(Of Object) = New List(Of Object)
            List = ObtenerSeleccionados()
            If (List.Count > 0) Then
                Application.DoEvents()
                GCobros.getInstance().Bonificar(List, _Cliente, cbMonedas.SelectedItem, xImporte, cbSubCuenta.SelectedItem, txtComentario.Text, chkImprimir.Checked)
            Else
                Application.DoEvents()
                GCobros.getInstance().Bonificar(Nothing, _Cliente, cbMonedas.SelectedItem, xImporte, cbSubCuenta.SelectedItem, txtComentario.Text, chkImprimir.Checked)
                MsgBox("Bonificacion Realizada", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error!")
        Finally
            txtImporteBonificar.Text = ""
            CargarDatos()
            Me.btnBonifGlobal.Enabled = True
        End Try
    End Sub

    Private Sub Sumar()
        Dim zSuma As Decimal = 0
        For Each Row As DataGridViewRow In DGMovimientos.Rows
            If Row.Cells("SELECCIONADA").Value = 1 Then
                zSuma += Row.Cells("IMPORTE").Value
            End If
        Next
        txtImporteBonificar.Text = zSuma
    End Sub

    Private Sub txtCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCliente.TextChanged

    End Sub

    Private Sub tbimporte_KeyDown(sender As Object, e As KeyEventArgs) Handles tbimporte.KeyDown
        If e.KeyCode = 188 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbimporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbimporte.KeyPress
        If e.KeyChar = "," Then
            e.Handled = True
            SendKeys.Send(".")
            Return
        End If
    End Sub

    Private Sub tbimporte_TextChanged(sender As Object, e As EventArgs) Handles tbimporte.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frClave As New frmClave()
        Dim xClave As String


        If ObtenerSeleccionados().Count < 1 Then
            MsgBox("Debe seleccionar algun movimiento", vbOKOnly, "Error!")
            Return
        End If
        If txtComentario.Text.Length < 1 Then
            MsgBox("Debe especificar un comentario", vbOKOnly, "Error!")
            Return
        End If
        If txtComentario.Text.Length < 1 Then
            MsgBox("Debe ingresar un comentario")
            Return
        End If
        If MsgBox("Desea hacer la bonificacion", vbOKCancel, "Esta seguro") = MsgBoxResult.Cancel Then
            Return
        End If
        If _Cliente.Tarifa.ID = 1 Then
            If frClave.ShowDialog = DialogResult.OK Then
                xClave = frClave.Clave
                If Not GEmpresa.getInstance().Clave(xClave) Then
                    MsgBox("No se puede realizar bonificacion")
                    Return
                End If
            End If
        End If
        Try
            btnBonificar.Enabled = False
            Application.DoEvents()
            GCobros.getInstance().BonificarWithLine(txtComentario.Text, ObtenerSeleccionados(), _Cliente, cbMonedas.SelectedItem, 0, Nothing, txtComentario.Text, chkImprimir.Checked)
            txtImporteBonificar.Text = ""
            CargarDatos()
            MsgBox("Bonificacion Realizada", MsgBoxStyle.Information)
            btnBonificar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error!")
        End Try
    End Sub
End Class