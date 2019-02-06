using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aguiñagalde.Entidades;
using Aguiñagalde.Interfaces;
using Aguiñagalde.FabricaMapper;
using System.Xml;
using System.IO;
using System.Threading;
using Aguiñagalde.XMLManager;
using System.Data;
using Aguiñagalde.Reportes;

namespace Aguiñagalde.Gestoras
{
    public class GCobros : IObservable
    {
        private static GCobros _Instance = null;

        

        private static IMapperCobros DBCobros;

        public static GCobros getInstance()
        {
            if (_Instance == null)
                _Instance = new GCobros();
            return _Instance;
        }



        private List<IObserver> _Observers = new List<IObserver>();
        private string _Comentario = "";
        private List<Moneda> _ListaMonedas;
        private  CajaGeneral _Caja;
        private CajaCtaDia _CajaDia;
        private Empresa Claves;


        public enum Series
        {
            RECIBOS = 20,
            DESCUENTO = 21,
            MORA = 19,
            DEBITO = 23,
            ENTREGA = 62,
            DESCUENTOINCO = 22
        }



        private enum TipoBonificacion
        {
            Comun,
            Incobrable
        };

        public List<Moneda> ListaMonedas
        {
            get { return _ListaMonedas; }
            set { _ListaMonedas = value; }
        }




        public object getFormasPago()
        {
            List<FPago> L = new List<FPago>();
            foreach (object O in DBCobros.getFormasPago())
                L.Add((FPago)O);
            return L;
        }

        public object getTarifasVenta()
        {
            List<Tarifa> L = new List<Tarifa>();
            foreach (object O in DBCobros.getTarifasVenta())
                L.Add((Tarifa)O);
            return L;
        }

        public List<Moneda> getMonedas()
        {
            List<Moneda> L = new List<Moneda>();
            foreach (object O in _ListaMonedas)
                L.Add((Moneda)O);
            return L;
        }

        public CajaGeneral Caja
        {
            get { return _Caja; }
        }

        public CajaCtaDia CajaDia
        {
            get
            {
                return _CajaDia;
            }
        }

        private GCobros()
        {
            DBCobros = (IMapperCobros)Factory.getMapper(this.GetType());
        }

        public Moneda getMonedaByCliente(int xCodCliente)
        {
            return (Moneda)DBCobros.getMonedaByCliente(xCodCliente);
        }

        public Moneda getMonedaByID(int xID)
        {
            foreach (object O in _ListaMonedas)
                if (((Moneda)O).Codmoneda == xID)
                    return (Moneda)O;
            return null;
        }

        public bool Iniciar(string xUsuario, string xPassword)
        {
            notifyObservers("Cargando Base de datos");

            if(DBCobros == null)
                DBCobros = (IMapperCobros)Factory.getMapper(this.GetType());
            
            notifyObservers("Validando Usuario");

            Usuario U = (Usuario)DBCobros.getUsuario(xUsuario, xPassword);

            if (U == null)
                throw new Exception("El usuario no es correcto");

            if (!U.Permiso(1))
                throw new Exception("No puedes usar el programa");

            if (U.Permiso(3))
                _CajaDia = (CajaCtaDia)DBCobros.getCajaDia(Environment.MachineName, U);

            notifyObservers("Cargando Claves");
            
           

            notifyObservers("Cargando Caja");
            _Caja = (CajaGeneral)DBCobros.getCajaByID(Environment.MachineName,U);
            CargarClaves();
            notifyObservers("Cargando Monedas");

            _ListaMonedas = new List<Moneda>();

            foreach (object M in DBCobros.getListaMonedas())
                _ListaMonedas.Add((Moneda)M);

            if (U != null)
                return true;
            return false;
            
        }

        public Usuario getUsuario(string xNombre,string xPassword)
        {
            return (Usuario)DBCobros.getUsuario(xNombre, xPassword); 
        }

        public FPago getFPagoByID(string xID)
        {
            foreach (object O in DBCobros.getFormasPago())
                if (((FPago)O).ID == xID)
                    return (FPago)O;
            return null;
        }

