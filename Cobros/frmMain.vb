Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Windows.Forms
Imports Aguiñagalde.Tools
Imports System.Data
Imports System.Drawing
Imports System.Collections.Generic
Imports Aguiñagalde.Reportes


Public Class frmMain
    Private _log As Log = New Log(Log.NLogs.General)
    Private _Monedas As List(Of Moneda) = GEmpresa.getInstance().getMonedas()
    Private _Cliente As Cliente = Nothing
    Private _mCobrar As Cobrar
    Private _MovimientosCount As Integer = 0
    Private zSumaPesos As Decimal = 0
    Private zSumaDolares As Decimal = 0




    Public Enum MonedaValores
        Pesos = 1
        Dolares = 2
        Multimoneda = -1
    End Enum



    Private Class Cobrar
        Private _MovimientosPagar As List(Of Movimiento)
        Private _Cliente As Cliente
        Private _MovimientosPendientes As List(Of Movimiento)


        Public Sub New(ByVal MovimientosPendientes As List(Of Movimiento), ByVal xCliente As Cliente)
            _MovimientosPendientes = MovimientosPendientes
            _MovimientosPagar = New List(Of Movimiento)
            _Cliente = xCliente
        End Sub

        Public ReadOnly Property MovimientosPagar() As List(Of Movimiento)
            Get
                Return _MovimientosPagar
            End Get
        End Property


        Public Sub LimpiarPagos()
            _MovimientosPagar = New List(Of Movimiento)
        End Sub







        Public Function Adjudicar(ByVal xDocumentos As List(Of Movimiento)) As List(Of Movimiento)
            Dim zImporteTotal As Decimal = 0
            Dim Positivas As List(Of Movimiento) = New List(Of Movimiento)
            Dim Negativas As List(Of Movimiento) = New List(Of Movimiento)
            Dim MTesoreria As List(Of Movimiento) = New List(Of Movimiento)
            For Each D As Movimiento In xDocumentos
                If D.Importe < 0 Then
                    Negativas.Add(D)
                    zImporteTotal += D.Importe
                Else
                    Positivas.Add(D)
                End If
            Next
            If Negativas.Count > 0 And Positivas.Count > 0 Then
                For Each N As Movimiento In Negativas
                    Dim MovP As Movimiento
                    Dim MovS As Movimiento
                    Dim Importe As Decimal = Math.Abs(N.Importe)
                    Dim Index As Integer = 0
                    While Importe > 0 And Index < Positivas.Count
                        Dim MovT As Movimiento = Positivas(Index)
                        If (MovT.Moneda.Codmoneda = N.Moneda.Codmoneda) Then
                            If Importe > MovT.Importe Then
                                MovT.SerieDoc = N.Serie
                                MovT.NumeroDoc = N.Numero
                                MovT.Estado = "S"
                                MTesoreria.Add(MovT)
                                MovS = N.Clone
                                MovS.Estado = "S"
                                MovS.NumeroDoc = N.Numero
                                MovS.SerieDoc = N.Serie
                                MovS.Importe = MovT.Importe * -1
                                MTesoreria.Add(MovS)
                                Importe -= MovT.Importe
                            Else

                                MovS = TryCast(N, Movimiento).Clone
                                MovS.Estado = "S"
                                MovS.NumeroDoc = N.Numero
                                MovS.SerieDoc = N.Serie
                                MTesoreria.Add(MovS)
                                'revisar esta linea                                MovS.Zsaldado =
                                MovP = MovT.Clone
                                MovP.Importe -= Importe
                                MovP.Estado = "P"
                                MTesoreria.Add(MovP)
                                MovT.Importe = Importe
                                MovT.SerieDoc = N.Serie
                                MovT.Estado = "S"
                                MovT.NumeroDoc = N.Numero
                                MTesoreria.Add(MovT)
                                Importe = 0
                            End If
                        End If
                        Index += 1
                    End While
                    If Importe > 0 And MTesoreria.Count > 0 Then
                        MovP = N.Clone
                        MovP.Estado = "P"
                        MovP.Importe = (Importe * -1)
                        MTesoreria.Add(MovP)
                    End If
                Next
            End If
            Return MTesoreria
        End Function

        Public Function Mora(ByVal xMoneda As Integer, ByVal xImporte As Decimal, ByVal xSubCta As SubCuenta) As DebitoMora
            Dim D As Decimal = xImporte
            Dim S As String = GEmpresa.getInstance().Caja.Mora
            Dim Z As Integer = GEmpresa.getInstance().getNumeroZ()
            Dim M As Moneda = GEmpresa.getInstance().getMonedaByID(xMoneda)
            Dim Caja As String = GEmpresa.getInstance().Caja.Id
            Dim L As List(Of Linea) = New List(Of Linea)
            Dim Linea As Linea = New Linea(100000, "MORA")
            Linea.N = "B"
            Linea.Descripcion = "INTERESES MORA"
            Linea.Color = "."
            Linea.Talla = "."
            Linea.Iva = 22
            Linea.Unid1 = 1
            Linea.Unid2 = 1
            Linea.Unid3 = 1
            Linea.Unid4 = 1
            Linea.Unidadestotal = 1
            Linea.Precio = D / 1.22
            Linea.Dto = 0
            Linea.Precioiva = Linea.Total()
            Linea.Tipoimpuesto = 1
            Linea.Codtarifa = 10
            Linea.CodAlmacen = "LB"
            Linea.Precioiva = Math.Abs(D)
            Linea.Udsexpansion = -1
            Linea.Expandida = "F"
            Linea.Totalexpansion = D
            Linea.Costeiva = 0
            Linea.Fechaentrega = Today.ToShortDateString
            Linea.Numkgentrega = 0
            Linea.NumLin = L.Count()
            Linea.CodMoneda = 1
            Linea.Serie = S
            L.Add(Linea)
            Dim B As DebitoMora
            B = New DebitoMora(S, Today, M, "C", Z, Caja, 2, 30, _Cliente, L, "F")
            B.IS = xSubCta
            Return B
        End Function




        Public Function Bonificacion(ByVal xMoneda As Integer, ByVal xImporte As Decimal, ByVal xSubCta As SubCuenta) As Bonificacion
            Dim D As Decimal = xImporte
            Dim S As String = GEmpresa.getInstance().Caja.Descuento
            Dim Z As Integer = GEmpresa.getInstance().getNumeroZ()
            Dim L As List(Of Linea) = New List(Of Linea)
            Dim M As Moneda = GEmpresa.getInstance().getMonedaByID(xMoneda)
            Dim Linea As Linea = New Linea(100001, "DESCUENTO")
            Dim Caja As String = GEmpresa.getInstance().Caja.Id
            Linea.N = "B"
            Linea.Descripcion = "AJUSTE PRECIOS POR BONIF. "
            Linea.Color = "."
            Linea.Talla = "."
            Linea.Iva = 22
            Linea.Unid1 = -1
            Linea.Unid2 = 1
            Linea.Unid3 = 1
            Linea.Unid4 = 1
            Linea.Unidadestotal = -1
            Linea.Precio = D / 1.22
            Linea.Dto = 0
            Linea.Precioiva = Linea.Total()
            Linea.Tipoimpuesto = 1
            Linea.Codtarifa = 10
            Linea.CodAlmacen = "LB"
            Linea.Precioiva = Math.Abs(D)
            Linea.Udsexpansion = -1
            Linea.Expandida = "F"
            Linea.Totalexpansion = D
            Linea.Costeiva = 0
            Linea.Fechaentrega = Today.ToShortDateString
            Linea.Numkgentrega = 0
            Linea.NumLin = L.Count()
            Linea.CodMoneda = 1
            Linea.Serie = S
            L.Add(Linea)
            Dim B As Bonificacion
            B = New Bonificacion(S, Today, M, "C", Z, Caja, 2, 30, _Cliente, L, "F")

            Return B
        End Function

        Public Function Bonificacion(ByVal xMoneda As Integer, ByVal xImporte As Decimal, ByVal xSubCta As SubCuenta, ByVal xLista As List(Of Movimiento)) As Bonificacion
            Dim D As Decimal = xImporte

            Dim S As String = GEmpresa.getInstance().Caja.Descuento
            Dim Z As Integer = GEmpresa.getInstance().getNumeroZ()
            Dim L As List(Of Linea) = New List(Of Linea)
            Dim M As Moneda = GEmpresa.getInstance().getMonedaByID(xMoneda)
            Dim Linea As Linea = New Linea(100001, "DESCUENTO")
            Dim Caja As String = GEmpresa.getInstance().Caja.Id
            Linea.N = "B"
            Linea.Descripcion = "AJUSTE PRECIOS POR BONIF. "
            Linea.Color = "."
            Linea.Talla = "."
            Linea.Iva = 22
            Linea.Unid1 = -1
            Linea.Unid2 = 1
            Linea.Unid3 = 1
            Linea.Unid4 = 1
            Linea.Unidadestotal = -1
            Linea.Precio = D / 1.22
            Linea.Dto = 0
            Linea.Precioiva = Linea.Total()
            Linea.Tipoimpuesto = 1
            Linea.Codtarifa = 10
            Linea.CodAlmacen = "LB"
            Linea.Precioiva = Math.Abs(D)
            Linea.Udsexpansion = -1
            Linea.Expandida = "F"
            Linea.Totalexpansion = D
            Linea.Costeiva = 0
            Linea.Fechaentrega = Today.ToShortDateString
            Linea.Numkgentrega = 0
            Linea.NumLin = L.Count()
            Linea.CodMoneda = 1
            Linea.Serie = S
            L.Add(Linea)
            Dim B As Bonificacion
            B = New Bonificacion(S, Today, M, "C", Z, Caja, 2, 30, _Cliente, L, "F")
            B.Movimiento = xLista
            B.IS = xSubCta
            Return B
        End Function





        Public Function getMora(ByVal xMoneda As Integer) As Decimal
            Dim zTotal As Decimal = 0
            For Each M As Movimiento In _MovimientosPagar
                If (M.Moneda.Codmoneda = xMoneda) Then
                    zTotal += M.getMora
                End If
            Next
            Return zTotal
        End Function

        Public Function AgregarMovimiento(ByVal xMovimiento As Movimiento) As Boolean
            If _MovimientosPagar.Contains(xMovimiento) Then
                Return False
            End If
            If xMovimiento.Estado = "P" Then
                _MovimientosPagar.Add(xMovimiento)
            End If
            Return True
        End Function

        Public Function QuitarMovimiento(ByVal xMovimiento As Movimiento) As Boolean
            If _MovimientosPagar.Contains(xMovimiento) Then
                _MovimientosPagar.Remove(xMovimiento)
                Return True
            End If
            Return False
        End Function



        Private Function Apagar(ByVal xMoneda) As List(Of Movimiento)
            Dim Lista As List(Of Movimiento) = New List(Of Movimiento)
            For Each Mov As Movimiento In _MovimientosPagar
                If Mov.Moneda.Codmoneda = xMoneda Then
                    Lista.Add(Mov)
                End If
            Next
            Return Lista
        End Function

        Private Function getDescuento(ByVal xMoneda As Integer) As Decimal
            Dim zTotal As Decimal = 0
            For Each M As Movimiento In _MovimientosPagar
                If (M.Moneda.Codmoneda = xMoneda) Then
                    zTotal += M.getDescuento
                End If
            Next
            Return zTotal
        End Function

        Public Function Pendientes(ByVal xCodMoneda) As List(Of Movimiento)
            Dim Mov As List(Of Movimiento) = New List(Of Movimiento)
            For Each M As Movimiento In _MovimientosPendientes
                If M.Moneda.Codmoneda = xCodMoneda Then
                    Mov.Add(M)
                End If
            Next
            Return Mov
        End Function



        Public Function Mostrar(ByVal xMoneda As MonedaValores) As DataTable
            Dim T As New DataTable("Movimientos")
            Dim ColFecha As DataColumn = New DataColumn("FECHA", Type.GetType("System.String"))
            Dim ColPos As DataColumn = New DataColumn("POSICION", Type.GetType("System.Int32"))
            Dim ColImporte As DataColumn = New DataColumn("IMPORTE", Type.GetType("System.Single"))
            Dim ColDesc As DataColumn = New DataColumn("DESCUENTO", Type.GetType("System.Single"))
            Dim ColMora As DataColumn = New DataColumn("MORA", Type.GetType("System.Single"))
            Dim ColDiasVencidos As DataColumn = New DataColumn("DIAS VENCIDOS", Type.GetType("System.Int32"))
            Dim ColFechaVecimiento As DataColumn = New DataColumn("FECHA VENCIMIENTO", Type.GetType("System.String"))
            Dim ColSerie As DataColumn = New DataColumn("SERIE", Type.GetType("System.String"))
            Dim ColLugar As DataColumn = New DataColumn("VENTA", Type.GetType("System.String"))
            Dim ColNumero As DataColumn = New DataColumn("NUMERO", Type.GetType("System.Int32"))
            Dim ColMoneda As DataColumn = New DataColumn("MONEDA", Type.GetType("System.String"))
            Dim ColSaldo As DataColumn = New DataColumn("SALDO", Type.GetType("System.Single"))
            Dim ColdIdMoneda As DataColumn = New DataColumn("CODMONEDA", Type.GetType("System.Int32"))
            T.Columns.Add(ColdIdMoneda)
            T.Columns.Add(ColMoneda)
            T.Columns.Add(ColFecha)
            T.Columns.Add(ColFechaVecimiento)
            T.Columns.Add(ColSerie)
            T.Columns.Add(ColLugar)
            T.Columns.Add(ColNumero)
            T.Columns.Add(ColPos)
            T.Columns.Add(ColDiasVencidos)
            T.Columns.Add(ColImporte)
            T.Columns.Add(ColMora)
            T.Columns.Add(ColDesc)
            T.Columns.Add(ColSaldo)
            Dim Mov As New List(Of Movimiento)
            Try
                If xMoneda = MonedaValores.Dolares Then
                    Mov = Pendientes(2)
                ElseIf xMoneda = MonedaValores.Multimoneda Then
                    Mov = _MovimientosPendientes
                Else
                    Mov = Pendientes(1)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            For Each M As Movimiento In Mov
                Dim Row As DataRow = T.NewRow()
                Try
                    Row.Item("CODMONEDA") = M.Moneda.Codmoneda
                    Row.Item("MONEDA") = M.Moneda.Descripcion
                    Row.Item("FECHA") = M.Fecha.ToShortDateString
                    Row.Item("Fecha Vencimiento") = M.FechaVencimiento().ToShortDateString()
                    Row.Item("Dias Vencidos") = M.getDiasVencidos()
                    Row.Item("IMPORTE") = M.Importe
                    Row.Item("MORA") = M.getMora()
                    Row.Item("DESCUENTO") = M.getDescuento()
                    Row.Item("SERIE") = M.Serie
                    Row.Item("POSICION") = M.Posicion
                    Row.Item("VENTA") = M.Descripcion
                    Row.Item("NUMERO") = M.Numero
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                T.Rows.Add(Row)
            Next
            Return T
        End Function

        Function Parcial(ByVal xMora As Boolean) As Decimal
            Dim Suma As Decimal = 0
            For Each M As Movimiento In _MovimientosPagar
                If xMora Then
                    Suma += M.getMora()
                End If
                If M.ImportePagado > 0 Then
                    Suma += M.ImportePagado
                Else
                    Suma += M.Importe
                End If
            Next
            Return Suma
        End Function

        Public Function Documentos(ByVal xMoneda As Integer, ByVal xMora As Boolean) As List(Of Documento)
            Dim L As List(Of Documento) = New List(Of Documento)
            Dim zBonificacion As Decimal = 0
            Dim zBonificacionCFE As Decimal = 0
            Dim zMora As Decimal = 0
            For Each SC As SubCuenta In _Cliente.SubCuentas
                Dim ListaMovCFE As List(Of Movimiento) = New List(Of Movimiento)
                Dim ListaMov As List(Of Movimiento) = New List(Of Movimiento)
                For Each M As Movimiento In Apagar(xMoneda)
                    If M.Subcta = 0 Then
                        If IsNothing(M.CFE) Then
                            zBonificacion += M.getDescuento()
                            ListaMov.Add(M)
                        Else
                            zBonificacionCFE += M.getDescuento()
                            ListaMovCFE.Add(M)
                        End If
                        If xMora Then
                            zMora += M.getMora
                        End If
                    End If
                Next
                If zBonificacion > 0 Then
                    L.Add(Bonificacion(xMoneda, zBonificacion, SC, ListaMov))
                End If
                If zBonificacionCFE > 0 Then
                    L.Add(Bonificacion(xMoneda, zBonificacionCFE, SC, ListaMovCFE))
                End If
                If (zMora > 0) Then
                    L.Add(Mora(xMoneda, zMora, SC))
                End If
                zBonificacion = 0
                zBonificacionCFE = 0
            Next


            Return L
        End Function

        Private Function PagaMoneda(ByVal xMoneda As Integer) As Boolean
            For Each M As Movimiento In Me._MovimientosPagar
                If M.Moneda.Codmoneda = xMoneda Then
                    Return True
                End If
            Next
            Return False
        End Function

        Function getMovimiento(Serie As String, Numero As Integer, Pos As Byte) As Movimiento
            For Each M As Movimiento In _MovimientosPendientes
                If M.Serie = Serie And M.Numero = Numero And M.Posicion = Pos Then
                    Return M
                End If
            Next
            Return Nothing
        End Function

        Function Saldo(ByVal xMoneda As Integer) As Decimal
            Dim zSuma As Decimal = 0
            For Each M As Movimiento In _MovimientosPendientes
                If M.Moneda.Codmoneda = xMoneda Then
                    zSuma += M.Importe
                End If
            Next
            Return zSuma
        End Function

        Function getMoraTotal(ByVal xMoneda As Integer) As Decimal
            Dim zSuma As Decimal = 0
            For Each M As Movimiento In _MovimientosPendientes
                If M.Moneda.Codmoneda = xMoneda Then
                    zSuma += M.getMora()
                End If
            Next
            Return zSuma
        End Function

        Function CantidadMovimientosPagar(ByVal Index As Integer) As String
            Return "Movimientos: " & Index
        End Function

    End Class

    Private Sub SeleccionarFila(ByVal Index As Int32)
        GridMPendientes.Rows(Index).Selected = True
    End Sub


    Private Sub PintarSeleccionados(ByVal Index As Integer)
        If Index < 0 Then
            Return
        End If

        Dim Importe As Decimal = 0
        Dim Descuento As Decimal = 0
        Dim Mora As Decimal = 0

        Importe = GridMPendientes.Rows(Index).Cells("Importe").Value
        Descuento = GridMPendientes.Rows(Index).Cells("Descuento").Value
        Mora = GridMPendientes.Rows(Index).Cells("Mora").Value
        GridMPendientes.DefaultCellStyle.SelectionBackColor = Color.White
        GridMPendientes.DefaultCellStyle.SelectionForeColor = Color.Black
        If (chkMora.Checked) Then
            GridMPendientes.Rows(Index).Cells("Saldo").Value = (Importe - Descuento) + Mora
        Else
            GridMPendientes.Rows(Index).Cells("Saldo").Value = (Importe - Descuento)
        End If
        GridMPendientes.CurrentCell() = GridMPendientes.Rows(Index).Cells("SALDO")
        GridMPendientes.Rows(Index).Cells("SALDO").Style.BackColor = Color.LightGreen
        GridMPendientes.DefaultCellStyle.SelectionBackColor = Color.Orange
        GridMPendientes.DefaultCellStyle.SelectionForeColor = Color.Black
        GridMPendientes.CellBorderStyle = DataGridViewCellBorderStyle.Single
        _MovimientosCount += 1
        'lblMovimientosM.Text = _mCobrar.CantidadMovimientosPagar(_MovimientosCount)
    End Sub

    Private Sub PintarSeleccionados(ByVal Index As Integer, ByVal xImporte As Decimal)
        If Index < 0 Then
            Return
        End If
        GridMPendientes.DefaultCellStyle.SelectionBackColor = Color.White
        GridMPendientes.DefaultCellStyle.SelectionForeColor = Color.Black
        GridMPendientes.Rows(Index).Cells("Saldo").Value = xImporte
        GridMPendientes.CurrentCell() = GridMPendientes.Rows(Index).Cells("SALDO")
        GridMPendientes.Rows(Index).Cells("SALDO").Style.BackColor = Color.LightGreen
        GridMPendientes.DefaultCellStyle.SelectionBackColor = Color.Orange
        GridMPendientes.DefaultCellStyle.SelectionForeColor = Color.Black
        GridMPendientes.CellBorderStyle = DataGridViewCellBorderStyle.Single
        _MovimientosCount += 1
        'lblMovimientosM.Text = _mCobrar.CantidadMovimientosPagar(_MovimientosCount)
    End Sub




    Private Sub Despintar(ByVal Index As Integer)
        If Index < 0 Then
            Return
        End If
        GridMPendientes.Rows(Index).Cells("SALDO").Style.BackColor = Color.White

        GridMPendientes.Rows(Index).Cells("SALDO").Value = DBNull.Value


        GridMPendientes.CurrentCell() = GridMPendientes.Rows(Index).Cells("SALDO")
        GridMPendientes.DefaultCellStyle.SelectionBackColor = Color.White
        GridMPendientes.DefaultCellStyle.SelectionForeColor = Color.Black
        txtPagarPesos.Text = _mCobrar.Parcial(chkMora.Checked)

        If _MovimientosCount > 0 Then
            _MovimientosCount -= 1
        End If

    End Sub

    Private Sub Totalizar()
        For Each Row As DataGridViewRow In GridMPendientes.Rows
            If Not Row.Cells("SALDO").Value Is DBNull.Value Then
                If Row.Cells("CODMONEDA").Value = 1 Then
                    zSumaPesos += Row.Cells("SALDO").Value
                    txtPagarPesos.Text = zSumaPesos
                Else
                    zSumaDolares += Row.Cells("SALDO").Value
                    txtPagarDolares.Text = zSumaDolares
                End If
            End If
        Next

        zSumaDolares = 0
        zSumaPesos = 0
    End Sub

    Private Sub GridMPendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridMPendientes.CellClick
        If e.RowIndex = -1 Then
            Return
        End If


        If GridMPendientes.Rows(e.RowIndex).Cells("Saldo").Value Is DBNull.Value Then
            PintarSeleccionados(e.RowIndex)

        Else
            Despintar(e.RowIndex)

        End If
        Totalizar()

    End Sub



    Private Sub GridMPendientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridMPendientes.CellDoubleClick
        If e.ColumnIndex = GridMPendientes.Columns("VENTA").Index Then
            MsgBox(GridMPendientes.Item("SERIE", e.RowIndex).Value)
        End If
    End Sub




    Private Sub GridMPendientes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridMPendientes.CellEndEdit
        Try
            Dim V As Decimal = GridMPendientes.Rows(e.RowIndex).Cells("SALDO").Value
            PintarSeleccionados(e.RowIndex, V)
        Catch ex As Exception

        End Try
        Totalizar()
    End Sub

    Private Sub txtCodCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodCliente.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim CodCliente As Integer = -1
            If Tools.Numeros.IsNumeric(txtCodCliente.Text) Then
                CodCliente = Val(txtCodCliente.Text)
            End If
            If CodCliente > 0 Then


                Try
                    _Cliente = GCliente.Instance().getByID(CodCliente)
                    Dim mov As List(Of Movimiento) = GCliente.Instance().getPendientesByCliente(_Cliente.IdCliente)

                    _mCobrar = New Cobrar(mov, _Cliente)
                    GridMPendientes.DataSource = _mCobrar.Mostrar(MonedaValores.Multimoneda)
                    GridMPendientes.Columns("CODMONEDA").Visible = False
                    PopularDatos(_Cliente)
                Catch ex As Exception
                    _log.EscribirLog(ex.Message)
                    MsgBox(ex.Message, vbOKOnly, "Error!")
                End Try
            End If
        End If
    End Sub



    Private Sub RDPesos_CheckedChanged(sender As Object, e As EventArgs) Handles RDPesos.CheckedChanged
        If Not IsNothing(_mCobrar) And Not IsNothing(_Cliente) Then
            GridMPendientes.DataSource = _mCobrar.Mostrar(MonedaValores.Pesos)
            GridMPendientes.Columns("SALDO").ReadOnly = False
            BorrarDatos()
            Totalizar()
        End If

    End Sub

    Private Sub RDDolares_CheckedChanged(sender As Object, e As EventArgs) Handles RDDolares.CheckedChanged
        If Not IsNothing(_mCobrar) And Not IsNothing(_Cliente) Then
            GridMPendientes.DataSource = _mCobrar.Mostrar(MonedaValores.Dolares)
            GridMPendientes.Columns("SALDO").ReadOnly = False
            BorrarDatos()
            Totalizar()
        End If

    End Sub

    Private Sub RDMulti_CheckedChanged(sender As Object, e As EventArgs) Handles RDMulti.CheckedChanged
        If Not IsNothing(_mCobrar) And Not IsNothing(_Cliente) Then
            GridMPendientes.DataSource = _mCobrar.Mostrar(MonedaValores.Multimoneda)
            BorrarDatos()
            Totalizar()
        End If

    End Sub


    Private Sub PopularDatos(ByVal xCliente As Cliente)
        RDMulti.Checked = True
        txtSaldoPesos.Text = _mCobrar.Saldo(1)
        txtSaldoDolares.Text = _mCobrar.Saldo(2)
        txtMoraPesos.Text = _mCobrar.getMoraTotal(1)
        txtMoraDolares.Text = _mCobrar.getMoraTotal(2)
        txtTotalPesos.Text = Convert.ToDecimal(txtSaldoPesos.Text) + Convert.ToDecimal(txtMoraPesos.Text)
        txtTotalDolares.Text = Convert.ToDecimal(txtSaldoDolares.Text) + Convert.ToDecimal(txtMoraDolares.Text)
        txtClienteNombre.Text = _Cliente.Nombre
        txtClienteDireccion.Text = _Cliente.Direccion
        txtClienteTelefono.Text = _Cliente.Telefono
        txtClienteDireccion.BackColor = Color.White
        txtClienteNombre.BackColor = Color.White
        txtClienteTelefono.BackColor = Color.White
        Dim Estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
        Estilo.Font = New Font("Thaoma", 10, FontStyle.Underline)
        Estilo.ForeColor = Color.Blue
        GridMPendientes.Columns("SERIE").Visible = False
        GridMPendientes.Columns("VENTA").DefaultCellStyle = Estilo
        GridMPendientes.Columns("SALDO").ReadOnly = False
        For Each C As DataGridViewColumn In GridMPendientes.Columns
            If C.Name <> "SALDO" Then
                C.ReadOnly = True
            End If
        Next

    End Sub


    Private Sub BorrarDatos()
        txtPagarPesos.Text = ""
        _mCobrar.LimpiarPagos()
    End Sub

    Private Sub chkMora_CheckedChanged(sender As Object, e As EventArgs) Handles chkMora.CheckedChanged
        If Not IsNothing(_Cliente) Then
            _mCobrar.MovimientosPagar.Clear()
            BorrarDatagrid()
            _MovimientosCount = 0
            Totalizar()
        End If
    End Sub

    Private Sub BorrarDatagrid()
        For Each R As DataGridViewRow In GridMPendientes.Rows
            R.Cells("SALDO").Value = DBNull.Value
            R.Cells("SALDO").Style.BackColor = Color.White
            R.DefaultCellStyle.SelectionForeColor = Color.Black
        Next
    End Sub









    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Imp As New Impresion()
        Dim R As Recibo

        'R = GCuentas.Instance().ObtenerReciboByID("VB1X", Num)

        R = GCuentas.Instance().ObtenerReciboByID("VB1X", 643420)


        Imp.Imprimir(R)
    End Sub




    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub btnEC_Click(sender As Object, e As EventArgs) Handles btnEC.Click
        If IsNothing(_Cliente) Then
            Return
        End If
        Dim frmEntrega As New frmEntregaCuenta(_Cliente)
        frmEntrega.ShowDialog()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        For Each Row As DataGridViewRow In GridMPendientes.Rows
            If Not Row.Cells("SALDO").Value Is DBNull.Value Then
                If Row.Cells("SALDO").Value < 0 Then
                    MsgBox("No puede hacer un pago con un movimiento negativo, adjudique antes.", vbOKOnly, "Advertencia!")
                    Return
                End If
                Dim M As Movimiento = _mCobrar.getMovimiento(Row.Cells("Serie").Value, Row.Cells("Numero").Value, Row.Cells("Posicion").Value)
                If M.Importe <> Row.Cells("SALDO").Value Then
                    M.ImportePagado = Row.Cells("SALDO").Value
                End If
                _mCobrar.AgregarMovimiento(M)
            End If
        Next
        Dim Ldocumentos As List(Of Documento) = New List(Of Documento)
        For Each Mon As Moneda In GEmpresa.getInstance().getMonedas()
            For Each Doc As Documento In _mCobrar.Documentos(Mon.Codmoneda, chkMora.Checked)
                Ldocumentos.Add(Doc)
            Next
        Next



        Dim L As List(Of Integer)
        L = GCuentas.Instance().GenerarRecibos(_mCobrar.MovimientosPagar, Ldocumentos, chkMora.Checked)
        Dim Imp As New Impresion()
        Dim R As Recibo = Nothing
        Dim B As Bonificacion = Nothing
        Dim Mora As DebitoMora




        For Each I As Integer In L
            R = GCuentas.Instance().ObtenerReciboByID("VB1X", I)
            Imp.Imprimir(R)
            'B = GCuentas.Instance().getBonificacionByRecibo(I, "VB1X")
            '    If (chkMora.Checked) Then
            '    End If
        Next
        'R = GCuentas.Instance().ObtenerReciboByID("VB1X", 643424)
        'Imp.Imprimir(R)

        'GEmpresa.getInstance().CrearXML(B)









    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Movs As List(Of Movimiento) = New List(Of Movimiento)
        For Each Row As DataGridViewRow In GridMPendientes.Rows
            If Not Row.Cells("SALDO").Value Is DBNull.Value Then
                Dim M As Movimiento = _mCobrar.getMovimiento(Row.Cells("Serie").Value, Row.Cells("Numero").Value, Row.Cells("Posicion").Value)
                If M.Importe <> Row.Cells("SALDO").Value Then
                    M.ImportePagado = Row.Cells("SALDO").Value
                End If
                Movs.Add(M)
            End If
        Next
        Movs = _mCobrar.Adjudicar(Movs)
        If Movs.Count > 0 Then
            GCuentas.Instance().AdjudicarDocumentos(Movs)
        End If
    End Sub

    Private Sub txtCodCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged

    End Sub
End Class