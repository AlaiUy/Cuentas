using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Data;
using System.Globalization;

namespace Aguiñagalde.Entidades
{
    public class EstadoCuenta
    {
        private Persona _Cliente;
        private DateTime _fecha, _hasta;
        private decimal _AnteriorPesos, _DescuentoPesos, _AnteriorDolares, _DescuentoDolares, _VencidoPesos, _VencidoDolares = 0;
        private decimal _PendientePesos;
        private decimal _PendienteDolares;
        private decimal _MoraPesos, _MoraDolares;
        private List<Movimiento> _Movimientos;
        private List<MovimientoGeneral> _AllMovs;
        private DataTable _InformarPesos, _InformarDolares;
        
        private decimal _Cotizacion;


        public decimal DescuentoPesos
        {
            get { return _DescuentoPesos; }

        }


        public decimal DescuentoDolares
        {
            get { return _DescuentoDolares; }

        }



        public decimal Cotizacion
        {
            get { return _Cotizacion; }
            set { _Cotizacion = value; }
        }





        public EstadoCuenta(Persona xCliente, DateTime xFechaDesde, DateTime xFechaHasta, List<Movimiento> xRecibos, List<MovimientoGeneral> xMovimientosPendientes, decimal xSaldoPesos, decimal xSaldoDolares)
        {
            _Cliente = xCliente;
            _Movimientos = new List<Movimiento>();
            _Movimientos = xRecibos;
            _fecha = xFechaDesde;
            _hasta = xFechaHasta;
            _AllMovs = xMovimientosPendientes;
            Pentiente();
            _AnteriorPesos = xSaldoPesos;
            _AnteriorDolares = xSaldoDolares;
            _InformarPesos = Informar(1);
            _InformarDolares = Informar(2);

        }

        public Persona Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }

        public decimal VencidoPesos
        {
            get
            {
                return _VencidoPesos;
            }
        }

        public decimal VencidoDolares
        {
            get
            {
                return _VencidoDolares;
            }

        }

      

        public DataTable getInforme(int xCodMoneda)
        {
            if (xCodMoneda == 1)
                return _InformarPesos;
            return _InformarDolares;
        }

