using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class Clearing
    {
        private string _documento;
        private string _nombre;
        private string _snombre;
        private string _apellido;
        private string _segundoapellido;
        private string _codigo;
        private string _civil;
        private string _sexo;
        private int _nacionalidad;
        private int _incumplimientos;
        private int _cancelaciones;
        private string _calle;
        private string _ciudad;

        public string Ciudad
        {
            get { return _ciudad; }
            set { _ciudad = value; }
        }



        public string Snombre
        {
            get { return _snombre; }
            set { _snombre = value; }
        }
      
        private List<ClearinIncumplimiento> DatosIncumplidos;

        public List<ClearinIncumplimiento> DatosIncumplidos1
        {
            get { return DatosIncumplidos; }
            set { DatosIncumplidos = value; }
        }


        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        public int Cancelaciones
        {
            get { return _cancelaciones; }
            set { _cancelaciones = value; }
        }


        public int Incumplimientos
        {
            get { return _incumplimientos; }
            set { _incumplimientos = value; }
        }

        public int Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }
        private string _nacimiento;
        private char _fallecido;

        public char Fallecido
        {
            get { return _fallecido; }
            set { _fallecido = value; }
        }


        public string Nacimiento
        {
            get { return _nacimiento; }
            set { _nacimiento = value; }
        }


        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }


        public string Civil
        {
            get { return _civil; }
            set { _civil = value; }
        }


        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }



        public string Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }
        

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
      

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        

        public string Segundoapellido
        {
            get { return _segundoapellido; }
            set { _segundoapellido = value; }
        }



    }
}
