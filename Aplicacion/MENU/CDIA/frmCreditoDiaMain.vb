Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmCreditoDiaMain

    Private Shared _Intance As frmCreditoDiaMain = Nothing


    Public Shared ReadOnly Property getInstance() As frmCreditoDiaMain
        Get
            If _Intance Is Nothing OrElse _Intance.IsDisposed() Then
                _Intance = New frmCreditoDiaMain()
            End If
            _Intance.Up()
            _Intance.TopMost = True
            _Intance.TopMost = False
            Return _Intance
        End Get
    End Property

    Private Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub



    Private Sub frmCreditoDiaMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PopularDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Up()
        PopularDatos()
    End Sub

    Private Sub PopularDatos()

        GridMain.DataSource = New DataTable()
        GridMain.Refresh()
        GridMain.DataSource = GCobros.getInstance.ContadosPendientes()

        txtTotalP.BackColor = Drawing.Color.White
        Dim Estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
        Estilo.Font = New Font("Thaoma", 10, FontStyle.Underline)
        Estilo.ForeColor = Color.Blue
        GridMain.DefaultCellStyle.Font = New Font("Thaoma", 10)
        GridMain.Columns("SERIE").Visible = True
        GridMain.Columns("SERIE").DefaultCellStyle = Estilo
        GridMain.Columns("COMPOSICION").DefaultCellStyle = Estilo
        GridMain.Columns("CODMONEDA").Visible = False
        GridMain.Columns("SELECCIONADA").ReadOnly = True
        GridMain.Columns("SELECCIONADA").Visible = False
        GridMain.Columns("COTIZACION").Visible = False
        GridMain.Columns("PENDIENTE").Visible = False
        GridMain.Columns("IMPORTE").DefaultCellStyle.Format = "N2"
        GridMain.Columns("IMPORTE").DefaultCellStyle.Font = New Font("Thaoma", 10, FontStyle.Bold)
        txtTotalP.BackColor = Color.White

        GridMain.ClearSelection()

        For Each Col As DataGridViewColumn In GridMain.Columns
            Col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        For Each Row As DataGridViewRow In GridMain.Rows

            If Row.Cells("PENDIENTE").Value > 0 Then
                Row.DefaultCellStyle.BackColor = Color.LightPink
            End If
        Next
    End Sub

    Private Sub GridMain_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles GridMain.CellContentClick

    End Sub

    Private Sub Despintar(ByVal Index As Integer)
        If Index < 0 Then
            Return
        End If
        GridMain.CellBorderStyle = DataGridViewCellBorderStyle.Single
        GridMain.Rows(Index).Cells("SELECCIONADA").Value = 0
        GridMain.CurrentCell() = GridMain.Rows(Index).Cells("IMPORTE")
        GridMain.Rows(Index).Cells("IMPORTE").Style.BackColor = Color.White
        GridMain.CurrentCell.Style.SelectionBackColor = Color.White
        GridMain.DefaultCellStyle.SelectionForeColor = Color.Black
    End Sub

    Private Sub GridMain_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridMain.CellClick
        If e.RowIndex = -1 Then
            Return
        End If

        If e.ColumnIndex = GridMain.Columns("SERIE").DisplayIndex Or e.ColumnIndex = GridMain.Columns("COMPOSICION").DisplayIndex Then
            Dim serie As String = GridMain.Item(GridMain.Columns("SERIE").Index, e.RowIndex).Value
            Dim numero As Integer = GridMain.Item(GridMain.Columns("NUMERO").Index, e.RowIndex).Value
            Me.TopMost = False
            If e.ColumnIndex = GridMain.Columns("SERIE").DisplayIndex Then
                Dim fDetalle As New verDetalleBoleta(numero, serie)
                fDetalle.TopMost = True
                fDetalle.ShowDialog()
                Return
            Else
                Dim FPDetalle As New verDetalleBoleta(numero, serie)
                FPDetalle.TopMost = True
                FPDetalle.ShowDialog()
                Return
            End If
        End If

        If GridMain.Rows(e.RowIndex).Cells("SELECCIONADA").Value Is DBNull.Value Then
            PintarSeleccionados(e.RowIndex)
        ElseIf GridMain.Rows(e.RowIndex).Cells("SELECCIONADA").Value = 1 Then
            Despintar(e.RowIndex)
        Else
            PintarSeleccionados(e.RowIndex)
        End If
        Totalizar()

    End Sub

    Private Sub Totalizar()
        Dim zSumaP As Decimal = 0
        Dim zSumaD As Decimal = 0
        For Each Row As DataGridViewRow In GridMain.Rows
            If Not Row.Cells("SELECCIONADA").Value Is DBNull.Value Then
                If Row.Cells("SELECCIONADA").Value = 1 Then
                    If Row.Cells("CODMONEDA").Value = 1 Then
                        zSumaP += (Row.Cells("IMPORTE").Value)
                    Else
                        zSumaD += (Row.Cells("IMPORTE").Value)
                    End If

                End If

            End If
        Next
        txtTotalP.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zSumaP)
        txtTotalD.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zSumaD)

    End Sub

    Private Sub PintarSeleccionados(ByVal Index As Integer)
        If Index < 0 Then
            Return
        End If

        GridMain.CellBorderStyle = DataGridViewCellBorderStyle.Single
        GridMain.Rows(Index).Cells("SELECCIONADA").Value = 1
        GridMain.CurrentCell() = GridMain.Rows(Index).Cells("IMPORTE")
        GridMain.Rows(Index).Cells("IMPORTE").Style.BackColor = Color.LightGreen
        GridMain.CurrentCell.Style.SelectionBackColor = Color.LightGreen
        GridMain.DefaultCellStyle.SelectionForeColor = Color.Black


    End Sub

    Private Sub GridMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridMain.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()
            Return
        End If
        If GridMain.Rows.Count < 1 Then
            Return
        End If
        If e.KeyChar = Convert.ToChar(Keys.F12) Then
            PopularDatos()
        End If
        If GridMain.Rows.Count < 1 Then
            Return
        End If
    End Sub

    Private Sub GridMain_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles GridMain.CellMouseEnter
        If Not IsNothing(GridMain.Columns("SERIE")) Then
            If e.ColumnIndex = GridMain.Columns("SERIE").DisplayIndex Then
                Me.Cursor = System.Windows.Forms.Cursors.Hand
            End If
        End If
        If Not IsNothing(GridMain.Columns("COMPOSICION")) Then
            If e.ColumnIndex = GridMain.Columns("COMPOSICION").DisplayIndex Then
                Me.Cursor = System.Windows.Forms.Cursors.Hand
            End If
        End If
    End Sub

    Private Sub GridMain_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles GridMain.CellMouseLeave
        If Not IsNothing(GridMain.Columns("SERIE")) Then
            If e.ColumnIndex = GridMain.Columns("SERIE").DisplayIndex Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        End If

        If Not IsNothing(GridMain.Columns("COMPOSICION")) Then
            If e.ColumnIndex = GridMain.Columns("COMPOSICION").DisplayIndex Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If
        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim Lista As New List(Of Object)
        For Each Row As DataGridViewRow In GridMain.Rows
            If Not Row.Cells("SELECCIONADA").Value Is DBNull.Value Then
                If Row.Cells("SELECCIONADA").Value = 1 Then
                    Lista.Add(New MovimientoCP(Row.Cells("NUMERO").Value, Row.Cells("SERIE").Value, Row.Cells("FECHA").Value, Row.Cells("IMPORTE").Value, Row.Cells("COMPOSICION").Value, Row.Cells("COTIZACION").Value))
                End If
            End If
        Next
        Try
            TryCast(sender, Button).Enabled = False
            GCobros.getInstance().SaldarCP(Lista)
            PopularDatos()
            MsgBox("Saldado correctamente")
        Catch ex As Exception
            TryCast(sender, Button).Enabled = True
            MsgBox(ex.Message)
        End Try
        TryCast(sender, Button).Enabled = True
    End Sub

    Private Sub frmCreditoDiaMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Return
        End If
        If e.KeyCode = Keys.F12 Then
            PopularDatos()
        End If
        If e.KeyCode = Keys.F11 Then
            Dim frmImprimir As New frmImprimirArqueo()
            frmImprimir.ShowDialog()
        End If
    End Sub
End Class