        private void CargarClaves()
        {
            if (_Caja == null)
                throw new Exception("No se puede cargar las clave de empresa");
            Claves = (Empresa)DBCobros.getClavesEmpresa(_Caja.Sucursal);
        }

        public void Register(IObserver xObserver)
        {
            _Observers.Add(xObserver);
        }

        public void UnRegister(IObserver xObserver)
        {
            _Observers.Remove(xObserver);
        }

        public void notifyObservers(object xNotify)
        {
            IObserver Obs;
            foreach (IObserver O in _Observers)
            {
                Obs = (IObserver)O;
                Obs.Update(xNotify);
            }
        }


        public void addAgendaLin(string xCodCLiente, DateTime xFechaVisita,int xCodUsuario,string xDirCobro,string xComentario)
        {
            if (GCliente.Instance().ExisteCliente(xCodCLiente, xCodCLiente) < 1)
                throw new Exception("Debe indicar un cliente");
            if (xDirCobro.Length < 1)
                throw new Exception("Debe indicar un lugar de visita");
            if (xFechaVisita == null)
                throw new Exception("Debe indicar un dia para la visita");
            try
            {
                DBCobros.AgregarAgengaLin(xCodCLiente, xFechaVisita, xCodUsuario, xDirCobro, xComentario);
            }catch(Exception e)
            {
                throw e;
            }
            
        }

        private int CodMoneda(List<MovimientoGeneral> Movs)
        {
            return Movs[0].Moneda.Codmoneda;
        }

        public void SaldarCP(List<object> xLista)
        {
            if (xLista == null)
                throw new Exception("Debe especificar movimientos a saldar");
            if (xLista.Count < 1)
                throw new Exception("Debe especificar movimientos a saldar");

            _CajaDia.Z = DBCobros.getz(CajaDia);
            DBCobros.SaldarCP(xLista, _CajaDia);
            ArqueoCP A = new ArqueoCP(_CajaDia.Z, DateTime.Today, _Caja.Usuario);
            A.Movimientos = xLista;
            ImprimirArqueo(A);
            _CajaDia = (CajaCtaDia)DBCobros.getCajaDia(Environment.MachineName,_CajaDia.Usuario);
        }

        public Agenda getAgenda(DateTime Fecha)
        {
            return (Agenda)DBCobros.getAgenda(Fecha);
        }

        public DataTable getParametros()
        {
            List<int> Configs = new List<int>();
            Configs.Add(10);
            Configs.Add(44);
            Configs.Add(45);
            Configs.Add(43);
            Configs.Add(54);
            Configs.Add(53);
            Configs.Add(46);
            Configs.Add(56);
            Configs.Add(55);
            Configs.Add(57);
            Configs.Add(66);
            return (DataTable)DBCobros.Parametros(Environment.MachineName, Configs);
        }
        
        public void ImprimirArqueo(Arqueo xA)
        {
            if (xA == null)
                throw new Exception("El Arqueo no es valido");
            if (xA.Movimientos.Count < 1)
                throw new Exception("El arqueo no tiene movimientos");

            Impresion Imprimir = new Impresion();
            Imprimir.Imprimir(xA, true,null);
        }

        public ArqueoCP ObtenerArqueoByID(int xIdArqueo,string xCaja)
        {
            ArqueoCP A;
            A = (ArqueoCP)DBCobros.getArqueoByID(xIdArqueo,xCaja);
            if (A == null)
                throw new Exception("No existe el arqueo solicitado");
            A.Usuario = (Usuario)DBCobros.getUsuarioByVendedor(DBCobros.getNumeroUsuarioArqueo(xIdArqueo,xCaja));
            A.Movimientos = DBCobros.getMovimientosByArqueo(A.Numero,xCaja);
            return A;

        }
        
        private bool MismaMoneda(List<MovimientoGeneral> L)
        {
            if (L.Count < 0)
                return false;

            bool Salida = true;
            int Moneda = L[0].Moneda.Codmoneda;

            for (int Index = 1; Index < L.Count - 1; Index++)
                if (L[Index].Moneda.Codmoneda != Moneda)
                    Salida = false;
            return Salida;
        }

