Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmParametros
    Private Sub frmParametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        CargarParametos()
    End Sub

    Private Sub CargarParametos()
        Try
            DGParametros.DataSource = GCobros.getInstance().getParametros()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub






    Private Sub ActualizarParametros()
        Try
            Dim ListaConfig As List(Of Config) = New List(Of Config)


            For Each R As DataGridViewRow In DGParametros.Rows
                If Not IsNothing(R.Cells("ID").Value) Then
                    ListaConfig.Add(New Config(R.Cells("VALOR").Value.ToString(), R.Cells("ID").Value))
                End If

            Next
            'GCobros.getInstance().Caja.EntradaCFE = txtEntrada.Text
            'GCobros.getInstance().Caja.SalidaCFE = txtSalida.Text
            'GCobros.getInstance().Caja.Id = txtCaja.Text
            'GCobros.getInstance().Caja.BackCFE = txtBackXML.Text
            'GCobros.getInstance().Caja.Impresora = txtImpresora.Text
            'GCobros.getInstance().Caja.Imprimir = RBTrue.Checked
            'GCobros.getInstance().Caja.Sucursal = Convert.ToByte(txtSucursal.Text)
            'GCobros.getInstance().Caja.ModificaDescuento = RBDT.Checked
            'GCobros.getInstance().Caja.PlazoDescuento = txtPlazoDescuento.Text
            'GCobros.getInstance().Caja.NumeroDescuento = Convert.ToDecimal(txtNumeroDescuento.Text)
            'GCobros.getInstance().UpdateParameters()
            'MsgBox("Parametros actualizados correctamente", vbOK, "Exito!")
            GCobros.getInstance().UpdateParameters(ListaConfig)
            MsgBox("Exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmParametros_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_Update_Click(sender As Object, e As EventArgs) Handles btn_Update.Click
        ActualizarParametros()
    End Sub
End Class