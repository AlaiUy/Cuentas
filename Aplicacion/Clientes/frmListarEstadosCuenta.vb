Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes

Public Class frmListarEstadosCuenta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Index As Integer = 0

        Dim Imp As New Impresion()
        Dim Lista As List(Of ClienteActivo) = New List(Of ClienteActivo)
        Dim Lista1 As List(Of ClienteActivo) = New List(Of ClienteActivo)
        Lista = GCliente.Instance.getClientesParaEC()
        Dim Saldo As Decimal = -1
        Lista = Lista.FindAll(Function(x) x.Type = 1 Or x.Type = 5)

        For Each C As ClienteActivo In Lista
            Try
                Dim Fecha As New DateTime(Today.Year, Today.Month - 1, 26)
                Dim UltimoPago As Date = GCliente.Instance().FechaUltimoPago(C.IdCliente)
                'If UltimoPago < Fecha Then
                Saldo = GCliente.Instance().getImporteByCliente(C.IdCliente, False)
                If Saldo > 10 Then
                    If UltimoPago < Fecha Then
                        Try
                            GTeledata.getInstance().IngresarLlamada(C, "Listado Saldo")
                            Index += 1
                            Label1.Text = "Cuentas llamadas: " + Index
                            Application.DoEvents()
                        Catch ex As Exception
                            'MsgBox(ex.Message & " --- " & C.IdCliente)
                        End Try
                    End If

                End If
            Catch ex As Exception
                'MsgBox(ex.Message & " --- " & C.IdCliente)
            End Try
        Next
        MsgBox("Se llamaron a: " & Index & " Clientes", vbOK)

    End Sub

    Private Sub frmListarEstadosCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class