        private List<object> Adjudicar(List<MovimientoGeneral> Positivas, List<MovimientoGeneral> Negativas, int xMoneda)
        {
            List<object> Clasificadas = new List<object>();
            decimal Importe = 0;
            foreach (MovimientoGeneral N in Negativas)
            {
                Importe = Math.Abs(N.Importe); // Importe positivo para adjudicar
                int Index = 0; // Contador para ir variando los movimientos positivos
                MovimientoGeneral Saldado;
                MovimientoGeneral Pendiente;
                while (Importe > 0 && Index < Positivas.Count)
                {
                    MovimientoGeneral T = Positivas[Index]; //Tomo el movimiento temporal positivo actual
                    Saldado = (MovimientoGeneral)N.Clone();
                    if (Importe > T.Importe) //El importe de para adjudicar es mayor al movimiento actual.
                    {
                        Saldado.Importe = T.Importe * -1;
                        Importe -= T.Importe;
                    }
                    else if (Importe < T.Importe)
                    {
                        Saldado.Importe = Importe * -1;
                        Pendiente = (MovimientoGeneral)T.Clone();
                        Pendiente.Importe = T.Importe - Importe;
                        Clasificadas.Add(Pendiente);
                        T.Importe = Importe;
                        Importe = 0;
                    }
                    else
                    {
                        Saldado = (MovimientoGeneral)N.Clone();
                        Saldado.Importe = Importe * -1;
                        Importe = 0;
                    }
                    T.Estado = "S";
                    Saldado.Estado = "S";
                    T.NumeroDoc = N.Numero;
                    T.SerieDoc = N.Serie;
                    Saldado.NumeroDoc = N.Numero;
                    Saldado.SerieDoc = N.SerieDoc;
                    T.GenApunte = "SALDADO";
                    Saldado.GenApunte = "SALDADO";
                    if (xMoneda == 1)
                    {
                        Saldado.TipoPago = 1;
                        Saldado.FormaPago = 1;
                        T.TipoPago = 1;
                        T.FormaPago = 1;
                    }
                    else
                    {
                        Saldado.TipoPago = 1;
                        Saldado.FormaPago = 3;
                        T.TipoPago = 1;
                        T.FormaPago = 3;
                    }
                    Saldado.Cajasaldado = _Caja.Id;
                    T.Cajasaldado = _Caja.Id;
                    Saldado.Sudocumento = string.Empty;
                    T.Sudocumento = string.Empty;
                    Clasificadas.Add(Saldado);
                    Clasificadas.Add(T);

                }
                if (Importe > 0 && Clasificadas.Count > 0)
                {
                    Pendiente = (MovimientoGeneral)N.Clone();
                    Pendiente.Importe = Importe * -1;
                    Pendiente.Estado = "P";
                    Pendiente.GenApunte = "VENCIMIENTO";
                }
            }
            return Clasificadas;
        }

        #region Bonificaciones

        public bool Bonificar(List<object> xMovs, ClienteActivo xCliente, Moneda xMoneda, decimal xImporte, SubCuenta xSC, string xComentario, bool xImprimir)
        {
            

            if (xComentario.Length < 1)
                throw new Exception("Hay que escribir un comentario");

            if (xCliente == null)
                throw new Exception("Hay que seleccionar un cliente");
            if (xMoneda == null)
                throw new Exception("Hay que seleccionar una moneda");

            List<object> docs = new List<object>();

            if (xMovs != null && xImporte == 0 && xSC == null)
                docs = Bonificaciones(xMovs, xCliente, xMoneda, xComentario, TipoBonificacion.Comun);


            if (xImporte > 0 && xSC != null)
            {
                decimal cotizacion = 1;
                if (xMoneda.Codmoneda == 2)
                    cotizacion = GCobros.getInstance().Caja.Cotizacion;

                RBonificacion B;
                if (xMovs != null && xMovs.Count > 0)
                    B = (RBonificacion)CrearBonificacion(xImporte, xMoneda, xCliente, xSC, xMovs, cotizacion, xComentario, TipoBonificacion.Comun);
                else
                    B = (RBonificacion)CrearBonificacion(xImporte, xMoneda, xCliente, xSC, null, cotizacion, xComentario, TipoBonificacion.Comun);

                if (B == null)
                    return false;
                docs.Add(B);
            }
            if (docs.Count > 0)
            {
                PrintAndSaveRemitos(docs, xImprimir,-1);
                return true;
            }
            else
            {
                throw new Exception("Algun documento tiene una sub cuenta invalida.");
            }
        }

