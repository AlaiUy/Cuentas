Imports System.IO
Imports System.Windows.Forms
Imports System.Xml
Imports Aguiñagalde.Entidades
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.WebServices

Public Class frmOpcionesAdc
    Private _Cliente As ClienteActivo

    Public Sub New(ByVal xCliente As ClienteActivo)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        _Cliente = xCliente
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmOpcionesAdc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub




    Private Sub btnLlamada_Click(sender As Object, e As EventArgs) Handles btnLlamada.Click
        Try
            GTeledata.getInstance.IngresarLlamada(_Cliente, txtComentario.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEC_Click(sender As Object, e As EventArgs) Handles btnEC.Click
        Dim frmEC As New frmEstadoCuenta(_Cliente)
        frmEC.ShowDialog()

    End Sub

    Private Sub frmOpcionesAdc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            txtComentario.Text = GCliente.Instance().DatosLlamada(_Cliente.IdCliente, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClearing_Click(sender As Object, e As EventArgs) Handles btnClearing.Click



        Dim Info As New InfoCred.InfoCredServices()
        Dim docXML As XmlDocument = New XmlDocument()
        Dim settings As New XmlWriterSettings()
        Dim xRuta = "\\servidor\InfoCred"
        settings.Indent = True
        Dim cl As Clearing
        Dim frmC As frmEstadoClearing

        ' Save the document to a file and auto-indent the output.

        Dim nDoc, xTipo As String

        If Not IsNothing(_Cliente.Rut) And (_Cliente.Rut.Length = 12 Or _Cliente.Rut.Length = 11) Then
            nDoc = _Cliente.Rut
            xTipo = "R"
            xRuta = xRuta + "\Empresas\"
        Else
            nDoc = _Cliente.Cedula
            xTipo = "C"
            If Not (Tools.Numeros.Cedula(Convert.ToInt32(nDoc))) Then
                MsgBox("La cedula no se puede verificar", vbOKOnly, "Error")
                Return
            End If
            nDoc = Mid(nDoc, 1, Len(nDoc) - 1)
            xRuta = xRuta + "\Clientes\"
        End If




        Try
            If File.Exists(xRuta + xTipo + nDoc + ".xml") Then

                cl = XMLManager.XMLInfo.getInstance.ObtenerInfoClering(xRuta + xTipo + nDoc + ".xml")
                frmC = New frmEstadoClearing(cl, "Registro guardado en Aguiñagalde" + " El: " + File.GetCreationTime(xRuta + xTipo + nDoc + ".xml"))
                frmC.ShowDialog()
                Return
            End If

            Dim writer As XmlWriter = XmlWriter.Create(xRuta + xTipo + nDoc + ".xml", settings)
            docXML.LoadXml(Info.consultaFichaPFN1("AORTIZ", "ANAO2022", xTipo, nDoc))
            docXML.Save(writer)
            writer.Close()
            cl = XMLManager.XMLInfo.getInstance.ObtenerInfoClering(xRuta + xTipo + nDoc + ".xml")
            frmC = New frmEstadoClearing(cl, "Registro automatico de InfoCred")
            frmC.ShowDialog()
        Catch ex As XmlException
            MsgBox(ex.Message)
        End Try





    End Sub
End Class