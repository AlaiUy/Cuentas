
using System;

namespace Aguiñagalde.Entidades
{
    public abstract class Movimiento : IComparable, ICloneable
    {

        private string _Serie;
        private int _Numero;
        private DateTime _Fecha;
        private int _Linea;
        private decimal _Cotizacion;
        private decimal _Importe;

        public string Serie
        {
            get { return _Serie; }

        }





        public int Numero
        {
            get { return _Numero; }

        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
        }

        public int Linea
        {
            get
            {
                return _Linea;
            }

            set
            {
                _Linea = value;
            }
        }

        public decimal Cotizacion
        {
            get
            {
                return _Cotizacion;
            }
        }

        public decimal Importe
        {
            get
            {
                return _Importe;
            }
            set
            {
                _Importe = value;
            }
        }

        public Movimiento(int xNumero, string xSerie, DateTime xFecha, int xLinea, decimal xCotizacion, decimal xImporte)
        {
            _Numero = xNumero;
            _Serie = xSerie;
            _Fecha = xFecha;
            _Linea = xLinea;
            _Cotizacion = xCotizacion;
            _Importe = xImporte;
        }

        public abstract int CompareTo(object obj);
        public abstract object Clone();
    }
}