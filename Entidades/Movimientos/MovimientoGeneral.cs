using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class MovimientoGeneral:Movimiento
    {
        private string _descripcion;
        private int _tipocliente;
        private string _estado;
        private string _origen;
        private byte _Posicion;
        private int _codFormaPago;
        
        private int _subcta;
        private int _codcliente;
        private int _TipoPago;
        private int _FormaPago;
        private Moneda _Moneda;
        private DateTime _fechasaldado;
        private decimal _factormoneda;
        private int _zsaldado;
        private string _cajasaldado;
        private decimal _ImportePagado;
        private string _genApunte;
        private DateTime _FechaVencimiento;
        private string _tipodocumento;
        private int _numeroremesa;
        private decimal _mora;
        private string _sudocumento;
        private CFE _CFE;
        private int _NumeroTipo;
        private int _NumeroDoc;
        private string _SerieDoc;
        private int _codTarifa;
        private DateTime _VencimientoContado;

        #region Propiedades

        public int TipoPago
        {
            get { return _TipoPago; }
            set { _TipoPago = value; }
        }



        public int FormaPago
        {
            get { return _FormaPago; }
            set { _FormaPago = value; }
        }
        

        public int Codcliente
        {
            get { return _codcliente; }
            set { _codcliente = value; }
        }

        public int Subcta
        {
            get { return _subcta; }
            set { _subcta = value; }
        }



        public Moneda Moneda
        {
            get { return _Moneda; }
            set { _Moneda = value; }
        }






        public string SerieDoc
        {
            get { return _SerieDoc; }
            set { _SerieDoc = value; }
        }

        public int NumeroDoc
        {
            get { return _NumeroDoc; }
            set { _NumeroDoc = value; }
        }



        public int NumeroTipo
        {
            get { return _NumeroTipo; }
            set { _NumeroTipo = value; }
        }


        public CFE CFE
        {
            get { return _CFE; }
            set { _CFE = value; }
        }


        public string Sudocumento
        {
            get { return _sudocumento; }
            set { _sudocumento = value; }
        }


        public decimal Mora
        {
            get { return _mora; }
            set { _mora = value; }
        }



        public string Origen
        {
            get { return _origen; }
        }
        public byte Posicion
        {
            get { return _Posicion; }
            set { _Posicion = value; }

        }
        public string Cajasaldado
        {
            get { return _cajasaldado; }
            set { _cajasaldado = value; }
        }
        public int Zsaldado
        {
            get { return _zsaldado; }
            set { _zsaldado = value; }
        }
        public decimal Factormoneda
        {
            get { return _factormoneda; }
            set { _factormoneda = value; }
        }
        public decimal ImportePagado
        {
            get { return _ImportePagado; }
            set { _ImportePagado = value; }
        }
        public DateTime Saldado
        {
            get { return _fechasaldado; }
            set { _fechasaldado = value; }
        }
        public DateTime FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set { _FechaVencimiento = value; }
        }
        public string Tipodocumento
        {
            get { return _tipodocumento; }
            set { _tipodocumento = value; }
        }
        public int Numeroremesa
        {
            get { return _numeroremesa; }
            set { _numeroremesa = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
       
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public string GenApunte
        {
            get { return _genApunte; }
            set { _genApunte = value; }
        }

        public int Tarifa
        {
            get
            {
                return _codTarifa;
            }

            //set
            //{
            //    _codTarifa = value;
            //}
        }

        public DateTime VencimientoContado
        {
            get
            {
                return _VencimientoContado;
            }

            set
            {
                _VencimientoContado = value;
            }
        }

        public int Tipocliente
        {
            get
            {
                return _tipocliente;
            }

            set
            {
                _tipocliente = value;
            }
        }

       
        #endregion

        #region Constructores

        public MovimientoGeneral(int xNumero, string xSerie, string xDescipcion, decimal xImporte, DateTime xFecha, Moneda xMoneda, byte xLinea, string xOrigen, int xTarifa,decimal xCotizacion)
            :base(xNumero,xSerie,xFecha,xLinea, xCotizacion,xImporte)
        {

            _descripcion = xDescipcion;
            _Moneda = xMoneda;
            _Posicion = xLinea;
            _origen = xOrigen;
            _codTarifa = xTarifa;


        }

        public MovimientoGeneral(int xNumero, string xSerie, string xDescipcion, decimal xImporte, DateTime xFecha, Moneda xMoneda, byte xLinea, string xOrigen,decimal xCotizacion)
            : base(xNumero, xSerie,xFecha,xLinea, xCotizacion,xImporte)
        {
            _descripcion = xDescipcion;
            _Moneda = xMoneda;
            _Posicion = xLinea;
            _origen = xOrigen;

        }

       
        #endregion


        #region Metodos

        public decimal getMora()
        {

            if (this._estado == "S")
                return 0;

            if (this.NumeroTipo == 62 || this.NumeroTipo == 18)
                return 0;

            if (this.Importe < 0)
                return 0;


            if (_tipocliente == 9)
                return 0;


            if (this._FechaVencimiento > DateTime.Today)
            {
                return 0;
            }
            if (this.ImportePagado != 0)
            {
                decimal MT = MoraTotal(getDiasVencidos(), _Moneda.Mora, Importe);
                decimal Prorrateo = MT / ((Importe + MT) / this.ImportePagado);
                return decimal.Round(MT / ((Importe + MT) / this.ImportePagado), 2);
            }
            
            return decimal.Round(MoraTotal(getDiasVencidos(), _Moneda.Mora, Importe), 2);
        }

        private static decimal MoraTotal(int xDiasVencidos, decimal xCoefMora, decimal xImporte)
        {
                        return (xCoefMora / 360) * xDiasVencidos * xImporte;
        }


        //public static decimal mMora(int xDias, decimal xImporte, decimal xMonto, Moneda xM)
        //{


        //    if (xImporte < 0)
        //        return 0;

        //    if (xMonto != 0)
        //    {
        //        decimal MT = MoraTotal(xDias, xM.Mora, xImporte);
        //        decimal Prorrateo = MT / ((xImporte + MT) / xMonto);
        //        return decimal.Round(MT / ((xImporte + MT) / xMonto), 2);
        //    }
        //    return decimal.Round(MoraTotal(xDias, xM.Mora, xImporte), 2);
        //}




        public static decimal Descuento(int xDias, decimal xImporte, decimal xMonto, decimal xDescuento, DateTime xFechaContado)
        {
            if (xDias > 0)
                return 0;



            if (xFechaContado < DateTime.Today)
                return 0;

            if ((xDescuento * 100) > 130)
                xDescuento = (125 / 100);

            if (xMonto == (xImporte - Math.Abs(DescuentoTotal(xImporte, xDescuento))))
            {
                return decimal.Round(Math.Abs(DescuentoTotal(xImporte, xDescuento)), 2) * -1;
            }

            if (xMonto == 0 && xImporte > 0)
            {
                return decimal.Round(Math.Abs(DescuentoTotal(xImporte, xDescuento)), 2) * -1;
            }

            if (xMonto > 0)
            {
                decimal DT = Math.Abs(DescuentoTotal(xImporte, xDescuento));
                decimal Coef = xMonto / (xImporte - DT);
                return decimal.Round(Math.Abs(DT * Coef), 2) * -1;
            }
            return 0;
        }



        public decimal getDescuento(decimal xDescuento)
        {

            if (xDescuento < 1)
                return 0;

            if (this._estado == "S")
                return 0;

            if (_codTarifa == 1)
                return 0;

            if (_tipocliente == 9)
                return 0;

            if (this.NumeroTipo == 62 || this.NumeroTipo == 18)
                return 0;

            if (this._FechaVencimiento < DateTime.Today)
                return 0;

            if (VencimientoContado < DateTime.Today)
                return 0;

            return Descuento(getDiasVencidos(), Importe , _ImportePagado, xDescuento, _VencimientoContado);
        }

        private static decimal DescuentoTotal(decimal xImporte, decimal xDescuento)
        {
            return xImporte - (xImporte / (decimal)xDescuento);
        }

        public int getDiasVencidos()
        {
            TimeSpan TS;
            TS = DateTime.Today - this._FechaVencimiento;
            if (TS.Days > 0)
            {
                return Math.Abs(TS.Days);
            }
            return 0;
        }

        private int getDiasFacturados()
        {
            TimeSpan TS;
            TS = DateTime.Today - this.Fecha;
            if (TS.Days > 0)
            {
                return Math.Abs(TS.Days);
            }
            return 0;
        }


        #endregion


        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 0;
            MovimientoGeneral I = (MovimientoGeneral)obj;
            if (I.Fecha < Fecha)
                return 1;
            else if (I.Fecha > Fecha)
                return -1;
            else
                return 0;
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }


    }
}
