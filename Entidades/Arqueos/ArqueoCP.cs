using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Entidades
{
    public class ArqueoCP : Arqueo
    {
        public ArqueoCP(int xNumero, DateTime xFecha, Usuario xUsuario) : base(xNumero, xFecha, xUsuario)
        {

        }

        public ArqueoCP(int xNumero, DateTime xFecha) : base(xNumero, xFecha)
        {

        }
    }
}
