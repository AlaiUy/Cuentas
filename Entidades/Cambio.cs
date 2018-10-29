using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Cambio
    {
        int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
        }
        string _Explicacion;

        public string Explicacion
        {
            get { return _Explicacion; }
        }
        string _Comentario;

        public string Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }
        DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
        }
        int _Codcliente;

        public int Codcliente
        {
            get { return _Codcliente; }
        }
        string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
        }

        public Cambio(int xCodigo,string xExplicacion,int xCodCliente,string xUsuario)
        {
            _Codigo = xCodigo;
            _Explicacion = xExplicacion;
            _Fecha = DateTime.Now;
            _Codcliente = xCodCliente;
            _Usuario = xUsuario;
        }
    }

    
}
