Public Class frmIncobrablesMenu
    Private Sub btnECInco_Click(sender As Object, e As EventArgs) Handles btnECInco.Click
        Dim frmECInco As New frmECIncobrables
        frmECInco.ShowDialog()
    End Sub

    Private Sub btnPasajeInco_Click(sender As Object, e As EventArgs) Handles btnPasajeInco.Click

    End Sub

    Private Sub btnBonifInco_Click(sender As Object, e As EventArgs) Handles btnBonifInco.Click
        Dim frmBon As New frmBonificacionInco
        frmBon.ShowDialog()
    End Sub

End Class