using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Tools
{
    public class Texto
    {
        public static string SeparadorMil(string xTexto)
        {
            return string.Format(xTexto, "##,##.00");
        }
    }
}
