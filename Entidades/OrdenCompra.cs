using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class OrdenCompra
    {
        private int _CodCliente;
        private string _Descripcion;
        private string _Numero;
        private int _SubCuenta;
        private DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
        }
        

        public int SubCuenta
        {
            get { return _SubCuenta; }
            set { _SubCuenta = value; }
        }

        public string Numero
        {
            get { return _Numero; }
            set { _Numero = value; }
        }
       
        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }


        public int Cliente
        {
            get { return _CodCliente; }
        }

        public OrdenCompra(int xCodCliente,string xNumOrden)
        {
            _CodCliente = xCodCliente;
            _Numero = xNumOrden;
            _Fecha = DateTime.Now;
        }
    }
}
