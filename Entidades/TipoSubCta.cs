using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class TipoSubCta 
    {
        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public TipoSubCta(string xid, string xnombre)
        {
            _codigo = xid;
            _nombre = xnombre;
        }

        public override string ToString()
        {
            return this._nombre;
        }


    }
}
