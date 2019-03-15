using System;

using System.Data;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Aguiñagalde.Entidades;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using Aguiñagalde.Tools;

namespace Aguiñagalde.Reportes
{
    public class Impresion
    {
        public void Imprimir(object xObj, bool xMostar, object xArgs)
        {
            if (xObj == null)
                return;

            if (xObj is Recibo)
            {
                if (xArgs != null && xArgs is Hashtable)
                    ImprimirRecibo(xObj, (Hashtable)xArgs);
                return;
            }

            if (xObj is EstadoCuenta)
            {
                if (xArgs != null)
                {
                    if ((string)xArgs == "PDF")
                    {
                        GenerarPDF(xObj, xMostar);
                        return;
                    }
                        
                }
                
                ImprimirEstadoCuenta(xObj, xMostar);
                return;
            }

          

            if (xObj is Arqueo)
            {
                ImprimirArqueo(xObj, xMostar);
                return;
            }
            if (xObj is Agenda)
            {
                ImprimirAgenda(xObj);
                return;
            }
        }

        public void ImprimirAgenda(object xAgenda)
        {
            Agenda A = (Agenda)xAgenda;
            ReportDocument rptDoc;
            rptDoc = new rpAgenda();
            rptDoc.SetDataSource(A.Impresion());
            frmImpresion frmReport = new Reportes.frmImpresion();
            CrystalReportViewer RP = (CrystalReportViewer)frmReport.Controls["RPViewer"];
            RP.ReportSource = rptDoc;
            frmReport.Show();
        }

        public void ImprimirSaldos(object xObj, bool xMostar, object xArgs)
        {
            if (xObj == null)
                return;

            if (xObj is List<EstadoCuenta>)
            {
                ImpresionSaldos(xObj);
                return;
            }
        }

        private void CargarReportesSaldos(ref ReportDocument xDoc, EstadoCuenta E, int Index)
        {

            TextObject Campo;
            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtCuenta" + Index];
            Campo.Text = E.Cliente.IdCliente.ToString();
            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtNombre" + Index];
            Campo.Text = E.Cliente.Nombre;
            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtDireccion" + Index];
            Campo.Text = E.Cliente.Direccion;

            decimal VPesos = (E.VencidoPesos);
            decimal VDolares = E.VencidoDolares;
            decimal TPesos = (E.Pendiente(1) + E.getMora(1));
            decimal TDolares = (E.Pendiente(2) + E.getMora(2));

            if (TPesos < 0)
                VPesos = 0;
            if (TDolares < 0)
                VDolares = 0;

            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtFecha" + Index];
            Campo.Text = DateTime.Today.ToShortDateString();
            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtVencidoPesos" + Index];
            Campo.Text = FormatearImporte(VPesos);
            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtVencidoDolares" + Index];
            Campo.Text = FormatearImporte(VDolares);
            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtTotalPesos" + Index];
            Campo.Text = FormatearImporte(TPesos);
            Campo = (TextObject)xDoc.ReportDefinition.ReportObjects["txtTotalDolares" + Index];
            Campo.Text = FormatearImporte(TDolares);
        }

        private void ImpresionSaldos(object xEstadoCuenta)
        {
            if (xEstadoCuenta == null)
                return;

            List<EstadoCuenta> Lista = (List<EstadoCuenta>)xEstadoCuenta;



            EstadoCuenta E;

            int Resultado = Lista.Count % 2;
            if (Resultado == 0)
                Resultado = Lista.Count;
            else
                Resultado = Lista.Count - 1;

            ReportDocument rptDoc;
            rptDoc = new repMiniECuenta();
            rptDoc.PrintOptions.PrinterName.ToString();
            //TextObject Campo;
            for (int index = 0; index <= Resultado - 1; index += 2)
            {
                E = Lista[index];

                CargarReportesSaldos(ref rptDoc, E, 1);

                //=======//

                E = Lista[index + 1];
                CargarReportesSaldos(ref rptDoc, E, 2);

                frmImpresion frmReport = new Reportes.frmImpresion();
                CrystalReportViewer RP = (CrystalReportViewer)frmReport.Controls["RPViewer"];
                RP.ReportSource = rptDoc;
                rptDoc.PrintToPrinter(0, false, 0, 0);
            }
            if (Resultado != Lista.Count)
            {
                E = Lista[Lista.Count - 1];
                CargarReportesSaldos(ref rptDoc, E, 1);
                frmImpresion frmReport = new Reportes.frmImpresion();
                CrystalReportViewer RP = (CrystalReportViewer)frmReport.Controls["RPViewer"];
                RP.ReportSource = rptDoc;
                rptDoc.PrintToPrinter(0, false, 0, 0);
            }
        }

        private string FormatearImporte(decimal xImporte)
        {
            if (xImporte < 10)
                return String.Format(CultureInfo.InvariantCulture, "{0:0.00}", xImporte);
            else
                return String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", xImporte);
        }