        public bool BonificarXML(List<object> xMovs, ClienteActivo xCliente, Moneda xMoneda, decimal xImporte, SubCuenta xSC, string xComentario, bool xImprimir, string xSerie, int xNumero)
        {
            


            if (xCliente == null)
                throw new Exception("Hay que seleccionar un cliente");
            if (xMoneda == null)
                throw new Exception("Hay que seleccionar una moneda");

            List<object> docs = new List<object>();

            if (xMovs != null && xImporte == 0 && xSC == null)
                docs = Bonificaciones(xMovs, xCliente, xMoneda, xComentario, TipoBonificacion.Comun);

            RBonificacion B;


            decimal cotizacion = 1;
            if (xMoneda.Codmoneda == 2)
                cotizacion = GCobros.getInstance().Caja.Cotizacion;


            B = (RBonificacion)CrearBonificacion(xImporte, xMoneda, xCliente, xSC, xMovs, cotizacion, xComentario, TipoBonificacion.Comun);
            docs.Add(B);

            if (docs.Count > 0)
            {
                PrintAndSaveRemitos(docs, xImprimir,-1);
                return true;
            }
            else
            {
                throw new Exception("Algun documento tiene una sub cuenta invalida.");
            }
        }

        public decimal getImportePendiente(string xSerie, string xNumero)
        {
           return DBCobros.getImportePendiente(xSerie, xNumero);
        }

        public bool BonificarInco(List<object> xMovs, ClienteActivo xCliente, Moneda xMoneda, decimal xImporte, SubCuenta xSC, string xComentario, bool xImprimir)
        {
            if (xComentario.Length < 1)
                throw new Exception("Hay que escribir un comentario");

            if (xCliente == null)
                throw new Exception("Hay que seleccionar un cliente");
            if (xMoneda == null)
                throw new Exception("Hay que seleccionar una moneda");

            if (xCliente.Type != 7)
                throw new Exception("Este cliente no es incobrable");

            List<object> docs = new List<object>();

            if (xMovs != null && xImporte == 0 && xSC == null)
                docs = Bonificaciones(xMovs, xCliente, xMoneda, xComentario, TipoBonificacion.Incobrable);


            if (xImporte > 0 && xSC != null)
            {
                decimal cotizacion = 1;
                if (xMoneda.Codmoneda == 2)
                    cotizacion = GCobros.getInstance().Caja.Cotizacion;

                RBonificacionInco B;
                if (xMovs != null && xMovs.Count > 0)
                    B = (RBonificacionInco)CrearBonificacion(xImporte, xMoneda, xCliente, xSC, xMovs, cotizacion, xComentario, TipoBonificacion.Incobrable);
                else
                    B = (RBonificacionInco)CrearBonificacion(xImporte, xMoneda, xCliente, xSC, null, cotizacion, xComentario, TipoBonificacion.Incobrable);

                if (B == null)
                    return false;
                docs.Add(B);
            }
            if (docs.Count > 0)
            {
                PrintAndSaveRemitos(docs, xImprimir,-1);
                return true;
            }
            else
            {
                throw new Exception("Algun documento tiene una sub cuenta invalida.");
            }
        }

