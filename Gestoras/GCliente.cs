using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aguiñagalde.Entidades;
using Aguiñagalde.SQL;
using Aguiñagalde.Tools;
using System.Data;
using System.Diagnostics;
using Aguiñagalde.Interfaces;
using Aguiñagalde.FabricaMapper;

namespace Aguiñagalde.Gestoras
{
    public class GCliente
    {
        
        private static IMapperCuentas SQL;

        private DataTable DTClientes;

        public DataTable TablaClientes
        {
           
            get { return DTClientes.Copy(); }
            set { DTClientes = value; }
        }

        private int _TopeMinimo = 1000;


        private GCliente(){

            CargarPredetermindado();
            SetRegion();

        }

        private void SetRegion()
        {
            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ",";
            r.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;
        }

        public DateTime FechaUltimoPago(int idCliente)
        {
            return SQL.getFecUltimoPago(idCliente);
        }

        public void CargarPredetermindado()
        {
            SQL = (IMapperCuentas)Factory.getMapper(this.GetType());
            DTClientes = (DataTable)SQL.ObtenerClientes();
        }

       

        public DataTable DetalleFactura(string xSerie,int xNumero)
        {
            return (DataTable)SQL.DetalleFactura(xSerie, xNumero);
        }

        private static GCliente _Instance = null;

        public static GCliente Instance()
        {
            if (_Instance == null)
                _Instance = new GCliente();
            return _Instance;
        }

        public enum TiposCambio
        {
            Limites = 1,
            Titular = 2,
            Activo = 3,
            Tipo = 4,
            Dic = 5,
            Orden = 6,
            MUnica = 7,
            NoBloquear = 8,
        }

        

        public int addCliente(ClienteActivo C)
        {
            int Numero = -1;

            if(C.Cedula.Length < 1)
                throw new Exception("Debe indicar un numero de documento");

            Numero = ExisteCliente(C.IdCliente.ToString(),C.Cedula);

            if(Numero > 0)
                throw new Exception("El cliente ya existe: " + Numero);

            if (C.Nombre.Length < 4)
                throw new Exception("El nombre ingresado no es valido");

            if (C.Direccion.Length < 1)
                throw new Exception("La direccion ingresada no es valida");

            if (C.Telefono.Length > 0 && !Tools.Numeros.IsNumeric(C.Telefono))
                throw new Exception("El telefono debe ser solo numeros");

            if (C.Celular.Length > 0 && !Tools.Numeros.IsNumeric(C.Celular))
                throw new Exception("El celular debe ser solo numeros");

            if (C.Fax.Length > 0 && !Tools.Numeros.IsNumeric(C.Fax))
                throw new Exception("El fax debe ser solo numeros");

            if (C.Postal.Length > 0 && !Tools.Numeros.IsNumeric(C.Postal))
                throw new Exception("El Cod.Postal debe ser solo numeros");

            if (C.Type < 1 || C.Type > 10)
                throw new Exception("El tipo de cliente no es valido");

            if (C.Cierre < 1)
                C.Cierre = 25;

            if (C.Lineacredito < _TopeMinimo)
                C.Lineacredito = _TopeMinimo; 




            if (C.IdCliente.ToString().Length == 5)
                 SQL.Add(C);

            
            

            if (Tools.Numeros.Cedula(C.IdCliente))
            {
                 SQL.Add(C);
            }
            
            return 0;   
        }

       
        public List<MovimientoGeneral> getPendientesByCliente(int idCliente,bool wCFE)
        {
            return MovimientosPendientes(idCliente,wCFE);
        }

        public decimal getImporteByCliente(int xidCliente, bool wCFE)
        {
            decimal zSuma = 0;
            zSuma   +=  SQL.getSaldo(xidCliente,1);
            zSuma   += SQL.getSaldo(xidCliente, 2) * GCobros.getInstance().Caja.Cotizacion;
            return zSuma;
        }

        public List<ClienteActivo> getClientesParaEC()
        {
            List<ClienteActivo> Lista = new List<ClienteActivo>();
            foreach (ClienteActivo c in SQL.ClientesParaEC())
                Lista.Add((ClienteActivo)c);
            return Lista;

        }


        public int ExisteCliente(string xCodCLiente, string xCedula)
        {
            return SQL.ExisteCliente(xCodCLiente,xCedula);
        }




