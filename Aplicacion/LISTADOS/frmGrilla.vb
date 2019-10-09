Imports System.Data

Public Class frmGrilla
    Private Tabla As DataTable = Nothing

    Public Sub New(ByVal xData As DataTable)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Tabla = xData
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmGrilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsNothing(Tabla) Then
            DataGridView1.DataSource = Tabla
        End If
    End Sub
End Class