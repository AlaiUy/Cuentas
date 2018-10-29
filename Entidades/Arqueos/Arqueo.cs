using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public abstract class Arqueo
    {
        private int _Numero;
        private DateTime _Fecha;
        private Usuario _Usuario;
        private List<object> _Movimientos;

        public List<object> Movimientos
        {
            get
            {
                return _Movimientos;
            }

            set
            {
                _Movimientos = value;
            }
        }

        public Usuario Usuario
        {
            get
            {
                return _Usuario;
            }
            set { _Usuario = value; }
        }

        public int Numero
        {
            get
            {
                return _Numero;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
        }

        public Arqueo(int xNumero, DateTime xFecha,Usuario xUsuario)
        {
            _Numero = xNumero;
            _Fecha = xFecha;
            _Usuario = xUsuario;
        }

        public Arqueo(int xNumero, DateTime xFecha)
        {
            _Numero = xNumero;
            _Fecha = xFecha;
        }

    }
}
