using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Factura
    {
        private int _Numero;

        public int Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
        private string _Serie;

        public string Serie
        {
            get { return _Serie; }
            set { _Serie = value; }
        }
        private DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        private List<FacturaLin> _Lineas;

        public List<FacturaLin> Lineas
        {
            get { return _Lineas; }
            set { _Lineas = value; }
        }

        public Factura(int xNumero,string xSerie)
        {
            _Numero = xNumero;
            _Serie = xSerie;
        }

    }
}
