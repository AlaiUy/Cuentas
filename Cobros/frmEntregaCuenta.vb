Imports Aguiñagalde.Entidades
Imports System.Windows.Forms
Imports Aguiñagalde.Gestoras
Imports Aguiñagalde.Reportes

Public Class frmEntregaCuenta

    Private _Cliente As Cliente

    Public Sub New(ByVal xCliente As Cliente)
        InitializeComponent()
        _Cliente = xCliente
    End Sub
    Private Sub frmEntregaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = _Cliente.Nombre
        CargarMonedas(cmbMoneda)
        CargarSubCuentas(cmbSubCuentas)

    End Sub

    Private Sub CargarMonedas(ByVal xCombo As ComboBox)
        For Each M As Moneda In GEmpresa.getInstance.getMonedas()
            xCombo.Items.Add(M)
        Next
        xCombo.SelectedIndex = 0
    End Sub

    Private Sub CargarSubCuentas(ByVal xCombo As ComboBox)
        For Each SC As SubCuenta In _Cliente.SubCuentas
            xCombo.Items.Add(SC)
        Next
        xCombo.SelectedIndex = 0
    End Sub



    Public Function EntregaCuenta(ByVal xMoneda As Integer, ByVal xSubCta As SubCuenta, ByVal xImporte As Decimal) As EntregaCuenta
        Dim D As Decimal = xImporte
        Dim S As String = GEmpresa.getInstance().Caja.EntregaCuenta
        Dim Z As Integer = GEmpresa.getInstance().getNumeroZ()
        Dim M As Moneda = GEmpresa.getInstance().getMonedaByID(xMoneda)
        Dim Caja As String = GEmpresa.getInstance().Caja.Id
        Dim L As List(Of Linea) = New List(Of Linea)
        Dim Linea As Linea = New Linea(100003, "ENTREGA")
        Linea.N = "B"
        Linea.Descripcion = "ENTREGA A CUENTA"
        Linea.Color = "."
        Linea.Talla = "."
        Linea.Iva = 22
        Linea.Unid1 = 1
        Linea.Unid2 = 1
        Linea.Unid3 = 1
        Linea.Unid4 = 1
        Linea.Unidadestotal = 1
        Linea.Precio = D / 1.22
        Linea.Dto = 0
        Linea.Precioiva = Linea.Total()
        Linea.Tipoimpuesto = 1
        Linea.Codtarifa = 10
        Linea.CodAlmacen = "LB"
        Linea.Precioiva = Math.Abs(D)
        Linea.Udsexpansion = -1
        Linea.Expandida = "F"
        Linea.Totalexpansion = D
        Linea.Costeiva = 0
        Linea.Fechaentrega = Today.ToShortDateString
        Linea.Numkgentrega = 0
        Linea.NumLin = L.Count()
        Linea.CodMoneda = 1
        Linea.Serie = S
        L.Add(Linea)
        Dim EC As EntregaCuenta
        EC = New EntregaCuenta(S, Today, M, "C", Z, Caja, 1, 30, _Cliente, L, "F")
        EC.IS = xSubCta
        Return EC
    End Function

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim SubCuenta As SubCuenta = cmbSubCuentas.SelectedItem
        Dim Importe As Decimal = Convert.ToDecimal(txtImporte.Text)
        Dim Moneda As Moneda = cmbMoneda.SelectedItem
        Dim EC As EntregaCuenta = EntregaCuenta(Moneda.Codmoneda, SubCuenta, Importe)
        Dim Num As Integer = GCuentas.Instance().GenerarEntrega(EC)
       
        Dim Imp As New Impresion()
        Dim R As Recibo

        R = GCuentas.Instance().ObtenerReciboByID("VB1X", Num)




        Imp.Imprimir(R)
        'Imp.Imprimir(B)

     
    End Sub
End Class