Imports Aguiñagalde.Gestoras

Public Class Main

    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Object) As Integer
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    ' constantes / variables  
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Private frmMostrando As Form = Nothing


    Private Sub PopularFormulario()
        lblDate.Text = " - " + Today.Year.ToString() + " ® - "
        lblBienvenida.Text = "HOLA " + GCobros.getInstance().Caja.Usuario.NombreReal.ToUpper()
        lblfecha.Text = DateTime.Now
        TimerFecha.Interval = 1000
        TimerFecha.Start()
    End Sub


    Private Sub Mover_Formulario(frm As Form)
        ReleaseCapture()
        Dim ret As Integer = SendMessage(frm.Handle.ToInt32, WM_NCLBUTTONDOWN, HTCAPTION, 0)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' pasar el formulario como parámetro  
            Mover_Formulario(Me)
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopularFormulario()
    End Sub

    Private Sub TimerFecha_Tick(sender As Object, e As EventArgs) Handles TimerFecha.Tick
        lblfecha.Text = DateTime.Now
    End Sub

    Private Sub Panel2_KeyDown(sender As Object, e As KeyEventArgs) Handles Panel2.KeyDown

    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("¿Desea cerrar la aplicacion?", vbOKCancel, "Atencion") = MsgBoxResult.Ok Then
                Close()
            End If
        End If
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        If Not IsNothing(frmMostrando) Then
            frmMostrando.Close()
        End If
        frmMostrando = New frmMenuClientes()
        frmMostrando.TopLevel = False
        frmMostrando.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Contenedor.Controls.Add(frmMostrando)
        frmMostrando.Show()
    End Sub
End Class