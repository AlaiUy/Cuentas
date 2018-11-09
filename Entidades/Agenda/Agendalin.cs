using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Agendalin
    {
        private int _codcliente;
        private string _nombre;
        private string _dircobro;
        private DateTime _fuv;
        private decimal _Pesos;
        private decimal _Dolares;
        private string _comentario;

        public int Codcliente
        {
            get
            {
                return _codcliente;
            }

            set
            {
                _codcliente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        public string Dircobro
        {
            get
            {
                return _dircobro;
            }

            set
            {
                _dircobro = value;
            }
        }

        public DateTime Fuv
        {
            get
            {
                return _fuv;
            }

            set
            {
                _fuv = value;
            }
        }

        public decimal Pesos
        {
            get
            {
                return _Pesos;
            }

            set
            {
                _Pesos = value;
            }
        }

        public decimal Dolares
        {
            get
            {
                return _Dolares;
            }

            set
            {
                _Dolares = value;
            }
        }

        public string Comentario
        {
            get
            {
                return _comentario;
            }

            set
            {
                _comentario = value;
            }
        }
    }
}