        #endregion 
        public bool Debitar(decimal xImporte, ClienteActivo xCliente, Moneda xMoneda, SubCuenta SC, string xComentario, bool xImprimir,string xTextoLinea)
        {
            //if (xImporte < 0)
            //    throw new Exception("No se puede realizar un debito con un importe negativo");
            //if (xCliente == null)
            //    throw new Exception("Debe especificar un cliente");
            //if (xMoneda == null)
            //    throw new Exception("Debe indicar una moneda para debitar");
            //if (SC == null)
            //    throw new Exception("Debe indicar una subcuenta");
            //if (xComentario == null || xComentario.Length < 1)
            //    throw new Exception("Debe escribir un comentario");
            //if (xCliente.IdCliente > 59000 && xCliente.IdCliente < 100000)
            //    throw new Exception("No se puede hacer un debito a esta cuenta");


            //List<object> docs = new List<object>();
            //decimal cotizacion = 1;
            //if (xMoneda.Codmoneda == 2)
            //    cotizacion = GCobros.getInstance().Caja.Cotizacion;

            //RMora M = CrearDebito(xImporte, xMoneda, xCliente, SC, xComentario, cotizacion, xTextoLinea);
            //if (M == null)
            //    return false;

            //docs.Add(M);
            //if (docs.Count > 0)
            //{
            //    PrintAndSaveRemitos(docs, xImprimir,true);
            //}
            //else
            //{
            //    throw new Exception("Algun documento tiene una sub cuenta invalida.");
            //}
            //return true;

            if (xImporte < 0)
                throw new Exception("No se puede realizar un debito con un importe negativo");
            if (xCliente == null)
                throw new Exception("Debe especificar un cliente");
            if (xMoneda == null)
                throw new Exception("Debe indicar una moneda para debitar");
            if (SC == null)
                throw new Exception("Debe indicar una subcuenta");
            if (xComentario == null || xComentario.Length < 1)
                throw new Exception("Debe escribir un comentario");
          


            List<object> docs = new List<object>();
            decimal cotizacion = 1;
            if (xMoneda.Codmoneda == 2)
                cotizacion = GCobros.getInstance().Caja.Cotizacion;

            RDebito M = CrearDebito(xImporte, xMoneda, xCliente, SC, xComentario, cotizacion, xTextoLinea);
            if (M == null)
                return false;

            docs.Add(M);
            if (docs.Count > 0)
            {
                PrintAndSaveRemitos(docs, xImprimir, -1);
            }
            else
            {
                throw new Exception("Algun documento tiene una sub cuenta invalida.");
            }
            return true;
        }



        public DataTable ContadosPendientes()
        {
            DataTable T;
            T = (DataTable)DBCobros.getContadosPendientes();
            T.Columns.Add("SELECCIONADA", Type.GetType("System.Int32"));
            return T;
             
        }

        public DataTable DetallePosicion(string xSerie, int xNumero)
        {
            return (DataTable)DBCobros.DetallePosicion(xSerie, xNumero);
        }

        private RDebito CrearDebito(decimal xImporte, Moneda xMoneda, ClienteActivo xCliente, SubCuenta SC, string xComentario, decimal xCotizacion, string xComentarioLinea)
        {
            List<LineaRemito> Lineas = new List<LineaRemito>();
            LineaRemito Linea = new LineaRemito(27118,"8888889");
            string Serie = GCobros.getInstance().Caja.Debito;
            int Z = GCobros.getInstance().Caja.Z;
            string Caja = GCobros.getInstance().Caja.Id;

            int xCodFormaPago, xTipoPago=0;
            if (xMoneda.Codmoneda == 1)
                xCodFormaPago = 2;
            else
                xCodFormaPago = 107;
            xTipoPago = 7;

            Linea.N = 'B';
            Linea.Descripcion = xComentarioLinea;
            Linea.Color = ".";
            Linea.Talla = ".";
            Linea.Iva = 22;
            Linea.Unid1 = 1;
            Linea.Unid2 = 1;
            Linea.Unid3 = 1;
            Linea.Unid4 = 1;
            Linea.Unidadestotal = 1;
            Linea.Precio = xImporte / Convert.ToDecimal(1.22);
            Linea.Dto = 0;
            Linea.Precioiva = Linea.Total();
            Linea.Tipoimpuesto = 1;
            Linea.Codtarifa = 10;
            Linea.CodAlmacen = "LB";
            Linea.Precioiva = xImporte;
            Linea.Udsexpansion = -1;
            Linea.Expandida = 'F';
            Linea.Totalexpansion = xImporte;
            Linea.Costeiva = 0;
            Linea.Fechaentrega = DateTime.Today;
            Linea.Numkgentrega = 0;
            Linea.NumLin = Lineas.Count();
            Linea.CodMoneda = 1;
            Linea.Serie = Serie;
            Lineas.Add(Linea);
            RDebito Mora = new RDebito(Serie, DateTime.Today, xMoneda, Z, Caja, 2, 30, xCliente, Lineas, xComentario, xCodFormaPago, xTipoPago);
            Mora.FactorMoneda = xCotizacion;
            Mora.IS = SC;
            return Mora;
        }



