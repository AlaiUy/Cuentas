using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class ClearinIncumplimiento
    {
        private string _lugar;

        public string Lugar
        {
            get { return _lugar.Trim(); }
            set { _lugar = value; }
        }
        private string _empresa;

        public string Empresa
        {
            get { return _empresa.Trim(); }
            set { _empresa = value; }
        }
        private string _fecha;

        public string Fecha
        {
            get { return _fecha.Trim(); }
            set { _fecha = value; }
        }
        private string _moneda;

        public string Moneda
        {
            get { return _moneda.Trim(); }
            set { _moneda = value; }
        }
        private string _monto;

        public string Monto
        {
            get { return _monto.Trim(); }
            set { _monto = value; }
        }
        private string _compra;

        public string Compra
        {
            get { return _compra.Trim(); }
            set { _compra = value; }
        }

    }
}
