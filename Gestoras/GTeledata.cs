using Aguiñagalde.Entidades;
using Aguiñagalde.FabricaMapper;
using Aguiñagalde.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Gestoras
{
    public class GTeledata
    {
        private static GTeledata _Instance = null;
        private static ImapperTeledata MySQL;

        public static GTeledata getInstance()
        {
            if (_Instance == null)
                _Instance = new GTeledata();
            return _Instance;
        }

        private GTeledata()
        {
            MySQL = (ImapperTeledata)Factory.getMapper(this.GetType());
            SetRegion();
        }

        private void SetRegion()
        {
            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ",";
            r.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;
        }

        public void IngresarLlamada(ClienteActivo xCliente,string xComentario)
        {

            if (xCliente == null)
                throw new Exception("El cliente no puede ser vacio");

            bool Llamar = false;

            if (xCliente.Celular.Length == 9)
                Llamar = true;

            if (xCliente.Telefono.Length == 8)
                Llamar = true;

            if (!Llamar)
                throw new Exception("No hay numero telefonico o celular para llamar");

            if (GCliente.Instance().PuedoLlamar(xCliente.IdCliente, 1))
            {
                string E = "A " + xCliente.Nombre + " ya se lo llamo hoy.";
                throw new Exception(E);
            }
                


            if (MySQL.ExisteCliente(Convert.ToInt32(xCliente.IdCliente),1))
            {
                MySQL.BorrarCliente(Convert.ToInt32(xCliente.IdCliente), 1);
            }

            MySQL.setIngresarLlamada(xCliente,1);

            GCliente.Instance().RegistrarLlamada(xCliente.IdCliente, 1,xComentario);
        }

    }
}