        public ClienteActivo getByID(string ID,bool xSimple)
        {

            if (ID.Length > 12)
                throw new Exception("No se ecuentra el cliente");

            if (ID.Length < 1)
                throw new Exception("No se ecuentra el cliente");

            if(!Tools.Numeros.IsNumeric(ID))
                throw new Exception("El codigo debe ser solo numeros");



            int IDCliente = -1;
            

            


            if (ID.ToString().Length > 5 && ID.ToString().Length < 9)
            {
                if (Tools.Numeros.Cedula(Convert.ToInt32(ID)))
                {
                    IDCliente = SQL.getClienteIDByCedula(ID);
                }else
                {
                    throw new Exception("No se ecuentra el cliente");
                }
            }else if (ID.Length > 10 && ID.Length < 13)
            {
                IDCliente = SQL.getClienteIDRut(ID);
            }
            else
            {
                 IDCliente = Convert.ToInt32(ID);
            }

            if(IDCliente < 1)
                throw new Exception("No se ecuentra el cliente");

            ClienteActivo Obj;

            Obj = (ClienteActivo)SQL.getSimpleByID(IDCliente);
                 
            if(Obj == null)
            {
                throw new Exception("No se ecuentra el cliente");
            }

            if(Obj.Type == 9)
                if(!GCobros.getInstance().Caja.Usuario.Permiso(7))
                    throw new Exception("no se puede cargar ese tipo de cliente");

            

            
            
            return Obj;
        }

        public List<ClienteActivo> getAll()
        {

            List<ClienteActivo> Lista = new List<ClienteActivo>();



            foreach(object O in SQL.getAll())
            {
                Lista.Add((ClienteActivo)O);

            }
            return Lista;

            //if (Obj == null)
            //{
            //    throw new Exception("No se ecuentra el cliente");
            //}

            //if (Obj.Type == 9)
            //    if (!GCobros.getInstance().Caja.Usuario.Permiso(7))
            //        throw new Exception("no se puede cargar ese tipo de cliente");

            //if (!xSimple)
            //{
            //    //obtengo el codigo de forma pago
            //    Obj.FormaPago = ((FPago)SQL.getFormaPagoByIDCliente(Obj.IdCliente));
            //    Moneda M = (Moneda)GCobros.getInstance().getMonedaByCliente(IDCliente);

            //    if (M != null)
            //        Obj.Moneda = M;
            //    else
            //        Obj.Moneda = (Moneda)GCobros.getInstance().getMonedaByID(1);





            //    Obj.Tarifa = (Tarifa)SQL.getTarifaByCliente(IDCliente);

            //    // obtengo sub cuentas
            //    Obj.SubCuentas = GCliente.Instance().getSubCuentasByCliente(Obj.IdCliente);
            //    // cargo por cada subcuenta los los autorizados
            //    foreach (SubCuenta S in Obj.SubCuentas)
            //        if (S.Autorizados == null)
            //            S.Autorizados = getPersonasByCuenta(Obj.IdCliente, S.Codigo);

            //    Obj.FecUltimoPago = (DateTime)SQL.getFecUltimoPago(Obj.IdCliente);

            //    Obj.FecUltimaCompra = (DateTime)SQL.getFecUltimaCompra(Obj.IdCliente);
            //    // devuelvo el cliente            
            //}


            //return Obj;
        }



        public List<PersonaAutorizada> getPersonasByCuenta(int xTitular,int xSubCuenta)
        {
            List<PersonaAutorizada> LPA = new List<PersonaAutorizada>();
            foreach (object O in SQL.GetListaAutorizados(xTitular, xSubCuenta))
                LPA.Add((PersonaAutorizada)O);
            return LPA;
        }

        public List<ClienteActivo> getClientesInactivos()
        {
            List<ClienteActivo> LC = new List<ClienteActivo>();
            foreach (object Cliente in SQL.getInactivos())
                LC.Add((ClienteActivo)Cliente);
            return LC;
        }

       