        private void ImprimirArqueo(object xArqueo, bool xMostrar)
        {
            Arqueo Arq = (Arqueo)xArqueo;

            ReportDocument rptDoc;
            rptDoc = new rpPagosCreditosDias();
            rptDoc.PrintOptions.PrinterName.ToString();
            TextObject Campo;

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtUsuario"];
            Campo.Text = Arq.Usuario.Nombre;
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtZ"];
            Campo.Text = Arq.Numero.ToString();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtFecha"];
            Campo.Text = Arq.Fecha.ToShortDateString();

            if (Arq is ArqueoCP)
                rptDoc.SetDataSource(getMovimientosCP((ArqueoCP)xArqueo));
            //rptDoc.PrintToPrinter(0, false, 0, 0);

            if (xMostrar)
            {

                frmImpresion frmReport = new Reportes.frmImpresion();
                CrystalReportViewer RP = (CrystalReportViewer)frmReport.Controls["RPViewer"];
                RP.ReportSource = rptDoc;
                frmReport.Show();
            }

        }

        private void ImprimirEstadoCuenta(object xEC, bool xMostrar)
        {
            EstadoCuenta EC = (EstadoCuenta)xEC;
            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ".";
            r.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;

            ReportDocument rptDoc;
            rptDoc = new rptEstadoCuentaViejo();
            rptDoc.PrintOptions.PrinterName.ToString();
            TextObject Campo;

            


            DataTable d = EC.ImpresionViejo();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["lblNombre"];
            Campo.Text = string.Format(EC.Cliente.Nombre);
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtCuenta"];
            Campo.Text = string.Format(EC.Cliente.IdCliente.ToString());
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["lblDireccion"];
            Campo.Text = string.Format(EC.Cliente.Direccion);
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["lblTelefono"];
            Campo.Text = string.Format(EC.Cliente.Telefono + "-" + EC.Cliente.Telefono);
            rptDoc.SetDataSource(d);
            if (xMostrar)
            {
                frmImpresion frmReport = new Reportes.frmImpresion();
                CrystalReportViewer RP = (CrystalReportViewer)frmReport.Controls["RPViewer"];
                RP.ReportSource = rptDoc;
                frmReport.Show();
            }
            else
            {
                rptDoc.PrintToPrinter(0, false, 0, 0);
            }
            SetRegion();
            rptDoc.Dispose();
        }
        private void GenerarPDF(object xEC, bool xMostrar)
        {
            EstadoCuenta EC = (EstadoCuenta)xEC;
            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ".";
            r.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;

            ReportDocument rptDoc;
            rptDoc = new rptEstadoCuentaViejo();
            rptDoc.PrintOptions.PrinterName.ToString();
            TextObject Campo;

           

            PDF fPDF = new PDF();
            DataTable d = EC.ImpresionViejo();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["lblNombre"];
            Campo.Text = string.Format(EC.Cliente.Nombre);
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtCuenta"];
            Campo.Text = string.Format(EC.Cliente.IdCliente.ToString());
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["lblDireccion"];
            Campo.Text = string.Format(EC.Cliente.Direccion);
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["lblTelefono"];
            Campo.Text = string.Format(EC.Cliente.Telefono + "-" + EC.Cliente.Telefono);
            rptDoc.SetDataSource(d);
            string Nombre = "C:/EstadosCuentaPDF/" + "EC" + EC.Cliente.IdCliente+".pdf";
            fPDF.ExportToPdfReport(rptDoc, "EC" + EC.Cliente.IdCliente, false);
            rptDoc.Dispose();
            SetRegion();
        }


        private void SetRegion()
        {
            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ",";
            r.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;
        }

        private DataTable getMovimientosCP(ArqueoCP xArqueo)
        {
            DataTable Table = new DataTable("Movimientos");
            DataColumn ColSer = Table.Columns.Add("Serie", Type.GetType("System.String"));
            DataColumn ColFec = Table.Columns.Add("Fecha", Type.GetType("System.String"));
            DataColumn ColNum = Table.Columns.Add("Numero", Type.GetType("System.Int32"));
            DataColumn ColPesos = Table.Columns.Add("Importe", Type.GetType("System.Decimal"));

            if (xArqueo.Movimientos != null)
            {
                foreach (object M in xArqueo.Movimientos)
                {
                    DataRow RM = Table.NewRow();
                    RM["Fecha"] = ((MovimientoCP)M).Fecha.ToShortDateString();
                    RM["Serie"] = ((MovimientoCP)M).Serie;
                    RM["Numero"] = ((MovimientoCP)M).Numero;
                    RM["Importe"] = ((MovimientoCP)M).Importe;
                    Table.Rows.Add(RM);
                }
            }

            return Table;
        }

