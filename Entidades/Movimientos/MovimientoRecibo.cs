using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class MovimientoRecibo : Movimiento, IEnumerable
    {

        private int _NumeroTipo;

        public int NumeroTipo
        {
            get
            {
                return _NumeroTipo;
            }
        }

        public MovimientoRecibo(int xNumero, string xSerie, DateTime xFecha, int xLinea, decimal xCotizacion, int xNumeroTipo, decimal xImporte) : base(xNumero, xSerie, xFecha, xLinea, xCotizacion, xImporte)
        {
            _NumeroTipo = xNumeroTipo;
        }

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
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
