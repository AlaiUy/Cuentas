Imports System.Collections.Generic
Imports Aguiñagalde.Entidades
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Diagnostics

Public Class frmPendientes
    Private _Movimiento As List(Of MovimientoGeneral) = Nothing
    Public Sub New(ByVal xList As List(Of MovimientoGeneral))
        InitializeComponent()
        _Movimiento = xList
    End Sub

    Private Sub frmPendientes_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub frmPendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DT As DataTable = New DataTable
        Dim ColSer As DataColumn = DT.Columns.Add("SERIE", Type.GetType("System.String"))
        Dim ColNum As DataColumn = DT.Columns.Add("NUMERO", Type.GetType("System.Int32"))
        Dim ColFec As DataColumn = DT.Columns.Add("FECHA", Type.GetType("System.DateTime"))
        Dim ColMoneda As DataColumn = DT.Columns.Add("MONEDA", Type.GetType("System.String"))
        Dim ColImporte As DataColumn = DT.Columns.Add("IMPORTE", Type.GetType("System.Decimal"))
        Dim ColCfe As DataColumn = DT.Columns.Add("CFE", Type.GetType("System.String"))



        For Each M As MovimientoGeneral In _Movimiento
            Dim RM As DataRow = DT.NewRow()
            RM("FECHA") = M.Fecha
            RM("SERIE") = M.Serie
            RM("NUMERO") = M.Numero
            RM("MONEDA") = M.Moneda.Descripcion
            RM("IMPORTE") = M.Importe
            If Not IsNothing(M.CFE) Then
                RM("CFE") = M.CFE.Link
            End If
            DT.Rows.Add(RM)
        Next
        DGMovimientos.DataSource = DT
        Dim LinkColumn As DataGridViewLinkColumn = New DataGridViewLinkColumn()


        LinkColumn.Name = "CFE1"
        LinkColumn.HeaderText = "Factura"
        LinkColumn.ReadOnly = False

        ' LinkColumn.UseColumnTextForLinkValue = True
        DGMovimientos.Columns.Add(LinkColumn)




       

        DGMovimientos.Columns("CFE").Visible = False

        'With DGMovimientos
        '    For Each C As DataGridViewColumn In .Columns
        '        C.SortMode = DataGridViewColumnSortMode.Programmatic
        '    Next
        'End With


    End Sub

    Private Sub AgregarLinks()
        For Index As Integer = 0 To DGMovimientos.Rows.Count - 1
            If (DGMovimientos.Item("CFE", Index).Value().ToString().Length > 0) Then
                DGMovimientos.Item("CFE1", Index).Value = "Ver Factura..."
            Else
                DGMovimientos.Item("CFE1", Index).Style.BackColor = Color.Gray
            End If
        Next
    End Sub

    Private Sub DGMovimientos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMovimientos.CellClick
        If e.RowIndex > -1 Then
            If e.ColumnIndex = DGMovimientos.Columns("CFE1").Index And Not (DGMovimientos.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing) Then
                Process.Start(DGMovimientos.Item("CFE", e.RowIndex).Value)
            End If
        End If
    End Sub

  
    Private Sub DGMovimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMovimientos.CellContentClick

    End Sub

    Private Sub DGMovimientos_Click(sender As Object, e As EventArgs) Handles DGMovimientos.Click

    End Sub

    Private Sub DGMovimientos_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGMovimientos.ColumnHeaderMouseClick
        AgregarLinks()
    End Sub
End Class