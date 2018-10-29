Imports System.Windows.Forms
Imports Aguiñagalde.Gestoras

Public Class frmMenuClientes
    Private _Tipo As Char

    Public Sub New(ByVal xTipo As Char)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        _Tipo = xTipo
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub DibujarForm()
        Select Case _Tipo
            Case "C"
                Dim btnNuevo As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnNuevo", "Crear Cliente", My.Resources.Cuenta)
                AddHandler btnNuevo.Click, AddressOf btnNuevo_click
                AddHandler btnNuevo.MouseHover, AddressOf btnNuevo_mousehover
                Dim btnNuevoAsociado As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnNuevoAsociado", "Asociar Personas", My.Resources.NuevaCuenta)
                AddHandler btnNuevoAsociado.Click, AddressOf btnNuevoAsociado_click
                Dim btnSubCuentaNueva As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnSubCuentaNueva", "Sub Cuenta", My.Resources.Plus)
                AddHandler btnSubCuentaNueva.Click, AddressOf btnSubCuentaNueva_click
                Dim btnEstadoCuenta As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnEstadoCuenta", "Estado Cuenta", My.Resources.EstadoCuenta)
                AddHandler btnEstadoCuenta.Click, AddressOf btnEstadoCuenta_click
                Dim btnModifica As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnModifica", "Modificar Cliente", My.Resources.Modificar)
                AddHandler btnModifica.Click, AddressOf btnModifica_click
                Dim btnLimites As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnLimites", "Modificar Limites", My.Resources.Moneda)
                AddHandler btnLimites.Click, AddressOf btnLimites_click
                Dim btnImprimir As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnImprimir", "Imprimir Factura", My.Resources.printer)
                AddHandler btnImprimir.Click, AddressOf btnImprimir_click
                Dim btnAgendarCobro As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnAgendarCobro", "Agendar Cobro", My.Resources.SearchDocument)
                AddHandler btnAgendarCobro.Click, AddressOf btnAgendarCobro_click
                Dim btnEnvioMail As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnEnvioMail", "Email Masivo", My.Resources.SearchDocument)
                AddHandler btnEnvioMail.Click, AddressOf btnEnvioMail_click

                LayoutMain.Controls.Add(btnEstadoCuenta)
                LayoutMain.Controls.Add(btnSubCuentaNueva)
                LayoutMain.Controls.Add(btnNuevo)
                LayoutMain.Controls.Add(btnNuevoAsociado)
                LayoutMain.Controls.Add(btnModifica)
                LayoutMain.Controls.Add(btnLimites)
                LayoutMain.Controls.Add(btnImprimir)
                LayoutMain.Controls.Add(btnAgendarCobro)
                LayoutMain.Controls.Add(btnEnvioMail)
            Case "D"
                Dim btnBonificacion As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnBonificacion", "Nuev. Bonif.", My.Resources.Bonificacion)
                AddHandler btnBonificacion.Click, AddressOf btnBonificacion_click
                LayoutMain.Controls.Add(btnBonificacion)
                Dim btnOrdenesCompra As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnOrdenesCompra", "Ingresar Orden", My.Resources.Orden)
                AddHandler btnOrdenesCompra.Click, AddressOf btnOrdenesCompra_click
                LayoutMain.Controls.Add(btnOrdenesCompra)
                Dim btnDebito As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnDebito", "Debitar", My.Resources.Debito)
                AddHandler btnDebito.Click, AddressOf btnDebito_click
                LayoutMain.Controls.Add(btnDebito)
                Dim btnBonificacionInco As Button = GControles.GetInstance.CrearBotonLargo(Drawing.Color.White, "btnBonificacion", "Nuev. Bonif. Inco.", My.Resources.warning)
                AddHandler btnBonificacionInco.Click, AddressOf btnBonificacionInco_click
                LayoutMain.Controls.Add(btnBonificacionInco)
                Try
                    If GCobros.getInstance.Caja.Usuario.Nombre = "ALAI" Then
                        Dim BonifXML As Button = GControles.GetInstance.CrearBotonLargo(Drawing.Color.White, "BonifXML", "Nuev. Bonif. XML.", My.Resources.warning)
                        AddHandler BonifXML.Click, AddressOf BonifXML_click
                        LayoutMain.Controls.Add(BonifXML)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                Dim btnEstadosCuenta As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnEstados", "Listar EC", My.Resources.Bonificacion)
                AddHandler btnEstadosCuenta.Click, AddressOf btnEstados_click
                LayoutMain.Controls.Add(btnEstadosCuenta)
            Case "I"
                Dim btnCInactivas As Button = GControles.GetInstance.CrearBoton(Drawing.Color.White, "btnBonificacion", "Nuev. Bonif.", My.Resources.Bonificacion)
                AddHandler btnCInactivas.Click, AddressOf btnCInactivas_click
                LayoutMain.Controls.Add(btnCInactivas)
        End Select






    End Sub

    Private Sub btnEnvioMail_click(sender As Object, e As EventArgs)
        Dim EnvioMasivo As New frmEmailMasivo()
        EnvioMasivo.ShowDialog()
    End Sub

    Private Function btnEstados_click() As Object
        Dim frmAgendaEC As New frmListarEstadosCuenta()
        frmAgendaEC.ShowDialog()
    End Function

    Private Sub btnAgendarCobro_click(sender As Object, e As EventArgs)
        Dim frmAgrendarCobros As New frmAgendaCobros
        frmAgrendarCobros.ShowDialog()
    End Sub

    Private Sub btnBonificacionInco_click(sender As Object, e As EventArgs)
        Dim frmBon As New frmBonificacionInco
        frmBon.ShowDialog()
    End Sub

    Private Sub BonifXML_click(sender As Object, e As EventArgs)
        Dim frmBon As New frmBonifXML
        frmBon.ShowDialog()
    End Sub

    Private Sub frmMenuClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub ClientesMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DibujarForm()


    End Sub


    Private Sub btnNuevo_click(sender As Object, e As EventArgs)
        Dim ClienteNuevo As New frmClienteNuevo
        ClienteNuevo.ShowDialog()

    End Sub

    Private Sub LayoutMain_Paint(sender As Object, e As PaintEventArgs) Handles LayoutMain.Paint

    End Sub

    Private Sub btnNuevoAsociado_click(sender As Object, e As EventArgs)
        Dim Asociar As New frmAsociadosMain
        Asociar.ShowDialog()


    End Sub

    Private Sub btnNuevo_mousehover(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnSubCuentaNueva_click(sender As Object, e As EventArgs)
        Dim SBNueva As New frmCuentasMain
        SBNueva.ShowDialog()
    End Sub





    Private Sub btnEstadoCuenta_click(sender As Object, e As EventArgs)
        Dim var_frmEstadoCuenta As New frmEstadoCuenta
        var_frmEstadoCuenta.ShowDialog()
    End Sub

    Private Sub btnModifica_click(sender As Object, e As EventArgs)
        Dim frModifica As New frmModificaCliente
        frModifica.ShowDialog()
    End Sub

    Private Sub btnLimites_click(sender As Object, e As EventArgs)
        Dim frmLCredito As New frmLimiteCredito
        frmLCredito.ShowDialog()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnImprimir_click(sender As Object, e As EventArgs)
        Try
            Dim Imprimir As New frmImprimirFacturas
            Imprimir.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btnBonificacion_click(sender As Object, e As EventArgs)
        Dim frmBon As New frmBonificacion
        frmBon.ShowDialog()
    End Sub

    Private Sub btnCInactivas_click(sender As Object, e As EventArgs)
        Dim frmInactivas As New frmCuentasInactivas
        frmInactivas.ShowDialog()
    End Sub

    Private Sub btnOrdenesCompra_click(sender As Object, e As EventArgs)
        Dim frmOrdenesCompra As New frmOrdenesCompra
        frmOrdenesCompra.ShowDialog()
    End Sub

    Private Sub btnDebito_click(sender As Object, e As EventArgs)
        Dim frmDeb As New frmDebito
        frmDeb.ShowDialog()
    End Sub

End Class