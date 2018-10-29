using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class MovimientoCP : Movimiento
    {


        public MovimientoCP(int xNumero, string xSerie,DateTime xFecha,decimal xImporte,int xNumLin,decimal xCotizacion) : base(xNumero, xSerie,xFecha,xNumLin,xCotizacion,xImporte)
        {
 
        }



        public override object Clone()
        {
            throw new NotImplementedException();
        }

        public override int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
