Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras

Public Class frmImprimirFacturas

    Private Sub frmImprimirFacturas_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim Links As List(Of Object) = New List(Of Object)

        Dim WB As WebBrowser

        Dim Serie As String
        Dim Numero As Integer


        Serie = txtSerie.Text.ToUpper
        Numero = Val(txtNumero.Text)
        Try
            Links = GCliente.Instance().getLinkCFE(Serie, Numero)
            If Links.Count > 0 Then
                For Each Link As CFE In Links
                    Dim Tab As TabPage = New TabPage(Link.ToString())
                    WB = New WebBrowser()
                    WB.Navigate(New Uri(Link.Link))

                    Tab.Controls.Add(WB)
                    WB.Dock = DockStyle.Fill
                    TabFacturas.TabPages.Add(Tab)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtNumero_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles txtNumero.KeyDown
        If e.KeyCode = Windows.Forms.Keys.Enter Then
            Dim Serie As String
            Dim Numero As Integer

            Serie = txtSerie.Text
            Numero = Val(txtNumero.Text)
            Try
                GCliente.Instance().getLinkCFE(Serie, Numero)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


End Class