        private void PrintAndSaveRemitos(List<object> xList, bool xImprimir, int xNumRecibo)
        {
            foreach (object o in xList)
            {
                try
                {
                    Remito Re = (Remito)o;
                    Re.Recibo = xNumRecibo;
                    Re.SerieRecibo = _Caja.Recibos;
                    Re.Caja = _Caja.Id;
                    Re.Z = Caja.Z;
                    int NumeroRemito = DBCobros.GenerarRemitos(Re, _Caja.Usuario, Claves,_Caja,xImprimir);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message + " -- " + "Print And Save");
                }
            }
        }

       

    

        public void UpdateParameters(List<Config> xListConfigs)
        {
                DBCobros.UpdateParameters(xListConfigs, Environment.MachineName);
        }





        void IObservable.Register(IObserver xObserver)
        {
            _Observers.Add(xObserver);
        }

        void IObservable.UnRegister(IObserver xObserver)
        {
            _Observers.Remove(xObserver);
        }

        void IObservable.notifyObservers()
        {
            IObserver Obs;
            foreach (IObserver O in _Observers)
            {
                Obs = (IObserver)O;
                Obs.Update(_Comentario);
            }
        }

        void IObservable.notifyObservers(Object Data)
        {
            IObserver Obs;
            foreach (IObserver O in _Observers)
            {
                Obs = (IObserver)O;
                Obs.Update(_Comentario);
            }
        }

        private bool HaveNegative(List<MovimientoGeneral> xMovs)
        {
            foreach (MovimientoGeneral M in xMovs)
                if (M.Importe < Convert.ToDecimal(0.1))
                    return true;
            return false;

        }

        private List<object> Bonificaciones(List<object> xMovs, ClienteActivo xCliente, Moneda xMoneda, string xComentario, TipoBonificacion xTipo)
        {
            if (xMovs.Count < 1)
                return null;

            if (xCliente == null)
                return null;

            decimal zCotizacion;
            if (xMoneda.Codmoneda == 1)
                zCotizacion = 1;
            else
                zCotizacion = GCobros.getInstance().Caja.Cotizacion;
            List<object> Lts = new List<object>();

            if (xTipo == TipoBonificacion.Incobrable && (xCliente.IdCliente > 59000 && xCliente.IdCliente < 100000))
            {
                if (xMovs.Count > 0)
                {
                    decimal zGlobal = 0;
                    List<object> ListaGlobal = new List<object>();
                    foreach (MovimientoGeneral M in xMovs)
                    {
                        zGlobal += M.Importe;
                        ListaGlobal.Add(M);
                    }
                    if (zGlobal > 0)
                    {
                        Lts.Add(CrearBonificacion(zGlobal, xMoneda, xCliente, new SubCuenta(xCliente.IdCliente, 1), ListaGlobal, zCotizacion, xComentario, xTipo));
                    }
                    return Lts;
                }

            }

            foreach (SubCuenta SC in xCliente.SubCuentas)
            {
                decimal zGlobal = 0, zCFE = 0;
                List<object> ListaCFEs = new List<object>();
                List<object> ListaGlobal = new List<object>();
                foreach (MovimientoGeneral M in xMovs)
                {
                    if (M.Subcta == SC.Codigo)
                    {
                        if (M.CFE != null)
                        {
                            zCFE += M.Importe;
                            ListaCFEs.Add(M);
                        }
                        else
                        {
                            zGlobal += M.Importe;
                            ListaGlobal.Add(M);
                        }
                    }
                }
                if (zCFE > 0)
                {
                    Lts.Add(CrearBonificacion(zCFE, xMoneda, xCliente, SC, ListaCFEs, zCotizacion, xComentario, xTipo));
                }
                if (zGlobal > 0)
                {
                    Lts.Add(CrearBonificacion(zGlobal, xMoneda, xCliente, SC, ListaGlobal, zCotizacion, xComentario, xTipo));
                }

            }
            return Lts;
        }

