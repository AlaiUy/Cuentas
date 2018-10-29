Public Class frmMenuClientes
    Private Sub btnEC_Click(sender As Object, e As EventArgs) Handles btnEC.Click
        Dim EstadoCuenta As Form = New frmEC()
        EstadoCuenta.Show()

    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        Dim FormNuevoCliente As Form = New frmClienteNuevo()
        frmClienteNuevo.Show()

    End Sub
End Class