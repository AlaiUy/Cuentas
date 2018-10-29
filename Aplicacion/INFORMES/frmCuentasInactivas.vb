Imports Aguiñagalde.Entidades
Imports System.Collections.Generic
Imports Aguiñagalde.Gestoras
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmCuentasInactivas

    Private _Clientes As List(Of ClienteActivo)
    Private mFiltroView As DataView
    Private mIndex As Byte = 0 'Columna seleccionada
    Private mActiva As String = "CODIGO" ' Nombre columna activa



    Private Function Mostrar() As DataTable
        Dim T As New DataTable("CLIENTES")
        Dim ColNumero As DataColumn = New DataColumn("NUMERO", Type.GetType("System.Int32"))
        Dim ColNombre As DataColumn = New DataColumn("NOMBRE", Type.GetType("System.String"))
        Dim ColDir As DataColumn = New DataColumn("DIRECCION", Type.GetType("System.String"))
        Dim ColTel As DataColumn = New DataColumn("TELEFONO", Type.GetType("System.String"))
        Dim ColCel As DataColumn = New DataColumn("CELULAR", Type.GetType("System.String"))
        Dim ColDoc As DataColumn = New DataColumn("DOCUMENTO", Type.GetType("System.String"))
        T.Columns.Add(ColNumero)
        T.Columns.Add(ColNombre)
        T.Columns.Add(ColDir)
        T.Columns.Add(ColTel)
        T.Columns.Add(ColCel)
        T.Columns.Add(ColDoc)



        For Each C As ClienteActivo In _Clientes
            Dim Row As DataRow = T.NewRow()
            Row.Item("NUMERO") = C.IdCliente
            Row.Item("NOMBRE") = C.Nombre
            Row.Item("DIRECCION") = C.Direccion
            Row.Item("TELEFONO") = C.Telefono
            Row.Item("CELULAR") = C.Celular
            Row.Item("DOCUMENTO") = C.Cedula
            T.Rows.Add(Row)
        Next
        Return T
    End Function

    Private Sub frmCuentasInactivas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Clientes = GCliente.Instance().getClientesInactivos()
        DG.DataSource = Mostrar()
        mFiltroView = Mostrar().DefaultView
    End Sub

  

    Private Sub Filtrar(ByVal xCampo As String, ByVal xDato As String)

    End Sub

    Private Sub DG_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG.ColumnHeaderMouseClick
        mActiva = (sender.Columns(e.ColumnIndex).Name)
        With sender
            .Columns(mIndex).DefaultCellStyle.BackColor = Color.White
            .Columns(e.ColumnIndex).DefaultCellStyle.BackColor = Color.Beige
        End With
        mIndex = e.ColumnIndex
    End Sub


    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            mFiltroView.RowFilter = Filtrar(False)
        End If
        DG.DataSource = mFiltroView
    End Sub

    Public Function Filtrar(ByVal xExacto As Boolean) As String
        If xExacto Then
            Return String.Format("Convert(" & mActiva & ",'System.String') = '{0}'", Me.txtFiltro.Text)
        End If
        Return String.Format("Convert(" & mActiva & ",'System.String') like '%{0}%'", Me.txtFiltro.Text)

    End Function


End Class