        private Remito CrearBonificacion(decimal xImporte, Moneda xMoneda, ClienteActivo xCliente, SubCuenta xSubCuenta, List<object> xMovs, decimal xFactorMoneda, string xComentario, TipoBonificacion xTipo)
        {
            string Serie = "";
            int Z = GCobros.getInstance().Caja.Z;
            string Caja = GCobros.getInstance().Caja.Id;

            List <LineaRemito> Lineas = new List<LineaRemito>();
            LineaRemito Linea = null;
            switch (xTipo)
            {
                case TipoBonificacion.Comun:
                    Serie = GCobros.getInstance().Caja.SerieDescuento;
                    Linea = new LineaRemito(100001, "DESCUENTO");
                    Linea.Descripcion = "AJUSTE PRECIOS POR BONIF. ";
                    break;
                case TipoBonificacion.Incobrable:
                    Serie = GCobros.getInstance().Caja.DescuentoInco;
                    Linea = new LineaRemito(1311, "INCOBRABLE");
                    Linea.Descripcion = "SALDO INCOBRABLE.";
                    break;
            }
            Linea.N = 'B';
            Linea.Color = ".";
            Linea.Talla = ".";
            Linea.Iva = 22;
            Linea.Unid1 = -1;
            Linea.Unid2 = 1;
            Linea.Unid3 = 1;
            Linea.Unid4 = 1;
            Linea.Unidadestotal = -1;
            Linea.Precio = xImporte / Convert.ToDecimal(1.22);
            Linea.Dto = 0;
            Linea.Tipoimpuesto = 1;
            Linea.Codtarifa = 2;
            Linea.CodAlmacen = "LB";
            Linea.Precioiva = Math.Abs(xImporte);
            Linea.Udsexpansion = -1;
            Linea.Expandida = 'F';
            Linea.Totalexpansion = xImporte;
            Linea.Costeiva = 0;
            Linea.Fechaentrega = DateTime.Today;
            Linea.Numkgentrega = 0;
            Linea.NumLin = Lineas.Count() + 1;
            Linea.CodMoneda = 1;
            Linea.Serie = Serie;
            Lineas.Add(Linea);
            //22
            Remito R = null;
            switch (xTipo)
            {
                case TipoBonificacion.Comun:
                    R = new RBonificacion(Serie, DateTime.Today, xMoneda, Z, Caja, 2, _Caja.Usuario.CodVendedor, xCliente, Lineas, xComentario);
                    break;
                case TipoBonificacion.Incobrable:
                    R = new RBonificacionInco(Serie, DateTime.Today, xMoneda, Z, Caja, 2, _Caja.Usuario.CodVendedor, xCliente, Lineas,  xComentario);
                    break;
            }

            R.AgregarMovimientos(xMovs);
            if (xSubCuenta != null)
                R.IS = xSubCuenta;
            else
                R.IS = new SubCuenta(xCliente.IdCliente, 1);
            R.FactorMoneda = xFactorMoneda;

            return R;
        }

        public void CambiarCalve(Usuario xUsuario)
        {
            if (xUsuario == null)
                return;

            if (xUsuario.Password.Length < 4)
                throw new Exception("La contraseña es demasiado corta");

            DBCobros.CambiarClaveUsuario(xUsuario.CodUsuario, xUsuario.Password);

        }

    }
}
