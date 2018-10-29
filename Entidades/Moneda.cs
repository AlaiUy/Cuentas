using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Moneda:IComparable
    {
        private int _codmoneda;
        private string _descripcion; //varchar 20
        private string _iniciales; //varchar 4
        private decimal _Mora;

        public decimal Mora
        {
            get { return _Mora; }
            set { _Mora = value; }
        }


        public int Codmoneda
        {
            get { return _codmoneda; }
          
        }

        
        public string Descripcion
        {
            get { return _descripcion; }
            
        }
        public string Iniciales
        {
            get { return _iniciales; }
            set { _iniciales = value; }
        }

        public Moneda(int xCodmoneda,string xNombre)
        {
            _codmoneda = xCodmoneda;
            _descripcion = xNombre;
        }

        public override string ToString()
        {
            return _iniciales  + " - " + _descripcion;
        }

        public string Subfijo()
        {
            if (_codmoneda == 1)
                return "$";
            return "U$S";
        }

        public string CFESubfijo()
        {
            if (_codmoneda == 1)
                return "UYU";
            return "USD";
        }


        public int CompareTo(object obj)
        {
            if (obj == null)
                return 0;
            Moneda M = (Moneda)obj;
            if (M._codmoneda < this._codmoneda)
                return 1;
            else
                return -1;
        }
    }
}
