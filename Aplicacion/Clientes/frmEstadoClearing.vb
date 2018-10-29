Imports Aguiñagalde.Entidades





Public Class frmEstadoClearing

    Public Sub New(ByVal InfoC As Clearing, ByVal xDato As String)
        InitializeComponent()
        DataGridView1.DataSource = InfoC.DatosIncumplidos1
        lbnombre.Text = InfoC.Nombre
        lbapellido.Text = InfoC.Apellido
        lbsegundoapellido.Text = InfoC.Segundoapellido
        lbincumplimientos.Text = InfoC.Incumplimientos
        lbcancelaciones.Text = InfoC.Cancelaciones
        lbdireccion.Text = InfoC.Calle
        lbciudad.Text = InfoC.Ciudad
        lbsegundonombre.Text = InfoC.Snombre
        lblRegistro.Text = xDato
    End Sub




    Private Sub Label1_Click_1(sender As Object, e As EventArgs)
        Me.Close()

    End Sub


    Private Sub frmEstadoClearing_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub lbsegundonombre_Click(sender As Object, e As EventArgs) Handles lbsegundonombre.Click

    End Sub
End Class