        public bool addAsociado(ClienteActivo xTitular, PersonaAutorizada xPersona,List<SubCuenta> xListaCuentas)
        {
            if(!Tools.Numeros.IsNumeric(xPersona.Documento.ToString()))
            {
                throw new Exception("El documento no es valido");
            }
                

            if(xPersona.Documento.ToString().Length != 8)
            {
                throw new Exception("El documento no es valido"); 
            }
            
            List<object> Cuentas = new List<object>();

            foreach (SubCuenta S in xListaCuentas)
            {
                if (!S.Autorizado(xPersona.Documento))
                    Cuentas.Add(S);
                else
                    throw new Exception("El documento ya esta ingresado en esta SubCuenta");
            }
            if (Cuentas.Count > 0)
            {
                SQL.AddAsociado(xTitular, xPersona, Cuentas);
                return true;
            }
            return false;
        }
        public int Actualizar(ClienteActivo xCliente,string xClave)
        {
            ClienteActivo xAnterior = getByID(xCliente.IdCliente.ToString(), true);

            if (xAnterior.Cerrada != xCliente.Cerrada)
                throw new Exception("Usted no tiene permisos para cerrar la cuenta");

            if ((xCliente.Cedula == null || xCliente.Cedula == string.Empty) && (xCliente.Rut == string.Empty || xCliente.Rut == null))
                throw new Exception("Debe indicar una Cedula o un Rut");


            if (!Numeros.IsNumeric(xCliente.Cedula) && xCliente.Cedula.Length > 0)
                throw new Exception("EL DOCUMENTO DEBE SER NUMERICO");

            if (xCliente.Cedula.Length > 0 && xCliente.Cedula.Length < 6 )
                if (Convert.ToInt32(xCliente.Cedula) != xCliente.IdCliente )
                    throw new Exception("CEDULA INVALIDA");

            if (xCliente.Cedula.Length > 6 )
            {
                if (!Numeros.Cedula(Convert.ToInt32(xCliente.Cedula)))
                    throw new Exception("CEDULA INVALIDA");
            } 
       
            if (xCliente.Telefono.Length > 0 && xCliente.Telefono != "0")
            {
                if(xCliente.Telefono.Length != 8)
                    throw new Exception("El telefono no es correcto");
                if(!Numeros.IsNumeric(xCliente.Telefono))
                    throw new Exception("El telefono debe ser solo numeros");
            }

            if (xCliente.Celular.Length > 0 && xCliente.Celular != "0")
            {
                if (xCliente.Celular.Length != 9)
                    throw new Exception("El Celular no es correcto");
                if (!Numeros.IsNumeric(xCliente.Celular))
                    throw new Exception("El Celular debe ser solo numeros");
            }

            if (xCliente.Tarifa == null)
                throw new Exception("Debe seleccionar una tarifa");

            if (xCliente.FormaPago == null)
                throw new Exception("Debe seleccionar una forma de pago");

            if (xCliente.Moneda == null)
                throw new Exception("Debe seleccionar una Moneda");

            if(xCliente.CamposLibres.Email != null && xCliente.CamposLibres.Email.Length > 60)
                throw new Exception("El email es demasiado largo");


            List<object> xListaCambio = new List<object>();

            if (!GEmpresa.getInstance().Clave(xClave) && !GCobros.getInstance().Caja.Usuario.Permiso(5))
            {
                xCliente.IsBloqueo = xAnterior.IsBloqueo;
                xCliente.isMonedaUnica = xAnterior.isMonedaUnica;
                xCliente.isOrden = xAnterior.isOrden;
                xCliente.SoloTitular = xAnterior.SoloTitular;
                SQL.Update(xCliente);
                return 0;
            }
            else
            {
                
                if (xCliente.isActivo != xAnterior.isActivo)
                {
                    string Explicacion = "De " + getBooleanString(xAnterior.isActivo) + " A: " + getBooleanString(xCliente.isActivo);
                    xListaCambio.Add(new Cambio((int)TiposCambio.Activo, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }

                if (xCliente.Lineacredito != xAnterior.Lineacredito || xCliente.Tope != xAnterior.Tope)
                {
                    string Explicacion = "De LCredito,Tope: " + xAnterior.Lineacredito + "," + xAnterior.Tope + " A LCredito,Tope: " + xCliente.Lineacredito + "," + xCliente.Tope;
                    xListaCambio.Add(new Cambio((int)TiposCambio.Limites, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }

                if (xCliente.SoloTitular != xAnterior.SoloTitular)
                {
                    string Explicacion = "De" + xAnterior.SoloTitular + " A:" + xCliente.SoloTitular;
                    xListaCambio.Add(new Cambio((int)TiposCambio.Titular, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }

                if (xCliente.Type != xAnterior.Type)
                {
                    string Explicacion = "De: " + xAnterior.Type + " A: " + xCliente.Type;
                    xListaCambio.Add(new Cambio((int)TiposCambio.Tipo, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }

                if (xCliente.DIC != xAnterior.DIC)
                {
                    string Explicacion = "De: " + xAnterior.DIC + " A: " + xCliente.DIC;
                    xListaCambio.Add(new Cambio((int)TiposCambio.Dic, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }

                if (xCliente.isOrden != xAnterior.isOrden)
                {
                    string Explicacion = "De: " + xAnterior.isOrden + " A: " + xCliente.isOrden;
                    xListaCambio.Add(new Cambio((int)TiposCambio.Orden, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }

                if (xCliente.isMonedaUnica != xAnterior.isMonedaUnica)
                {
                    string Explicacion = "De: " + xAnterior.isMonedaUnica + " A: " + xCliente.isMonedaUnica;
                    xListaCambio.Add(new Cambio((int)TiposCambio.MUnica, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }

                if (xCliente.IsBloqueo != xAnterior.IsBloqueo)
                {
                    string Explicacion = "De: " + xAnterior.IsBloqueo + " A: " + xCliente.IsBloqueo;
                    xListaCambio.Add(new Cambio((int)TiposCambio.NoBloquear, Explicacion, xCliente.IdCliente, Environment.MachineName));
                }


                SQL.GuardarBitacora(xListaCambio, GCobros.getInstance().Caja.Usuario.Nombre);
                SQL.Update(xCliente);
                return 1;

            }
            
        }

       
        private string getBooleanString(bool xVar)
        {
            if (xVar)
                return "Verdadero";
            return "Falso";
        }

        public List<SubCuenta> getSubCuentasByCliente(int xCodCliente)
        {
            List<SubCuenta> LSC = new List<SubCuenta>();
            foreach (object O in SQL.getSubCuentasByCliente(xCodCliente))
                LSC.Add((SubCuenta)O);
            return LSC;
        }

        public void ModificarSubCuenta(SubCuenta xSC)
        {
            if (xSC == null)
                throw new Exception("Debe seleccionar una subcuenta");

            if (xSC.Telefono.Length > 0 && xSC.Telefono != "0")
            {
                if (xSC.Telefono.Length != 8)
                    throw new Exception("El telefono no es correcto");
                if (!Numeros.IsNumeric(xSC.Telefono))
                    throw new Exception("El telefono debe ser solo numeros");
            }

            if (xSC.Rut.Length > 0 && xSC.Telefono != "0")
            {
                if (xSC.Rut.Length < 11 || xSC.Rut.Length > 12)
                    throw new Exception("El rut no es correcto");
                if (!Numeros.IsNumeric(xSC.Rut))
                    throw new Exception("El rut debe ser solo numeros");
            }

            SQL.UpdateSubCuenta(xSC);
        }

        public void AgregarSubCuenta(ClienteActivo xCliente, SubCuenta xSubCuenta)
        {
            if (xCliente.Interno)
                throw new Exception("No se puede agregar una sub cuenta a un C-DIA.");

            if (xSubCuenta.Nombre.Length < 4)
            {
                throw new Exception("El nombre debe ser mas largo");

            }
            if (xSubCuenta.Rut.Length > 0 && xSubCuenta.Rut.Length != 12)
            {
                throw new Exception("El rut debe ser vacio o 12 digitos");

            }
            if (xSubCuenta.Direccion.Length < 5)
            {
                throw new Exception("La direccion ingresada es muy corta");

            }

            if (xSubCuenta.Telefono.Length > 0 && xSubCuenta.Telefono != "0")
            {
                if (xSubCuenta.Telefono.Length != 8)
                    throw new Exception("El telefono no es correcto");
                if (!Numeros.IsNumeric(xSubCuenta.Telefono))
                    throw new Exception("El telefono debe ser solo numeros");
            }

            

             SQL.AddSubCuenta(xSubCuenta);
        }



        public void ModificarAsociado(PersonaAutorizada xPersona, int xTitular)
        {
            SQL.ModificarAsociado(xPersona, xTitular);
        }

        public void AgregarOrden(OrdenCompra xOrden)
        {

            if (xOrden == null)
                throw new Exception("La orden no puede ser nula");

            ClienteActivo Test = GCliente.Instance().getByID(xOrden.Cliente.ToString(), true);

            if (Test == null)
                throw new Exception("No se encuentra el cliente");

            if (xOrden.Numero == string.Empty)
                throw new Exception("Numero de orden no valida");

            if (xOrden.Descripcion == null)
                xOrden.Descripcion = string.Empty;

            SQL.AgregarOrden(xOrden);
        }

        public List<TipoSubCta> TiposCta()
        {
            List<TipoSubCta> L = new List<TipoSubCta>();
            foreach(object O in SQL.getTiposCta())
                L.Add((TipoSubCta)O);
            return L;
        }

        public EstadoCuenta GenerarEstadoCuenta(DateTime xFechaDesde, ClienteActivo xCliente, int xSubCuenta)
        {
            return (EstadoCuenta)SQL.getEstadoCuenta(xFechaDesde, DateTime.Now, xCliente, xSubCuenta);
        }



        public List<object> getLinkCFE(string xSerie, int xNumero)
        {
            List<object> Links;
            if (xSerie.Length < 4 && xSerie != "V")
            {
                Links = SQL.getLinkByCFE(xSerie.ToUpper(), xNumero);
            }
            else
            {
                Links = SQL.getLinkByFactura(xSerie.ToUpper(), xNumero);
            }
            if (Links.Count > 0)
                // foreach (object C in Links)
                //  Process.Start(((CFE)C).Link);
                return Links;
            else
                throw new Exception("La factura no fue emitira electronicamente");
        }


        //try
        //   {
        //       WebClient webClient = new WebClient();
        //       webClient.DownloadFile("http://example.org/data.zip", @"c:/data.zip");
        //   }
        //   catch( Exception ex)
        //   {
        //       System.Console.WriteLine( "Problem: " + ex.Message );
        //   }





        public void RegistrarLlamada(int xIdCLiente,int Campania,string xComentario)
        {
            Usuario U = GCobros.getInstance().Caja.Usuario;
            SQL.GrabarLlamada(xIdCLiente, Campania,U.NombreReal, xComentario);
        }

        public string DatosLlamada(int xCodCliente,int xCampania)
        {
            return SQL.DatosLlamada(xCodCliente, xCampania);
        }

        public List<MovimientoGeneral> MovimientosPendientes(int idCliente,bool wCFE)
        {
            List<MovimientoGeneral> LMP = new List<MovimientoGeneral>();
            foreach (object O in SQL.getMovimientosPendiente(idCliente,wCFE))
                LMP.Add((MovimientoGeneral)O);
            return LMP;
        }



        public void CambiarLimites(ClienteActivo xCliente, decimal xTope, decimal xLimite, string Comentario)
        {
            if (xCliente.DIC)
                throw new Exception("El cliente esta en DIC, no se puede cambiar el limite");
            if (xCliente.Type != 1 && xCliente.Type != 4 && xCliente.Type != 9 && xCliente.Type != 7)
                throw new Exception("El tipo de cliente no permite cambiar el limite");
            if (!xCliente.isActivo)
                throw new Exception("La cuenta esta inactiva.");
            if (xCliente.Interno)
                throw new Exception("No se puede cambiar el limite a este cliente, es C-DIA.");


            Usuario User = GCobros.getInstance().Caja.Usuario;

            string result;

            if (xTope < 1)
                xTope = 1;
            if (xLimite < _TopeMinimo && xCliente.Type!=9) 
                xLimite = _TopeMinimo;

            List<object> xListaCambio = new List<object>();

          

            if (xCliente.Lineacredito != xLimite || xCliente.Tope != xTope)
            {
                string Explicacion = "De LCredito,Tope: " + xCliente.Lineacredito + "," + xCliente.Tope + " A LCredito,Tope: " + xLimite + "," + xTope;
                Cambio C = new Cambio((int)TiposCambio.Limites, Explicacion, xCliente.IdCliente, Environment.MachineName);
                C.Comentario = Comentario;
                xListaCambio.Add(C);
            }
        

            SQL.GuardarBitacora(xListaCambio, GCobros.getInstance().Caja.Usuario.Nombre);
    

            //Retrieve the NetBIOS name. 
            result = System.Environment.MachineName;
            if (User != null)
            {
                 SQL.ModificarLimites(xCliente, xTope, xLimite, Comentario, User.CodUsuario, result);
            }
            else
            {
                 SQL.ModificarLimites(xCliente, xTope, xLimite, Comentario, 1, result);
            }

        }

        public bool PuedoLlamar(int xCliente,int xCampania)
        {
            return SQL.PuedoLlamar(xCliente, xCampania);
        }
    }
}
