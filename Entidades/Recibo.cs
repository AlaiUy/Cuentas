
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Recibo
    {
        private DateTime _Fecha;
        private int _Moneda;
        private List<object> _Lista;
        private Persona _Persona;
        private string _Serie;
        private int _Numero;




        public DateTime Fecha
        {
            get { return _Fecha; }

        }


        public Persona Cliente
        {
            get { return _Persona; }

        }


        public string Serie
        {
            get { return _Serie; }

        }


        public int Numero
        {
            get { return _Numero; }

        }


        public List<object> Lista
        {
            get { return _Lista; }

        }

        public Recibo(DateTime xFecha, Persona xCliente, string xSerie, int xNumero, List<object> xLista, int xM)
        {
            _Fecha = xFecha;
            _Persona = xCliente;
            _Serie = xSerie;
            _Numero = xNumero;
            _Lista = xLista;
            _Moneda = xM;
        }

        public List<object> Movimientos()
        {
            List<object> Lts = new List<object>();
            foreach (object o in _Lista)
            {
                if (((MovimientoRecibo)o).NumeroTipo == 62 || ((MovimientoRecibo)o).NumeroTipo == 5 || ((MovimientoRecibo)o).NumeroTipo == 19 || ((MovimientoRecibo)o).NumeroTipo == 21 || ((MovimientoRecibo)o).NumeroTipo == 23 || ((MovimientoRecibo)o).NumeroTipo == 18)
                    Lts.Add(o);
            }
            return Lts;
        }

        public List<MovimientoRecibo> BM()
        {
            List<MovimientoRecibo> L = new List<MovimientoRecibo>();
            foreach (MovimientoRecibo M in _Lista)
            {
                if (M.NumeroTipo == 21)
                    L.Add(M);
                if (M.NumeroTipo == 19)
                    L.Add(M);
            }
            return L;
        }

        //public decimal Bonificacion()
        //{
        //    decimal zInt = 0;
        //    foreach(Movimiento M in _Lista)
        //    {
        //        if (M.Importe < 0 && M.Serie != _Serie)
        //            zInt += M.Importe;
        //    }
        //    return zInt;
        //}

        public decimal Bonificacion()
        {
            decimal zInt = 0;
            foreach (MovimientoGeneral M in _Lista)
            {
                if (M.NumeroTipo == 21)
                    zInt += M.Importe;
            }
            return zInt;
        }

        public decimal Mora()
        {
            decimal zInt = 0;
            foreach (MovimientoGeneral M in _Lista)
            {
                if (M.NumeroTipo == 19)
                    zInt += M.Importe;
            }
            return zInt;
        }

        public string SubFijo()
        {
            if (_Moneda == 1)
                return "$";
            return "U$S";
        }

        public string DescripcionMoneda()
        {
            if (_Moneda == 1)
                return "Pesos Uruguayos";
            return "Dolares";
        }

        public decimal Importe()
        {
            decimal zImporte = 0;
            foreach (object o in _Lista)
            {
                if (((MovimientoRecibo)o).NumeroTipo == 62 || ((MovimientoRecibo)o).NumeroTipo == 5 || ((MovimientoRecibo)o).NumeroTipo == 19 || ((MovimientoRecibo)o).NumeroTipo == 21 || ((MovimientoRecibo)o).NumeroTipo == 23 || ((MovimientoRecibo)o).NumeroTipo == 18)
                    zImporte += ((MovimientoRecibo)o).Importe;
            }
            return zImporte;
        }
    }
}
