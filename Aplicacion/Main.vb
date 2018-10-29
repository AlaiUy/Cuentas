Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports System.Configuration
Imports Aguiñagalde.Reportes
Imports System.Xml
Imports System.Threading
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.IO
Imports System.Xml.Linq



Public Class Main
    Private Frases As List(Of String) = New List(Of String)



    Private Sub Main_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            If MsgBox("Desea cerrar el programa", vbOKCancel, "Realmente cerramos?") = MsgBoxResult.Ok Then
                Me.Close()
            End If

        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblFrases.Text = GEmpresa.getInstance.ObtenerFrase()
        CheckForIllegalCrossThreadCalls = False

        If GCobros.getInstance().Caja.Usuario.Permiso(3) Then
            btnCtaDia.Visible = True
            btnCtaDia.Enabled = True
        End If


    End Sub



    Private Sub btnClientes_MouseDown(sender As Object, e As Windows.Forms.MouseEventArgs) Handles btnClientes.MouseDown

    End Sub
    Private Sub btnClientes_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs) Handles btnClientes.MouseMove
        sender.FlatStyle = Windows.Forms.FlatStyle.Standard
    End Sub
    Private Sub btnClientes_MouseLeave(sender As Object, e As EventArgs) Handles btnClientes.MouseLeave
        sender.FlatStyle = Windows.Forms.FlatStyle.Flat
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim fClientesMenu As New frmMenuClientes("C")
        fClientesMenu.TopLevel = False
        fClientesMenu.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PanelCentral.Controls.Add(fClientesMenu)
        fClientesMenu.Show()
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub btnDocs_Click(sender As Object, e As EventArgs) Handles btnDocs.Click
        Dim fClientesMenu As New frmMenuClientes("D")
        fClientesMenu.TopLevel = False
        fClientesMenu.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PanelCentral.Controls.Add(fClientesMenu)
        fClientesMenu.Show()
    End Sub

    Private Sub btnDocs_MouseLeave(sender As Object, e As EventArgs) Handles btnDocs.MouseLeave
        sender.FlatStyle = Windows.Forms.FlatStyle.Flat
    End Sub

    Private Sub btnDocs_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs) Handles btnDocs.MouseMove
        sender.FlatStyle = Windows.Forms.FlatStyle.Standard
    End Sub





    Private Sub btnChangeLog_Click(sender As Object, e As EventArgs) Handles btnChangeLog.Click
        Dim CL As New frmChangeLog()

        CL.ShowDialog()

    End Sub

    Private Sub btnChangeLog_MouseLeave(sender As Object, e As EventArgs) Handles btnChangeLog.MouseLeave
        sender.FlatStyle = Windows.Forms.FlatStyle.Flat
    End Sub

    Private Sub btnChangeLog_MouseMove(sender As Object, e As Windows.Forms.MouseEventArgs) Handles btnChangeLog.MouseMove
        sender.FlatStyle = Windows.Forms.FlatStyle.Standard
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fClientesMenu As New frmMenuClientes("I")
        fClientesMenu.TopLevel = False
        fClientesMenu.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PanelCentral.Controls.Add(fClientesMenu)
        fClientesMenu.Show()
    End Sub

    Private Sub MainHeader_Paint(sender As Object, e As Windows.Forms.PaintEventArgs) Handles MainHeader.Paint

    End Sub

    Private Sub btnCpanel_Click(sender As Object, e As EventArgs) Handles btnCpanel.Click
        Dim frmPanelC As New frmPanelControl
        frmPanelC.TopLevel = False
        frmPanelC.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PanelCentral.Controls.Add(frmPanelC)
        frmPanelC.Show()
    End Sub

    Private Sub btnCpanel_MouseLeave(sender As Object, e As EventArgs) Handles btnCpanel.MouseLeave
        sender.FlatStyle = Windows.Forms.FlatStyle.Flat
    End Sub

    Private Sub btnCpanel_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCpanel.MouseMove
        sender.FlatStyle = Windows.Forms.FlatStyle.Standard
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Dim a As Boolean = True
        'Dim xFile As System.IO.FileStream
        'Dim FileInfo As System.IO.FileInfo = New System.IO.FileInfo("C:\download\BAZA.pdf")

        'While a
        '    If File.Exists("C:\download\BAZA.pdf") Then
        '        Try
        '            xFile = FileInfo.OpenWrite()
        '            a = False
        '            xFile.Close()
        '        Catch ex As Exception
        '            a = True
        '        End Try
        '    End If
        'End While




    End Sub

    Private Sub btnCtaDia_Click(sender As Object, e As EventArgs) Handles btnCtaDia.Click
        Dim fDiaMenu As New frmCtaDiaMenu()

        fDiaMenu.TopLevel = False
        fDiaMenu.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PanelCentral.Controls.Add(fDiaMenu)
        fDiaMenu.Show()
    End Sub

    Private Sub btnIncos_Click(sender As Object, e As EventArgs) Handles btnIncos.Click
        Dim fDiaMenu As New frmIncobrablesMenu()
        fDiaMenu.TopLevel = False
        fDiaMenu.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        PanelCentral.Controls.Add(fDiaMenu)
        fDiaMenu.Show()
    End Sub
End Class