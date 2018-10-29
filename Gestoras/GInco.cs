using Aguiñagalde.Entidades;
using Aguiñagalde.FabricaMapper;
using Aguiñagalde.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aguiñagalde.Gestoras
{
    public class GInco
    {
        private static GInco _Instance = null;
        private static IMapperInco SQL;

        public static GInco getInstance()
        {
            if (_Instance == null)
                _Instance = new GInco();
            return _Instance;
        }

        private GInco()
        {
            SQL = (IMapperInco)Factory.getMapper(this.GetType());
        }

        public ClienteInco getByID(string ID, bool xSimple)
        {

            if (ID.Length > 12)
                throw new Exception("No se ecuentra el cliente");

            if (ID.Length < 1)
                throw new Exception("No se ecuentra el cliente");

            if (!Tools.Numeros.IsNumeric(ID))
                throw new Exception("El codigo debe ser solo numeros");

            int IDCliente = -1;





            if (ID.ToString().Length > 5 && ID.ToString().Length < 9)
            {
                if (Tools.Numeros.Cedula(Convert.ToInt32(ID)))
                {
                    IDCliente = SQL.getClienteIDByCedula(ID);
                }
                else
                {
                    throw new Exception("No se ecuentra el cliente");
                }
            }
            else if (ID.Length > 10 && ID.Length < 13)
            {
                IDCliente = SQL.getClienteIDRut(ID);
            }
            else
            {
                IDCliente = Convert.ToInt32(ID);
            }

            if (IDCliente < 1)
                throw new Exception("No se ecuentra el cliente");

            ClienteInco Obj;

            Obj = (ClienteInco)SQL.getSimpleByID(IDCliente);

            if (Obj == null)
            {
                throw new Exception("No se ecuentra el cliente");
            }

            if (!xSimple)
            {
                //obtengo el codigo de forma pago
                Obj.FormaPago = ((FPago)SQL.getFormaPagoByIDCliente(Obj.IdCliente));
                Moneda M = (Moneda)GCobros.getInstance().getMonedaByCliente(IDCliente);

                if (M != null)
                    Obj.Moneda = M;
                else
                    Obj.Moneda = (Moneda)GCobros.getInstance().getMonedaByID(1);

                
                Obj.Tarifa = SQL.getTarifaByCliente(IDCliente);

                //// obtengo sub cuentas
                //Obj.SubCuentas = GCliente.Instance().getSubCuentasByCliente(Obj.IdCliente);
                //// cargo por cada subcuenta los los autorizados
                //foreach (SubCuenta S in Obj.SubCuentas)
                //    if (S.Autorizados == null)
                //        S.Autorizados = getPersonasByCuenta(Obj.IdCliente, S.Codigo);

                //Obj.FecUltimoPago = (DateTime)SQL.getFecUltimoPago(Obj.IdCliente);

                //Obj.FecUltimaCompra = (DateTime)SQL.getFecUltimaCompra(Obj.IdCliente);
                // devuelvo el cliente            
            }


            return Obj;
        }

        public EstadoCuenta GenerarEstadoCuenta(DateTime xFechaDesde, DateTime xFechaHasta, ClienteInco xCliente, int xSubCuenta)
        {
            return (EstadoCuenta)SQL.getEstadoCuenta(xFechaDesde, xFechaHasta, xCliente, xSubCuenta);
        }
    }
}
