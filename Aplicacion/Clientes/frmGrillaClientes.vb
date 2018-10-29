Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Entidades
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing


Public Class frmGrillaClientes

    Private tClientes As DataTable = GCliente.Instance().TablaClientes
    Private _cliente As ClienteActivo
    Private mIndex As Byte = 0 'Columna seleccionada

    Private mActiva As String = "CODIGO" ' Nombre columna activa
    Private mFiltro As String = ""

    Public ReadOnly Property Cliente() As ClienteActivo
        Get
            Return _cliente
        End Get
    End Property






    Private Sub frmGrillaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Funciones.DoubleBuffered(GrillaClientes, True)

        With GrillaClientes
            .DataSource = tClientes
            For Each ObjCol As DataGridViewColumn In .Columns
                ObjCol.SortMode = DataGridViewColumnSortMode.Programmatic
            Next
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.Beige
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub frmGrillaClientes_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
            Case Keys.F2
                tClientes = GCliente.Instance().TablaClientes
                GrillaClientes.DataSource = tClientes
        End Select
    End Sub
    Private Sub GrillaClientes_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrillaClientes.ColumnHeaderMouseClick

        mFiltro = ""
        mActiva = (sender.Columns(e.ColumnIndex).Name)
        With sender
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.White
            .Columns(e.ColumnIndex).DefaultCellStyle.BackColor = Color.Beige
        End With
        mIndex = e.ColumnIndex

        If txtDato.Text.Length > 1 Then
            Try

                tClientes = (From Cliente In tClientes.AsEnumerable()
                             Where Cliente(mActiva).Contains(txtDato.Text.ToUpper())
                             Select Cliente).CopyToDataTable()
                GrillaClientes.DataSource = tClientes
                txtDato.Clear()
            Catch ex As Exception


            End Try
        End If
    End Sub

    Private Sub GrillaClientes_DoubleClick(sender As Object, e As EventArgs) Handles GrillaClientes.DoubleClick
        Dim IdCliente As Integer = -1
        IdCliente = GrillaClientes.Item("CODIGO", GrillaClientes.CurrentRow.Index).Value()
        Try
            _cliente = GCliente.Instance().getByID(IdCliente, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GrillaClientes_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles GrillaClientes.KeyDown
        Dim IdCliente As Integer = -1
        If e.KeyCode = Keys.Enter Then
            IdCliente = GrillaClientes.Item("CODIGO", GrillaClientes.CurrentRow.Index).Value()
            Try
                _cliente = GCliente.Instance().getByID(IdCliente, False)
            Catch ex As Exception
            End Try
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub GrillaClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellContentClick

    End Sub
End Class