        public void ImprimirPendientes(EstadoCuenta xEC, bool xMostrar)
        {
            DataTable Table = new DataTable("Facturas");
            DataColumn ColSer = Table.Columns.Add("Serie", Type.GetType("System.String"));
            DataColumn ColFec = Table.Columns.Add("Fecha", Type.GetType("System.String"));
            DataColumn ColNum = Table.Columns.Add("Numero", Type.GetType("System.String"));
            DataColumn ColPesos = Table.Columns.Add("Pesos", Type.GetType("System.Decimal"));
            DataColumn ColDolares = Table.Columns.Add("Dolares", Type.GetType("System.Decimal"));


            foreach (MovimientoGeneral M in xEC.Pendientes())
            {
                DataRow RM = Table.NewRow();
                RM["Fecha"] = M.Fecha.ToShortDateString();
                if (M.Tarifa == 1)
                    RM["Serie"] = M.Serie + "**";
                else
                    RM["Serie"] = M.Serie;
                RM["Numero"] = M.Numero.ToString();
                if (M.Moneda.Codmoneda == 1)
                    RM["Pesos"] = M.Importe;
                else
                    RM["Dolares"] = M.Importe;
                Table.Rows.Add(RM);
            }

            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ".";
            r.NumberFormat.NumberDecimalSeparator = ",";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;

            ReportDocument rptDoc;
            rptDoc = new rptPendientes();
            rptDoc.PrintOptions.PrinterName.ToString();
            TextObject Campo;

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtCuenta"];
            Campo.Text = xEC.Cliente.IdCliente.ToString();

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtNombre"];
            Campo.Text = xEC.Cliente.Nombre.ToString();

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtTotalPesos"];
            Campo.Text = string.Format((xEC.Pendiente(1).ToString()), "##,##.00");

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtTotalDolares"];
            Campo.Text = string.Format((xEC.Pendiente(2).ToString()), "##,##.00");

            rptDoc.SetDataSource(Table);
            if (xMostrar)
            {
                frmImpresion frmReport = new Reportes.frmImpresion();
                CrystalReportViewer RP = (CrystalReportViewer)frmReport.Controls["RPViewer"];
                RP.ReportSource = rptDoc;
                frmReport.Show();
            }
            else
            {
                rptDoc.PrintToPrinter(0, false, 0, 0);
            }

            SetRegion();

        }

        public void ImprimirCredito(string xCedula, string xAutorizacion, decimal xImporte)
        {
            ReportDocument rptDoc;
            rptDoc = new rpCreditodelaCasa();
            rptDoc.PrintOptions.PrinterName.ToString();
            TextObject Campo;

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtDocumento"];
            Campo.Text = xCedula;

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtImporte"];
            Campo.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", xImporte);

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtAut"];
            Campo.Text = xAutorizacion;

            rptDoc.PrintToPrinter(0, false, 0, 0);

        }

        private void ImprimirRecibo(object xRecibo, Hashtable xSaldos)
        {
            Recibo R = (Recibo)xRecibo;
            DataTable Table = new DataTable("Recibo");
            DataColumn ColSer = Table.Columns.Add("Serie", Type.GetType("System.String"));
            DataColumn ColNum = Table.Columns.Add("Numero", Type.GetType("System.String"));
            DataColumn ColPesos = Table.Columns.Add("Importe", Type.GetType("System.Decimal"));

            foreach (object O in R.Movimientos())
            {
                DataRow RM = Table.NewRow();
                RM["Serie"] = ((MovimientoRecibo)O).Serie;
                RM["Numero"] = ((MovimientoRecibo)O).Numero.ToString();
                RM["Importe"] = ((MovimientoRecibo)O).Importe;
                Table.Rows.Add(RM);
            }
            ReportDocument rptDoc;
            rptDoc = new rpRecibo();
            rptDoc.PrintOptions.PrinterName.ToString();
            TextObject Campo;

            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtSerie"];
            Campo.Text = R.Serie;
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtNumero"];
            Campo.Text = R.Numero.ToString();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtNombre"];
            Campo.Text = R.Cliente.Nombre;
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtIdCliente"];
            Campo.Text = R.Cliente.IdCliente.ToString();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtMoneda"];
            Campo.Text = R.DescripcionMoneda();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtFecha"];
            Campo.Text = R.Fecha.ToShortDateString();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["lblSubFijo"];
            Campo.Text = R.SubFijo();
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtSaldoP"];
            Campo.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", xSaldos[1]);
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtSaldoD"];
            Campo.Text = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", xSaldos[2]);
            Campo = (TextObject)rptDoc.ReportDefinition.ReportObjects["txtRut"];
            if (R.Cliente.Rut.Length > 10 && R.Cliente.Rut.Length < 13)
                Campo.Text = R.Cliente.Rut;
            else
                Campo.Text = R.Cliente.Cedula;

            rptDoc.SetDataSource(Table);
            rptDoc.PrintToPrinter(0, false, 0, 0);

        }
    }
}
