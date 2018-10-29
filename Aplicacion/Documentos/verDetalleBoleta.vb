Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Aguiñagalde.Gestoras

Public Class verDetalleBoleta
    Private _DT As DataTable

    Public Sub New(ByVal xDT As DataTable)
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _DT = xDT
    End Sub


    Private Sub verDetalleBoleta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub verDetalleBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PupularDatos()
    End Sub

    Private Sub PupularDatos()
        DGDetalle.DataSource = _DT
        Dim Estilo As DataGridViewCellStyle = New DataGridViewCellStyle()
        Estilo.Font = New Font("Thaoma", 10, FontStyle.Underline)
        Estilo.ForeColor = Color.Blue
        If Not DGDetalle.Columns("SERIE") Is Nothing Then
            DGDetalle.Columns("SERIE").DefaultCellStyle = Estilo
            DGDetalle.Columns("NUMERO").DefaultCellStyle = Estilo
        End If

    End Sub

    Private Sub DGDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDetalle.CellContentClick

    End Sub

    Private Sub DGDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDetalle.CellClick
        'If e.ColumnIndex = DGDetalle.Columns("SERIE").DisplayIndex Or e.ColumnIndex = DGDetalle.Columns("NUMERO").DisplayIndex Then
        '    Dim serie As String = DGDetalle.Item(DGDetalle.Columns("SERIE").Index, e.RowIndex).Value
        '    Dim numero As Integer = DGDetalle.Item(DGDetalle.Columns("NUMERO").Index, e.RowIndex).Value
        '    If e.ColumnIndex = DGDetalle.Columns("SERIE").DisplayIndex Then
        '        Dim fDetalle As New verDetalleBoleta(GCliente.Instance().DetalleFactura(serie, numero))
        '        fDetalle.ShowDialog()
        '        Return
        '    Else
        '        Dim FPDetalle As New verDetalleBoleta(GCobros.getInstance().DetallePosicion(serie, numero))
        '        FPDetalle.ShowDialog()
        '        Return
        '    End If
        'End If
    End Sub
End Class