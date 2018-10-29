Imports System.Windows.Forms
Imports System.Drawing

Public Class GControles

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property GetInstance As GControles
        Get
            Static Instance As GControles = New GControles
            Return Instance
        End Get
    End Property

    Public Function CrearBoton(ByVal xColor As Color, ByVal xNombre As String, ByVal xTexto As String, Optional xImg As Bitmap = Nothing) As Button
        Dim Boton As New Button
        Boton.Name = xNombre
        Boton.Text = xTexto
        Boton.Margin = New Padding(10)
        Boton.Width = 95
        Boton.Height = 95
        Boton.BackColor = xColor
        Boton.FlatStyle = FlatStyle.Flat
        Boton.FlatAppearance.BorderSize = 0
        Boton.Font = New Font("THAOMA", 12, FontStyle.Bold)
        Boton.Image = xImg
        Boton.TextAlign = ContentAlignment.BottomCenter
        Boton.ImageAlign = ContentAlignment.TopCenter
        Return Boton
    End Function

    Public Function CrearBotonLargo(ByVal xColor As Color, ByVal xNombre As String, ByVal xTexto As String, Optional xImg As Bitmap = Nothing) As Button
        Dim Boton As New Button
        Boton.Name = xNombre
        Boton.Text = xTexto
        Boton.Margin = New Padding(10)

        Boton.Width = 110
        Boton.Height = 90
        Boton.BackColor = xColor
        Boton.FlatStyle = FlatStyle.Flat
        Boton.FlatAppearance.BorderSize = 0
        Boton.Font = New Font("THAOMA", 12, FontStyle.Bold)
        Boton.Image = xImg
        Boton.TextAlign = ContentAlignment.BottomCenter
        Boton.ImageAlign = ContentAlignment.TopCenter
        Return Boton
    End Function

End Class