        private DataTable Informar(int xCodMoneda)
        {

            DataTable Table = new DataTable("Facturas");
            DataColumn ColFecha = Table.Columns.Add("Fecha", System.Type.GetType("System.String"));
            DataColumn ColEstado = Table.Columns.Add("Estado", Type.GetType("System.String"));
            DataColumn ColMov = Table.Columns.Add("Movimiento", Type.GetType("System.String"));
            DataColumn ColSer = Table.Columns.Add("Serie", Type.GetType("System.String"));
            DataColumn ColNum = Table.Columns.Add("Numero", Type.GetType("System.Int32"));
            DataColumn ColDebe = Table.Columns.Add("Debe", Type.GetType("System.String"));
            DataColumn ColHaber = Table.Columns.Add("Haber", Type.GetType("System.String"));
            DataColumn ColPesos = Table.Columns.Add("TOTAL", Type.GetType("System.String"));
            
            DataRow RowAnterior;
            RowAnterior = Table.NewRow();
            decimal Total = 0;
            if (xCodMoneda == 1)
            {
                Total = _AnteriorPesos;
                if (Total != 0)
                {
                    RowAnterior["Movimiento"] = "Saldo anterior en pesos...";
                    RowAnterior["TOTAL"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _AnteriorPesos);
                    RowAnterior["Estado"] = " ";
                    Table.Rows.Add(RowAnterior);
                    
                }
            }
            else if (xCodMoneda == 2)
            {
                Total = _AnteriorDolares;
                if (Total != 0)
                {
                    RowAnterior["Movimiento"] = "Saldo anterior en dolares...";
                    RowAnterior["TOTAL"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _AnteriorDolares);
                    RowAnterior["Estado"] = " ";
                    Table.Rows.Add(RowAnterior);
                }
            }
            try
            {
                foreach (MovimientoGeneral M in _Movimientos)
                {
                    if (M.Fecha >= _fecha && M.Fecha <= _hasta.AddHours(23))
                    {
                        if (M.NumeroTipo == 62)
                        {
                          
                        }
                        else
                        {
                            if (M.Moneda.Codmoneda == xCodMoneda)
                            {
                                DataRow RM = Table.NewRow();
                                RM["FECHA"] = M.Fecha.ToString("dd/MM/yyyy");
                                RM["Movimiento"] = M.Descripcion;
                                RM["Serie"] = M.Serie;
                                RM["Numero"] = M.Numero;

                                if (M.Importe < 0 || M.NumeroTipo == 20)
                                    RM["Haber"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", M.Importe);
                                else
                                    RM["Debe"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", M.Importe);
                                Total += M.Importe;
                                RM["TOTAL"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Total);
                                RM["Estado"] = M.Estado;
                                Table.Rows.Add(RM);
                            }
                        }
                    }
                }

                decimal zMora = getMora(xCodMoneda);
                if (zMora > 0)
                {
                    DataRow RMM = Table.NewRow();
                    RMM["FECHA"] = DateTime.Now.ToString("dd/MM/yyyy");
                    RMM["Movimiento"] = "INTERESES";
                    Total += zMora;
                    RMM["Debe"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zMora);
                    RMM["TOTAL"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", Total);

                    Table.Rows.Add(RMM);
                }
            }
            catch(Exception)
            {

            }
            
            return Table;
        }





        public DataTable Impresion()
        {
            DataTable Table = new DataTable("Facturas");
            DataColumn ColFecha = Table.Columns.Add("Fecha", System.Type.GetType("System.String"));
            DataColumn ColMov = Table.Columns.Add("Movimiento", Type.GetType("System.String"));
            DataColumn ColSer = Table.Columns.Add("Serie", Type.GetType("System.String"));
            DataColumn ColNum = Table.Columns.Add("Numero", Type.GetType("System.String"));
            DataColumn ColPesos = Table.Columns.Add("Pesos", Type.GetType("System.String"));
            DataColumn ColDolares = Table.Columns.Add("Dolares", Type.GetType("System.String"));
            DataColumn ColTotalPesos = Table.Columns.Add("Total Pesos", Type.GetType("System.String"));
            DataColumn ColTotalDolares = Table.Columns.Add("Total Dolares", Type.GetType("System.String"));


            DataRow RowAnterior;
            bool Agregar = false;
            //RowAnteriorDolares = Table.NewRow();
            RowAnterior = Table.NewRow();

            /* Agregamos primero el saldo anterior en Pesos y Luego en dolares */


            RowAnterior["Movimiento"] = "Saldo anterior...";
            if (_AnteriorPesos != 0)
            {
                RowAnterior["Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _AnteriorPesos);
                Agregar = true;
                
            }
            if (_AnteriorDolares != 0)
            {
                RowAnterior["Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _AnteriorDolares);
                Agregar = true;
            }

            if(Agregar)
                Table.Rows.Add(RowAnterior);


            decimal zTotalP = _AnteriorPesos, zTotalD = _AnteriorDolares;

            foreach (MovimientoGeneral M in _Movimientos)
            {
                if (M.Fecha >= _fecha)
                {
                    if (M.NumeroTipo == 62)
                    { }
                    else
                    {
                        DataRow RM = Table.NewRow();
                        RM["FECHA"] = M.Fecha.ToString("dd/MM/yyyy");
                        RM["Movimiento"] = M.Descripcion;
                        RM["Serie"] = M.Serie;
                        RM["Numero"] = M.Numero;
                        
                        if (M.Moneda.Codmoneda == 1)
                        {
                            RM["Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", M.Importe);
                            zTotalP += M.Importe;
                            RM["Total Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalP);
                        }
                        else
                        {
                            RM["Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}",M.Importe);
                            zTotalD += M.Importe;
                            RM["Total Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalD);
                            
                        }
                        Table.Rows.Add(RM);
                    }
                }


            }

            decimal zMoraP = getMora(1);
            decimal zMoraD = getMora(2);
            if (zMoraP > 0)
            {
                DataRow RMM = Table.NewRow();
                RMM["FECHA"] = DateTime.Now.ToString("dd/MM/yyyy");
                RMM["Movimiento"] = "INTERESES";
                RMM["Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zMoraP);
                Table.Rows.Add(RMM);
            }
            if (zMoraD > 0)
            {
                DataRow RMM = Table.NewRow();
                RMM["FECHA"] = DateTime.Now.ToString("dd/MM/yyyy");
                RMM["Movimiento"] = "INTERESES";
                RMM["Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zMoraD);
                Table.Rows.Add(RMM);
            }

            return Table;
        }

        public DataTable ImpresionViejo()
        {
            DataTable Table = new DataTable("Movimientos");
            DataColumn ColFecha = Table.Columns.Add("FECHA", System.Type.GetType("System.String"));
            DataColumn ColMov = Table.Columns.Add("MOVIMIENTO", Type.GetType("System.String"));
            DataColumn ColSer = Table.Columns.Add("SERIE", Type.GetType("System.String"));
            DataColumn ColNum = Table.Columns.Add("NUMERO", Type.GetType("System.String"));
            DataColumn ColSub = Table.Columns.Add("SF", Type.GetType("System.String"));
            DataColumn ColDolares = Table.Columns.Add("IMPORTE", Type.GetType("System.String"));
            DataColumn ColTotalPesos = Table.Columns.Add("TOTAL PESOS", Type.GetType("System.String"));
            DataColumn ColTotalDolares = Table.Columns.Add("TOTAL DOLARES", Type.GetType("System.String"));


            DataRow RowAnterior;
            bool Agregar = false;
            //RowAnteriorDolares = Table.NewRow();
            RowAnterior = Table.NewRow();

            /* Agregamos primero el saldo anterior en Pesos y Luego en dolares */


            RowAnterior["Movimiento"] = "Saldo anterior...";
            if (_AnteriorPesos != 0)
            {
                RowAnterior["IMPORTE"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _AnteriorPesos);
                Agregar = true;

            }
            if (_AnteriorDolares != 0)
            {
                RowAnterior["IMPORTE"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", _AnteriorDolares);
                Agregar = true;
            }

            if (Agregar)
                Table.Rows.Add(RowAnterior);


            decimal zTotalP = _AnteriorPesos, zTotalD = _AnteriorDolares;

            foreach (MovimientoGeneral M in _Movimientos)
            {
                if (M.Fecha >= _fecha)
                {
                    if (M.NumeroTipo == 62)
                    { }
                    else
                    {
                        DataRow RM = Table.NewRow();
                        RM["FECHA"] = M.Fecha.ToString("dd/MM/yyyy");
                        RM["Movimiento"] = M.Descripcion;
                        RM["Serie"] = M.Serie;
                        RM["Numero"] = M.Numero;
                        RM["SF"] = M.Moneda.Subfijo();
                        RM["IMPORTE"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", M.Importe);
                        if (M.Moneda.Codmoneda == 1)
                        {
                            zTotalP += M.Importe;
                            RM["Total Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalD);
                            RM["Total Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalP);
                        }
                        else
                        {
                            
                            zTotalD += M.Importe;
                            RM["Total Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalP);
                            RM["Total Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalD);

                        }
                        Table.Rows.Add(RM);
                    }
                }


            }

            

            decimal zMoraP = getMora(1);
            decimal zMoraD = getMora(2);

            if (zMoraP + zMoraD > 0)
            {
                DataRow RLinea = Table.NewRow();
                RLinea["FECHA"] = "_______________________________";
                RLinea["Serie"] = "_______________________________";
                RLinea["Numero"] = "______________________________";
                RLinea["Movimiento"] = "_______________________________";
                RLinea["SF"] = "_______________________________";
                RLinea["IMPORTE"] = "_______________________________";
                RLinea["Total Dolares"] = "_______________________________";
                RLinea["Total Pesos"] = "_______________________________";
                Table.Rows.Add(RLinea);
            }
            
            if (zMoraP > 0)
            {
                zTotalP += zMoraP;
                DataRow RMM = Table.NewRow();
                RMM["FECHA"] = DateTime.Now.ToString("dd/MM/yyyy");
                RMM["Movimiento"] = "INTERESES";
                RMM["SF"] = "$";
                RMM["IMPORTE"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}",zMoraP );
                RMM["Total Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalD);
                RMM["Total Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalP);
                Table.Rows.Add(RMM);
            }
            if (zMoraD > 0)
            {
                zTotalD += zMoraD;
                DataRow RMM = Table.NewRow();
                RMM["FECHA"] = DateTime.Now.ToString("dd/MM/yyyy");
                RMM["Movimiento"] = "INTERESES";
                RMM["SF"] = "U$S";
                RMM["IMPORTE"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zMoraD);
                RMM["Total Pesos"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalP);
                RMM["Total Dolares"] = String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", zTotalD);
                
                Table.Rows.Add(RMM);
            }

            return Table;
        }

        private void Pentiente()
        {
            foreach (MovimientoGeneral M in _AllMovs)
            {
                double Dias = (M.Fecha - DateTime.Now).TotalDays;
                
                if (M.Moneda.Codmoneda == 1)
                {
                    _PendientePesos += M.Importe;
                    _MoraPesos += M.getMora();
                    if (M.FechaVencimiento < DateTime.Now)
                        _VencidoPesos += M.Importe;
                    if (M.VencimientoContado > DateTime.Now)
                        _DescuentoPesos += M.Importe;
                }
                else
                {
                    _PendienteDolares += M.Importe;
                    _MoraDolares += M.getMora();
                    if (M.FechaVencimiento < DateTime.Now)
                        _VencidoDolares += M.Importe;
                    if (M.VencimientoContado > DateTime.Now)
                        _DescuentoDolares += M.Importe;
                }
            }
        }

        public decimal getMora(int xCodmoneda)
        {
            if (xCodmoneda == 1)
                return _MoraPesos;
            return _MoraDolares;
        }

        public decimal Pendiente(int xCodmoneda)
        {
            if (xCodmoneda == 1)
                return _PendientePesos;
            return _PendienteDolares;
        }

        public List<MovimientoGeneral> Pendientes()
        {
            return _AllMovs;
        }

        private class Saldos
        {


        }
    }
}
