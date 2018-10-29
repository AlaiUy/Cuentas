using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using Aguiñagalde.Entidades;
using Aguiñagalde.Tools;
using System.Data.SqlTypes;
using Aguiñagalde.Interfaces;



namespace Aguiñagalde.SQL
{
    public class CuentasMapper : DataAccess, IMapperCuentas
    {

        #region Principales

        private List<object> _Monedas = (new CobrosMapper()).ListaMonedas;


        public CuentasMapper()
        {
           
        }

        #endregion

        public void AddAsociado(object xTitular, object xPersona, List<object> Autorizadas)
        {
            
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    try
                    {
                        foreach (SubCuenta S in Autorizadas)
                            AgregarAsociado((PersonaAutorizada)xPersona, ((ClienteActivo)xTitular).IdCliente, S.Codigo, Con, Tran);
                        Tran.Commit();
                    }
                    catch (Exception E)
                    {
                        Tran.Rollback();
                        throw E;
                    }
                }

            }
        }
        public void Add(object xObj)
        {

            int Guardo = 0;
            List<IDataParameter> Lista = new List<IDataParameter>();
            ClienteActivo Obj = (ClienteActivo)xObj;
            Tarifa _Tarifa = new Tarifa();
            _Tarifa = (new CobrosMapper()).getTarifaByID(Obj.Tarifa.ID);

            #region ParametersCliente

            /* +++ Parametros tabla clientes +++ */
            Lista.Add(new SqlParameter("@CODCLIENTE", Obj.IdCliente));
            Lista.Add(new SqlParameter("@CEDULA", Obj.Cedula));
            Lista.Add(new SqlParameter("@CODCONTABLE", Obj.CodContable()));
            Lista.Add(new SqlParameter("@NOMBRE", Obj.Nombre.ToUpper()));
            Lista.Add(new SqlParameter("@NOMBRECOMERCIAL", Obj.NombreComercial.ToUpper()));
            Lista.Add(new SqlParameter("@LINEACREDITO", Obj.Lineacredito));
            Lista.Add(new SqlParameter("@OBSERVACIONES", Obj.Observaciones.ToUpper()));
            Lista.Add(new SqlParameter("@PAIS", Obj.Pais.ToUpper()));
            Lista.Add(new SqlParameter("@POSTAL", Obj.Postal));
            Lista.Add(new SqlParameter("@RUT", Obj.Rut));
            Lista.Add(new SqlParameter("@TELEFONO", Obj.Telefono));
            Lista.Add(new SqlParameter("@TOPE", Obj.Tope));
            Lista.Add(new SqlParameter("@TIPO", Obj.Type));
            Lista.Add(new SqlParameter("@FAX", Obj.Fax));
            Lista.Add(new SqlParameter("@DPTO", Obj.Dpto));
            Lista.Add(new SqlParameter("@DIRECCION", Obj.Direccion.ToUpper()));
            Lista.Add(new SqlParameter("@DIRECCIONALTERNARIVA", Obj.DireccionAlternativa.ToUpper()));
            Lista.Add(new SqlParameter("@COBRADOR", Obj.Cobrador));
            Lista.Add(new SqlParameter("@CIERRE", Obj.Cierre));
            Lista.Add(new SqlParameter("@CELULAR", Obj.Celular));
            Lista.Add(new SqlParameter("@DESCATALOGADO", setDBoolean(Obj.Descatalogado)));
            Lista.Add(new SqlParameter("@CODMONEDA", Obj.Moneda.Codmoneda));
            Lista.Add(new SqlParameter("@TITULAR", setDBoolean(Obj.SoloTitular)));
            Lista.Add(new SqlParameter("@CDIA", setDBoolean(Obj.isActivoDia)));
            Lista.Add(new SqlParameter("@FIDELIZADO", setDBoolean(Obj.isFidelizado)));
            Lista.Add(new SqlParameter("@BLOQUEO", setDBoolean(Obj.IsBloqueo)));
            Lista.Add(new SqlParameter("@ACTIVO", setDBoolean(true)));
            Lista.Add(new SqlParameter("@MONEDA", setDBoolean(Obj.isMonedaUnica)));
            Lista.Add(new SqlParameter("@ORDEN", setDBoolean(Obj.isOrden)));
            Lista.Add(new SqlParameter("@RUTA", Obj.Ruta));


            /*++++ fin patametros tabla clientes ++++ */

            /* +++ parametros para tabla camposlibres +++ */
            Lista.Add(new SqlParameter("@INGRESOS", Obj.CamposLibres.Ingresos));
            Lista.Add(new SqlParameter("@VEHICULOS", Obj.CamposLibres.Vehiculos.ToUpper()));
            Lista.Add(new SqlParameter("@CCARGO", Obj.CamposLibres.ConyugeCargo.ToUpper()));
            Lista.Add(new SqlParameter("@CANTIGUEDAD", Obj.CamposLibres.ConyugeAntiguedad.ToUpper()));
            Lista.Add(new SqlParameter("@OOBSERVACIONES", Obj.CamposLibres.OtrasObservaciones));
            Lista.Add(new SqlParameter("@PLASTICOS", Obj.CamposLibres.Plasticos.ToUpper()));
            Lista.Add(new SqlParameter("@EMAIL", Obj.CamposLibres.Email.ToUpper()));
            Lista.Add(new SqlParameter("@CINGRESOS", Obj.CamposLibres.ConyugeIngresos));
            Lista.Add(new SqlParameter("@CACTIVIDAD", Obj.CamposLibres.ConyugeActividad.ToUpper()));
            Lista.Add(new SqlParameter("@COMERCIALES", Obj.CamposLibres.Comerciales.ToUpper()));
            Lista.Add(new SqlParameter("@CIVIL", Obj.CamposLibres.Civil.ToUpper()));
            Lista.Add(new SqlParameter("@CARGO", Obj.CamposLibres.Cargo.ToUpper()));
            Lista.Add(new SqlParameter("@BIENES", Obj.CamposLibres.Bienes.ToUpper()));
            Lista.Add(new SqlParameter("@ANTIGUEDAD", Obj.CamposLibres.Antiguedad.ToUpper()));
            Lista.Add(new SqlParameter("@ALQUILER", Obj.CamposLibres.Alquiler.ToUpper()));
            Lista.Add(new SqlParameter("@ACTIVIDAD", Obj.CamposLibres.Actividad.ToUpper()));
            Lista.Add(new SqlParameter("@CONYUGE", Obj.CamposLibres.Conyuge.ToUpper()));
            Lista.Add(new SqlParameter("@APERTURA", DateTime.Now.ToShortDateString()));
            Lista.Add(new SqlParameter("@TARIFA", _Tarifa.ID));
            Lista.Add(new SqlParameter("@TARIFANOMBRE", _Tarifa.Nombre.ToUpper()));
            Lista.Add(new SqlParameter("@FPAGO", Obj.FormaPago.ID));

            /* +++ fin parametros campos libres +++ */
            #endregion

            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    try
                    {
                        SqlCommand Command = new SqlCommand("", Con);
                        Command.Transaction = Tran;
                        string Query = "SET ansi_warnings OFF; ";
                        Query = Query + "INSERT INTO CLIENTES(CODCLIENTE,CODCONTABLE,NOMBRECLIENTE,NOMBRECOMERCIAL,CIF,TELEFONO1,TELEFONO2,PAIS,PROVINCIA,ZONA,CODPOSTAL,DIRECCION1,DIRECCION2,TIPO,RIESGOCONCEDIDO,LCREDITO,DIAPAGO1,OBSERVACIONES,DESCATALOGADO,FAX,CODMONEDA,SOLOTITULAR,SOLOCONORDEN,FIDELIZADO,ACTIVOCDIA,NOBLOQUEAR,NUMTARJETA,TIPOINTERNO,ALIAS) VALUES (@CODCLIENTE,@CODCONTABLE,@NOMBRE,@NOMBRECOMERCIAL,@RUT,@TELEFONO,@CELULAR,@PAIS,@DPTO,@COBRADOR,@POSTAL,@DIRECCION,@DIRECCIONALTERNARIVA,@TIPO,@TOPE,@LINEACREDITO,@CIERRE,@OBSERVACIONES,@DESCATALOGADO,@FAX,@CODMONEDA,@TITULAR,@ORDEN,@FIDELIZADO,@CDIA,@BLOQUEO,@RUTA,'F',@CEDULA)";
                        Command.CommandText = Query;
                        Guardo = ExecuteNonQuery(Command, Lista);
                        Query = "SET ansi_warnings OFF; ";
                        Query = Query + "UPDATE CLIENTESCAMPOSLIBRES SET ACTIVIDAD=@ACTIVIDAD,INGRESOS=@INGRESOS,CARGO=@CARGO,ESTADO_CIVIL=@CIVIL,CONYUGE=@CONYUGE,ACTIVIDAD1=@CACTIVIDAD,INGRESOS1=@CINGRESOS,ALQUILER=@ALQUILER,BIENES=@BIENES,VEHICULOS=@VEHICULOS,TARJ_CREDITO=@PLASTICOS,REF_COMERCIALES=@COMERCIALES,OBSERVACIONES_=@OBSERVACIONES,OBSERVACIONES1=@OOBSERVACIONES,MAIL=@EMAIL,FECHA_APERTURA=@APERTURA WHERE CODCLIENTE = @CODCLIENTE";
                        Command.CommandText = Query;
                        Guardo = ExecuteNonQuery(Command);
                        Query = "INSERT INTO TARIFASCLIENTE(CODCLIENTE,IDTARIFAV,DESCRIPCION,POSICION,DTO) VALUES (@CODCLIENTE,@TARIFA,@TARIFANOMBRE,1,0)";
                        Command.CommandText = Query;
                        Guardo = ExecuteNonQuery(Command);
                        Query = "INSERT INTO FPAGOCLIENTE(CODCLIENTE,TIPO,CODFORMAPAGO) VALUES (@CODCLIENTE,'Por Defecto',@FPAGO)";
                        Command.CommandText = Query;
                        Guardo = ExecuteNonQuery(Command);
                        Tran.Commit();
                    }
                    catch (Exception E)
                    {
                        Tran.Rollback();
                        throw E;
                    }
                }

            }

        }
        public List<object> getTiposCta()
        {
            List<object> L = new List<object>();
            //L.Add(new TipoSubCta("C", "CONTADO"));
            L.Add(new TipoSubCta("M", "CREDITO MES"));
            //L.Add(new TipoSubCta("D", "CREDITO DIA"));

            return L;
        }
        public void Update(object xObj)
        {
            ClienteActivo C = (ClienteActivo)xObj;
            List<IDataParameter> Lista = new List<IDataParameter>();



            #region ParametersCliente

            /* +++ Parametros tabla clientes +++ */
            Lista.Add(new SqlParameter("@CODCLIENTE", C.IdCliente));
            Lista.Add(new SqlParameter("@NOMBRE", C.Nombre.ToUpper()));
            Lista.Add(new SqlParameter("@CEDULA", C.Cedula));
            Lista.Add(new SqlParameter("@NOMBRECOMERCIAL", C.NombreComercial.ToUpper()));
            Lista.Add(new SqlParameter("@LINEACREDITO", C.Lineacredito));
            Lista.Add(new SqlParameter("@OBSERVACIONES", C.Observaciones));
            Lista.Add(new SqlParameter("@PAIS", C.Pais.ToUpper()));
            Lista.Add(new SqlParameter("@POSTAL", C.Postal.ToUpper()));
            Lista.Add(new SqlParameter("@TELEFONO", C.Telefono));
            Lista.Add(new SqlParameter("@TOPE", C.Tope));
            Lista.Add(new SqlParameter("@TIPO", C.Type));
            Lista.Add(new SqlParameter("@FAX", C.Fax));
            Lista.Add(new SqlParameter("@DPTO", C.Dpto.ToUpper()));
            Lista.Add(new SqlParameter("@DIRECCION", C.Direccion.ToUpper()));
            Lista.Add(new SqlParameter("@DIRECCIONALTERNARIVA", C.DireccionAlternativa.ToUpper()));
            Lista.Add(new SqlParameter("@COBRADOR", C.Cobrador.ToUpper()));
            Lista.Add(new SqlParameter("@CIERRE", C.Cierre));
            Lista.Add(new SqlParameter("@CELULAR", C.Celular));
            Lista.Add(new SqlParameter("@DESCATALOGADO", setDBoolean(C.Descatalogado)));
            Lista.Add(new SqlParameter("@CODMONEDA", C.Moneda.Codmoneda));
            Lista.Add(new SqlParameter("@RUTA", C.Ruta.ToUpper()));
            String xxfecha = C.Fecha.ToString(FechaSQL());
            Lista.Add(new SqlParameter("@FECNAC", xxfecha));
            Lista.Add(new SqlParameter("@CERRADA", setDBoolean(C.Cerrada)));


            /*++++ fin patametros tabla clientes ++++ */

            /* +++ parametros para tabla camposlibres +++ */
            Lista.Add(new SqlParameter("@INGRESOS", C.CamposLibres.Ingresos));
            Lista.Add(new SqlParameter("@VEHICULOS", C.CamposLibres.Vehiculos.ToUpper()));
            Lista.Add(new SqlParameter("@CCARGO", C.CamposLibres.ConyugeCargo.ToUpper()));
            Lista.Add(new SqlParameter("@CANTIGUEDAD", C.CamposLibres.ConyugeAntiguedad.ToUpper()));
            Lista.Add(new SqlParameter("@OOBSERVACIONES", C.CamposLibres.OtrasObservaciones.ToUpper()));
            Lista.Add(new SqlParameter("@PLASTICOS", C.CamposLibres.Plasticos.ToUpper()));
            Lista.Add(new SqlParameter("@EMAIL", C.CamposLibres.Email.ToUpper()));
            Lista.Add(new SqlParameter("@CINGRESOS", C.CamposLibres.ConyugeIngresos));
            Lista.Add(new SqlParameter("@CACTIVIDAD", C.CamposLibres.ConyugeActividad.ToUpper()));
            Lista.Add(new SqlParameter("@COMERCIALES", C.CamposLibres.Comerciales.ToUpper()));
            Lista.Add(new SqlParameter("@CIVIL", C.CamposLibres.Civil.ToUpper()));
            Lista.Add(new SqlParameter("@CARGO", C.CamposLibres.Cargo.ToUpper()));
            Lista.Add(new SqlParameter("@BIENES", C.CamposLibres.Bienes.ToUpper()));
            Lista.Add(new SqlParameter("@ANTIGUEDAD", C.CamposLibres.Antiguedad.ToUpper()));
            Lista.Add(new SqlParameter("@ALQUILER", C.CamposLibres.Alquiler.ToUpper()));
            Lista.Add(new SqlParameter("@ACTIVIDAD", C.CamposLibres.Actividad.ToUpper()));
            Lista.Add(new SqlParameter("@CONYUGE", C.CamposLibres.Conyuge.ToUpper()));
            Lista.Add(new SqlParameter("@APERTURA", DateTime.Now.ToShortDateString()));
            Lista.Add(new SqlParameter("@TARIFA", C.Tarifa.ID));
            //Lista.Add(new SqlParameter("@TARIFANOMBRE", GetValueFromProperty(_Tarifa.Nombre)));

            Lista.Add(new SqlParameter("@ACTIVO", setDBoolean(C.isActivo)));
            Lista.Add(new SqlParameter("@ACTIVODIA", setDBoolean(C.isActivoDia)));
            Lista.Add(new SqlParameter("@MONEDAUNICA", setDBoolean(C.isMonedaUnica)));
            Lista.Add(new SqlParameter("@FIDELIZADO", setDBoolean(C.isFidelizado)));
            Lista.Add(new SqlParameter("@SOLOORDEN", setDBoolean(C.isOrden)));
            Lista.Add(new SqlParameter("@DIC", setDBoolean(C.DIC)));
            Lista.Add(new SqlParameter("@BLOQUEO", setDBoolean(C.IsBloqueo)));

            /* FROMAPAGO */

            Lista.Add(new SqlParameter("@FPAGO", C.FormaPago.ID));
            Lista.Add(new SqlParameter("@IDTARIFA", C.Tarifa.ID));
            Lista.Add(new SqlParameter("@TARIFADES", C.Tarifa.Nombre));
            Lista.Add(new SqlParameter("@SOLOTITULAR", setDBoolean(C.SoloTitular)));

            /* +++ fin parametros campos libres +++ */
            #endregion

            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    try
                    {
                        SqlCommand Command = new SqlCommand("", Con);
                        Command.Transaction = Tran;
                        string Query = "SET ansi_warnings OFF; ";
                        Query = Query + "UPDATE Clientes SET ACTIVO = @ACTIVO,SOLOTITULAR = @SOLOTITULAR,ACTIVOCDIA = @ACTIVODIA,SOLOCONORDEN = @SOLOORDEN,FIDELIZADO = @FIDELIZADO,SOLOPESOS = @MONEDAUNICA,NOMBRECLIENTE = @NOMBRE,NOMBRECOMERCIAL = @NOMBRECOMERCIAL,TELEFONO1=@TELEFONO,TELEFONO2=@CELULAR,PAIS=@PAIS,PROVINCIA=@DPTO,ZONA=@COBRADOR,NUMTARJETA=@RUTA,CODPOSTAL=@POSTAL,DIRECCION1=@DIRECCION,DIRECCION2=@DIRECCIONALTERNARIVA,TIPO=@TIPO,DIAPAGO1=@CIERRE,OBSERVACIONES=@OBSERVACIONES,DESCATALOGADO=@DESCATALOGADO,FAX=@FAX,CODMONEDA=@CODMONEDA,ALIAS=@CEDULA,DIC=@DIC,NOBLOQUEAR=@BLOQUEO,FECHANACIMIENTO =@FECNAC,CERRADA = @CERRADA where codcliente = @CODCLIENTE";
                        Command.CommandText = Query;
                        ExecuteNonQuery(Command, Lista);
                        Query = "SET ansi_warnings OFF; ";
                        Query = Query + "UPDATE CLIENTESCAMPOSLIBRES SET ACTIVIDAD=@ACTIVIDAD,INGRESOS=@INGRESOS,CARGO=@CARGO,ESTADO_CIVIL=@CIVIL,CONYUGE=@CONYUGE,ACTIVIDAD1=@CACTIVIDAD,INGRESOS1=@CINGRESOS,ALQUILER=@ALQUILER,BIENES=@BIENES,VEHICULOS=@VEHICULOS,TARJ_CREDITO=@PLASTICOS,REF_COMERCIALES=@COMERCIALES,OBSERVACIONES_=@OBSERVACIONES,OBSERVACIONES1=@OOBSERVACIONES,MAIL=@EMAIL WHERE CODCLIENTE = @CODCLIENTE";
                        Command.CommandText = Query;
                        ExecuteNonQuery(Command);
                        Query = "UPDATE TARIFASCLIENTE SET IDTARIFAV = @IDTARIFA,DESCRIPCION = @TARIFADES where codcliente = @CODCLIENTE";
                        Command.CommandText = Query;
                        ExecuteNonQuery(Command);
                        Query = "UPDATE FPAGOCLIENTE SET CODFORMAPAGO = @FPAGO WHERE CODCLIENTE = @CODCLIENTE";
                        Command.CommandText = Query;
                        ExecuteNonQuery(Command);
                        Tran.Commit();
                    }
                    catch (Exception E)
                    {
                        Tran.Rollback();
                        throw E;
                    }
                }
         }






        }
        public object getFormaPagoByIDCliente(int xID)
        {
            FPago FormaPago = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 FP.CODFORMAPAGO as CODIGO,FP.DESCRIPCION AS DESCRIPCION FROM  FORMASPAGO FP INNER JOIN  FPAGOCLIENTE FPC ON FP.CODFORMAPAGO = FPC.CODFORMAPAGO WHERE (FPC.CODCLIENTE = @CODCLIENTE)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xID));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            FormaPago = (FPago)getFPagoFromReader(Reader);
                        }
                    }

                }
                return FormaPago;
            }
        }
        private FPago getFPagoFromReader(IDataReader rd)
        {
            FPago Temporal = null;
            string ID = (string)(rd["CODIGO"] is DBNull ? string.Empty : rd["CODIGO"]);
            string Descipcion = (string)(rd["DESCRIPCION"] is DBNull ? string.Empty : rd["DESCRIPCION"]);
            Temporal = new FPago();
            Temporal.ID = ID;
            Temporal.Nombre = Descipcion;
            return Temporal;
        }
        public object getSimpleByID(int xID)
        {
       

            ClienteActivo Cliente = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT top 1 CODCLIENTE AS ID,NOMBRECLIENTE AS NOMBRE ,NOMBRECOMERCIAL AS NOMBRECOMERCIAL,CIF AS RUT,TELEFONO1 AS TELEFONO,TELEFONO2 AS CELULAR,PAIS AS PAIS,PROVINCIA AS DPTO,ZONA AS COBRADOR,CODPOSTAL AS POSTAL,DIRECCION1 AS DIRECCION,DIRECCION2 AS DIRECCIONOPCIONAL,TIPO,RIESGOCONCEDIDO AS TOPE,LCREDITO AS LINEA,DIAPAGO1 AS CIERRE,OBSERVACIONES AS OBS,DESCATALOGADO,FAX,CODMONEDA AS MONEDA,FECHANACIMIENTO AS FECHAN,ALIAS AS CEDULA,ACTIVO,ACTIVOCDIA,SOLOCONORDEN,FIDELIZADO,SOLOPESOS,DIC,NOBLOQUEAR,TIPOINTERNO,NUMTARJETA,SOLOTITULAR,CERRADA FROM CLIENTES WHERE CODCLIENTE = @CODCLIENTE", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xID));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            Cliente = (ClienteActivo)getClienteFromReader(Reader);
                        }
                    }

                }
                return Cliente;
            }
            
            
        }
        private List<ClienteActivo> getClientes()
        {
            List<ClienteActivo> Clientes = new List<ClienteActivo>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT CODCLIENTE AS ID,NOMBRECLIENTE AS NOMBRE ,NOMBRECOMERCIAL AS NOMBRECOMERCIAL,CIF AS RUT,TELEFONO1 AS TELEFONO,TELEFONO2 AS CELULAR,PAIS AS PAIS,PROVINCIA AS DPTO,ZONA AS COBRADOR,CODPOSTAL AS POSTAL,DIRECCION1 AS DIRECCION,DIRECCION2 AS DIRECCIONOPCIONAL,TIPO,RIESGOCONCEDIDO AS TOPE,LCREDITO AS LINEA,DIAPAGO1 AS CIERRE,OBSERVACIONES AS OBS,DESCATALOGADO,FAX,CODMONEDA AS MONEDA,FECHANACIMIENTO AS FECHAN,ALIAS AS CEDULA,ACTIVO,ACTIVOCDIA,SOLOCONORDEN,FIDELIZADO,SOLOPESOS,DIC,NOBLOQUEAR,TIPOINTERNO,NUMTARJETA,SOLOTITULAR,CERRADA FROM CLIENTES where DESCATALOGADO = 'F' AND CODCLIENTE > 9", (SqlConnection)Con))
                {
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Clientes.Add((ClienteActivo)getClienteFromReader(Reader));
                        }
                    }
                }
            }
            return Clientes;
        }
        private decimal getImportePendiente(int xCod)
        {
            decimal zSuma = 0;
            foreach (MovimientoGeneral M in getMovimientosPendiente(xCod, false))
                zSuma += (M.Importe * M.Factormoneda);
            return zSuma;

        }
        private Moneda getMonedaByID(int xID)
        {
            foreach (object o in _Monedas)
                if (((Moneda)o).Codmoneda == xID)
                    return (Moneda)o;
            return null;
        }

        public List<PersonaAutorizada> GetListaAutorizados(int xCodCliente, int xSubCuenta)
        {
            List<PersonaAutorizada> Autorizados = new List<PersonaAutorizada>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT DOCASOCIADO AS DOCUMENTO,SUBCTATIT AS CUENTA,NOMBRECLIENTE AS NOMBRE,DIRECCION,TELEFONO,CELULAR,E_MAIL,OBSERVACIONES,FECHAINICIO AS INICIO,FECHAFIN AS FINAL,DESCATALOGADO FROM CLIENTESASOC WHERE DOCTITULAR = @CODCLIENTE AND subctatit = @SUBCUENTA", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCodCliente));
                    Com.Parameters.Add(new SqlParameter("@SUBCUENTA", xSubCuenta));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Autorizados.Add(getPersonaAutorizadaFromReader(Reader));
                        }
                    }
                }
            }
            return Autorizados;
            
        }

        public object ObtenerClientes()
        {
            DataTable DT = new DataTable();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT ISNULL(CONVERT(VARCHAR(8),C.CODCLIENTE),'') CODIGO, ISNULL(C.ALIAS,'') AS CEDULA,ISNULL(C.CIF,'') as RUT,ISNULL(C.NOMBRECLIENTE,'') NOMBRE,ISNULL(C.DIRECCION1,'') AS DIRECCION,ISNULL(CONVERT(VARCHAR(8),C.TELEFONO1),'') AS TELEFONO,ISNULL(CONVERT(VARCHAR(9),C.TELEFONO2),'') AS CELULAR,ISNULL(L.MAIL,' ') AS EMAIL,ISNULL(C.NUMTARJETA,' ') AS RUTA FROM  CLIENTES C INNER JOIN CLIENTESCAMPOSLIBRES L ON C.CODCLIENTE = L.CODCLIENTE WHERE (C.TIPO > 0) and C.DESCATALOGADO = 'F'", (SqlConnection)Con))
                {
                    DT.Load(ExecuteReader(Com));
                }
            }
            return DT;

            
        }
        public object getTarifaByCliente(int ID)
        {
            object Tarifa = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT top 1  TV.idtarifav as CODIGO,T.DESCRIPCION FROM tarifascliente as TV INNER JOIN TARIFASVENTA T ON TV.IDTARIFAV = T.IDTARIFAV where codcliente = @codcliente", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", ID));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            Tarifa = getTarifaFromReader(Reader);
                        }
                    }

                }
                return Tarifa;
            }
        }
        public int getClienteIDByCedula(string ID)
        {
            int Numero = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 isnull(CODCLIENTE,0) as NUMERO FROM  CLIENTES WHERE (ALIAS = @CODCLIENTE OR CODCLIENTE = @CODCLIENTE)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", ID));
                    Numero = (int)ExecuteScalar(Com);
                }
            }
            return Numero;
        }
        public DateTime getFecUltimoPago(int xCodCliente)
        {
            DateTime Fecha = DateTime.MinValue;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT dbo.CP_GET_ULTIMAFECHAPAGO(@CODCLIENTE) AS FECHA", (SqlConnection)Con))
                {
                    try
                    {
                        Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCodCliente));
                        Fecha = Convert.ToDateTime(ExecuteScalar(Com));
                    }
                    catch (Exception e)
                    {

                    }
                    
                }
            }
            return Fecha;
            
        }

        public DateTime getFecUltimaCompra(int xCodCliente)
        {
            DateTime Fecha = DateTime.MinValue;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT ISNULL(MAX(FECHADOCUMENTO),0) AS FECHA FROM TESORERIA WHERE CODIGOINTERNO = @CODCLIENTE and ORIGEN = 'C' AND (TIPODOCUMENTO = 'F' OR TIPODOCUMENTO = 'L') AND N = 'B'", (SqlConnection)Con))
                {
                    
                    try
                    {
                        Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCodCliente));
                        Fecha = Convert.ToDateTime(ExecuteScalar(Com));
                    }
                    catch (Exception e)
                    {

                    }

                }
            }
            return Fecha;
        }

        public int getClienteIDRut(string ID)
        {
            int Numero = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 isnull(CODCLIENTE,0) as NUMERO FROM  CLIENTES WHERE (CIF = @CODCLIENTE)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", ID));
                    Numero = (int)ExecuteScalar(Com);
                }
            }
            return Numero;
        }

        public int ExisteCliente(string xCodCLiente, string xCedula)
        {

            int Numero = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 COUNT(ISNULL(CODCLIENTE,0)) as NUMERO FROM  CLIENTES WHERE (codcliente = @CODCLIENTE or alias = @CEDULA)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCodCLiente));
                    Com.Parameters.Add(new SqlParameter("@CEDULA", xCedula));
                    Numero = (int)ExecuteScalar(Com);
                }
            }
            return Numero;
            
        }
        public void GuardarBitacora(List<object> xListaCambio, string xNUsuario)
        {
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    try
                    {
                        foreach (Cambio C in xListaCambio)
                        {
                            List<IDataParameter> P = new List<IDataParameter>();
                            P.Add(new SqlParameter("@IDCAMBIO", C.Codigo));
                            P.Add(new SqlParameter("@CLIENTE", C.Codcliente));
                            P.Add(new SqlParameter("@FECHA", C.Fecha));
                            P.Add(new SqlParameter("@EXP", C.Explicacion));
                            P.Add(new SqlParameter("@COMENTARIO", string.Empty));
                            P.Add(new SqlParameter("@USUARIO", C.Usuario));
                            P.Add(new SqlParameter("@NOMBRE", xNUsuario));
                            using (DbCommand Command = new SqlCommand("INSERT INTO BITACORA(IDCAMBIO,CODCLIENTE,FECHA,EXPLICACION,COMENTARIO,USUARIO,NOMBREUSUARIO)VALUES(@IDCAMBIO,@CLIENTE,@FECHA,@EXP,@COMENTARIO,@USUARIO,@NOMBRE)", Con))
                                ExecuteNonQuery(Command, P);
                        }
                        Tran.Commit();
                    }
                    catch (Exception E)
                    {
                        Tran.Rollback();
                        throw E;
                    }
                }
            }
        }

        public List<object> getInactivos()
        {
            List<object> Inactivos = new List<object>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT CODCLIENTE AS ID,NOMBRECLIENTE AS NOMBRE ,NOMBRECOMERCIAL AS NOMBRECOMERCIAL,CIF AS RUT,TELEFONO1 AS TELEFONO,TELEFONO2 AS CELULAR,PAIS AS PAIS,PROVINCIA AS DPTO,ZONA AS COBRADOR,CODPOSTAL AS POSTAL,DIRECCION1 AS DIRECCION,DIRECCION2 AS DIRECCIONOPCIONAL,TIPO,RIESGOCONCEDIDO AS TOPE,LCREDITO AS LINEA,DIAPAGO1 AS CIERRE,OBSERVACIONES AS OBS,DESCATALOGADO,FAX,CODMONEDA AS MONEDA,CONVERT(VARCHAR(12),FECHANACIMIENTO,103) AS FECHA,ALIAS AS CEDULA,ACTIVO,ACTIVOCDIA,SOLOCONORDEN,FIDELIZADO,SOLOPESOS,DIC,NOBLOQUEAR,TIPOINTERNO,NUMTARJETA,SOLOTITULAR,CERRADA FROM CLIENTES WHERE ACTIVO = 'F'", (SqlConnection)Con))
                {
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Inactivos.Add(getClienteFromReader(Reader));
                        }
                    }
                }
            }
            return Inactivos;
          
        }

        public void AddSubCuenta(object xObj)
        {
            SubCuenta Nueva = (SubCuenta)xObj;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                
                    using (DbCommand Command = new SqlCommand("INSERT INTO CLIENTESSUBCUENTAS(CODCLIENTE,CODSUBCTA,NOMBRECLIENTE,DIRECCION,TELEFONO,DESCATALOGADO,TIPOCUENTA,RUT) VALUES (@TITULAR,@SUBCUENTA,@NOMBRE,@DIRECCION,@TELEFONO,@DESCATALOGADO,@TIPO,@RUT)", Con))
                    {
                        Command.Parameters.Add(new SqlParameter("@TITULAR", Nueva.IdCliente));
                        Command.Parameters.Add(new SqlParameter("@SUBCUENTA", Nueva.Codigo)); // DOCUMENTO DE LA PERSONA AUTORIZADA
                        Command.Parameters.Add(new SqlParameter("@NOMBRE", Nueva.Nombre.ToUpper())); // DOCUMENTO DEL TITULAR DE LA CUENTA
                        Command.Parameters.Add(new SqlParameter("@DIRECCION", Nueva.Direccion.ToUpper()));
                        Command.Parameters.Add(new SqlParameter("@RUT", Nueva.Rut));
                        Command.Parameters.Add(new SqlParameter("@TELEFONO", Nueva.Telefono));
                        Command.Parameters.Add(new SqlParameter("@TIPO", Nueva.Tipo.ToUpper()));
                        Command.Parameters.Add(new SqlParameter("@DESCATALOGADO", setDBoolean(Nueva.Descatalogado)));
                        ExecuteNonQuery(Command);
                    }
                }
        }
        public List<SubCuenta> getSubCuentasByCliente(int xCodCliente)
        {
            List<SubCuenta> SubCuentas = new List<SubCuenta>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT CODCLIENTE AS TITULAR,CODSUBCTA AS CODIGO, NOMBRECLIENTE AS NOMBRE,DIRECCION,TELEFONO,DESCATALOGADO,TIPOCUENTA as TIPO,RUT,CELULAR FROM CLIENTESSUBCUENTAS WHERE CODCLIENTE = @CODCLIENTE", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCodCliente));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            SubCuentas.Add((SubCuenta)getSubCuentaFromReader(Reader));
                        }
                    }
                }
            }
            return SubCuentas;
        }


        public object getEstadoCuenta(DateTime xFechaDesde, DateTime xFechaHasta, object xCliente, int xSubCuenta)
        {
            
            ClienteActivo C = (ClienteActivo)xCliente;
            List<Movimiento> M = new List<Movimiento>();
            M = getMovimientosByClienteEC(C);
            foreach (Movimiento xM in getMovimientosRecibos(C, xFechaDesde))
                M.Add(xM);
            M.Sort();
            List<MovimientoGeneral> Movimientos = new List<MovimientoGeneral>();
            foreach (Object o in getMovimientosPendiente(C.IdCliente, false))
            {
                Movimientos.Add((MovimientoGeneral)o);
            }
            decimal zPesosAnterior = getSaldoAnterior(C.IdCliente, xFechaDesde.ToString(FechaSQL()), 1);
            decimal zDolaresAnterior = getSaldoAnterior(C.IdCliente, xFechaDesde.ToString(FechaSQL()), 2);
            EstadoCuenta EC = new EstadoCuenta(C, xFechaDesde, xFechaHasta, M, Movimientos, zPesosAnterior, zDolaresAnterior);

            return EC;
        }

        private decimal getSaldoAnterior(int xidCliente, string xFecha, int xCodMoneda)
        {
            decimal Importe = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT ISNULL(dbo.JL_GETSALDOANTERIOR(@ID,@FECHA,@MONEDA),0)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@ID", xidCliente));
                    Com.Parameters.Add(new SqlParameter("@FECHA", xFecha));
                    Com.Parameters.Add(new SqlParameter("@MONEDA", xCodMoneda));
                    Importe = Convert.ToDecimal(ExecuteScalar(Com));
                }
            }
            return Importe;
        }



        public List<object> getMovimientosPendiente(int xCodCliente, bool wCFE)
        {
            List<object> Movimientos = new List<object>();
            MovimientoGeneral Entity = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT V.VENCIMIENTOCONTADO AS PRECIOCONTADO,DBO.JL_TARIFABYFACTURA(T.SERIE,T.NUMERO) AS TARIFA,DBO.JL_TIPOBYCODCLIENTE(t.codigointerno) as tipocliente,T.SERIEDOC,t.NUMERODOC,t.codigointerno as CLIENTE,V.TIPODOC as NUMEROTIPO,T.MORA AS MORA,T.CAJASALDADO AS CAJASALDADO,T.ZSALDADO AS ZSALDADO,T.FACTORMONEDA AS FMONEDA,T.ORIGEN,T.GENAPUNTE AS APUNTE,T.CODTIPOPAGO AS TIPOPAGO,T.CODFORMAPAGO AS FORMAPAGO,MAX(T.POSICION) AS POSICION,MAX(D.DESCRIPCION) AS DESCRIPCION, MAX(T.FECHADOCUMENTO) AS 'FECHA DEL DOCUMENTO', MAX(T.SERIE) AS 'SERIE DE DOCUMENTO', MAX(T.NUMERO) AS 'NUMERO DE DOCUMENTO',CAST(SUM(T.IMPORTE) AS DECIMAL(16, 2)) AS IMPORTE,T.CODMONEDA AS MONEDA,T.ESTADO AS ESTADO,T.FECHAVENCIMIENTO AS VENCIMIENTO,T.NUMEROREMESA AS REMESA, T.TIPODOCUMENTO AS TIPODOC,T.FECHASALDADO AS SALDADO,SUBCTA FROM TESORERIA AS T LEFT OUTER JOIN FACTURASVENTA AS V ON T.SERIE = V.NUMSERIE AND T.NUMERO = V.NUMFACTURA AND T.N = V.N LEFT OUTER JOIN SERIES AS D ON V.NUMSERIE = D.SERIE WHERE (T.ORIGEN = 'C') AND (T.CODIGOINTERNO = @CLIENTE) AND T.N='B'  AND  (T.ESTADO='P') AND (T.TIPODOCUMENTO = 'F' OR T.TIPODOCUMENTO = 'L') GROUP BY V.VENCIMIENTOCONTADO,T.SERIEDOC,t.NUMERODOC,t.codigointerno,V.TIPODOC,T.MORA,T.CAJASALDADO,T.ZSALDADO,T.FACTORMONEDA,T.ORIGEN,T.GENAPUNTE,T.CODTIPOPAGO,T.CODFORMAPAGO,T.FECHADOCUMENTO,T.SERIE, T.NUMERO,T.CODMONEDA,T.ESTADO,T.FECHAVENCIMIENTO,T.NUMEROREMESA, T.TIPODOCUMENTO,T.FECHASALDADO,SUBCTA ", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CLIENTE", xCodCliente));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Entity = (MovimientoGeneral)getMovimientoFromReader(Reader);
                            Entity.Moneda = getMonedaByID((int)(Reader["MONEDA"]));
                            Movimientos.Add(Entity);
                        }
                    }
                }
            }
            return getListaWithCFE(Movimientos);
        }

        public object DetalleFactura(string xSerie, int xNumero)
        {
            DataTable DT = new DataTable();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT LIN.REFERENCIA, LIN.DESCRIPCION, LIN.UNID1 AS 'TOTAL DE UNIDADES', CAST(LIN.PRECIOIVA AS DECIMAL(16,2))AS 'PRECIO CON IVA', CAST(LIN.TOTAL+(LIN.TOTAL*LIN.IVA/100) AS DECIMAL(16,2)) AS 'TOTAL CON IVA' FROM ALBVENTALIN AS LIN INNER JOIN ALBVENTACAB CAB ON (LIN.NUMALBARAN = CAB.NUMALBARAN AND LIN.NUMSERIE = CAB.NUMSERIE AND LIN.N = CAB.N) INNER JOIN FACTURASVENTA AS FV ON (FV.NUMSERIE = CAB.NUMSERIE AND FV.N = CAB.N AND FV.NUMFACTURA = CAB.NUMFAC) WHERE CAB.N = 'B' AND FV.NUMSERIE = @SERIE AND FV.NUMFACTURA = @NUMERO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@NUMERO", xNumero));
                    Com.Parameters.Add(new SqlParameter("@SERIE", xSerie));
                    DT.Load(ExecuteReader(Com));
                }
            }
            return DT;
        }

        private List<Movimiento> getMovimientosByClienteEC(ClienteActivo xCliente)
        {
            List<Movimiento> Movimientos = new List<Movimiento>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT T.TIPODOCUMENTO,MAX(D.DESCRIPCION) AS DESCRIPCION, MAX(T.FECHADOCUMENTO) AS 'FECHA',V.TIPODOC as NUMEROTIPO, MAX(T.SERIE) AS 'SERIE', MAX(T.NUMERO) AS 'NUMERO',CAST(SUM(T.IMPORTE) AS DECIMAL(16, 2)) AS IMPORTE,T.CODMONEDA AS MONEDA,DBO.JL_ESTADOFACTURA(T.SERIE,T.NUMERO) AS ESTADO FROM TESORERIA AS T LEFT OUTER JOIN FACTURASVENTA AS V ON T.SERIE = V.NUMSERIE AND T.NUMERO = V.NUMFACTURA LEFT OUTER JOIN SERIES AS D ON V.NUMSERIE = D.SERIE WHERE (T.ORIGEN = 'C') AND (T.CODIGOINTERNO = @CLIENTE)  AND T.NUMERO > -1 AND (T.SERIE <> '****') AND (T.TIPODOCUMENTO = 'F' OR T.TIPODOCUMENTO = 'L') AND NOT (T.ESTADO='S' AND T.NUMEROREMESA=-1) GROUP BY V.TIPODOC,T.TIPODOCUMENTO,T.FECHADOCUMENTO, T.SERIE, T.NUMERO,T.CODMONEDA", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CLIENTE", xCliente.IdCliente));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Movimientos.Add((Movimiento)getMovimientoECFromReader(Reader, "F"));
                        }
                    }
                }
            }
            return Movimientos;
        }

        public List<Movimiento> getMovimientosByCliente(ClienteActivo xCliente)
        {
            List<Movimiento> Movimientos = new List<Movimiento>();
            MovimientoGeneral Entity = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT V.VENCIMIENTOCONTADO AS PRECIOCONTADO,DBO.JL_TARIFABYFACTURA(T.SERIEDOC,t.NUMERODOC) AS TARIFA,DBO.JL_TIPOBYCODCLIENTE(t.codigointerno) as tipocliente,CFE.LINKCFE as link,MAX(T.SERIEDOC) as SERIEDOC,MAX(t.NUMERODOC) as NUMERODOC,T.CODIGOINTERNO AS CLIENTE,V.TIPODOC as NUMEROTIPO,T.MORA AS MORA,T.CAJASALDADO AS CAJASALDADO,T.ZSALDADO AS ZSALDADO,T.FACTORMONEDA AS FMONEDA,T.ORIGEN,T.GENAPUNTE AS APUNTE,T.CODTIPOPAGO AS TIPOPAGO,T.CODFORMAPAGO AS FORMAPAGO,MAX(T.POSICION) AS POSICION,MAX(D.DESCRIPCION) AS DESCRIPCION, MAX(T.FECHADOCUMENTO) AS 'FECHA DEL DOCUMENTO', MAX(T.SERIE) AS 'SERIE DE DOCUMENTO', MAX(T.NUMERO) AS 'NUMERO DE DOCUMENTO',CAST(SUM(T.IMPORTE) AS DECIMAL(16, 2)) AS IMPORTE,T.CODMONEDA AS MONEDA,T.ESTADO AS ESTADO,T.FECHAVENCIMIENTO AS VENCIMIENTO,T.NUMEROREMESA AS REMESA, T.TIPODOCUMENTO AS TIPODOC,T.FECHASALDADO AS SALDADO,SUBCTA FROM TESORERIA AS T LEFT JOIN TESORERIACFE AS CFE ON (T.NUMERO = CFE.NUMEROFAC AND T.SERIE = CFE.SERIEFAC COLLATE DATABASE_DEFAULT) LEFT JOIN  FACTURASVENTA AS V ON (T.SERIE = V.NUMSERIE AND T.NUMERO = V.NUMFACTURA AND  V.N = 'B' and V.CODCLIENTE = @CLIENTE) LEFT JOIN SERIES AS D ON T.SERIE = D.SERIE WHERE (T.ORIGEN = 'C') AND (T.CODIGOINTERNO = @CLIENTE)  AND NOT (T.ESTADO='S' AND T.NUMEROREMESA=-1) AND (T.TIPODOCUMENTO = 'F' OR T.TIPODOCUMENTO = 'L')GROUP BY CFE.LINKCFE,T.SERIEDOC,t.NUMERODOC,T.CODIGOINTERNO,V.TIPODOC,T.MORA,T.CAJASALDADO,T.ZSALDADO,T.FACTORMONEDA,T.ORIGEN,T.GENAPUNTE,T.CODTIPOPAGO,T.CODFORMAPAGO,T.FECHADOCUMENTO,T.SERIE, T.NUMERO,T.CODMONEDA,T.ESTADO,T.FECHAVENCIMIENTO,T.NUMEROREMESA, T.TIPODOCUMENTO,T.FECHASALDADO,SUBCTA,V.VENCIMIENTOCONTADO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CLIENTE", xCliente.IdCliente));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Entity = (MovimientoGeneral)getMovimientoFromReader(Reader);
                            Entity.Moneda = getMonedaByID((int)(Reader["MONEDA"]));
                            Movimientos.Add(Entity);
                        }
                    }
                }
            }
            return Movimientos;


            
        }

        private List<Movimiento> getMovimientosRecibos(ClienteActivo xCliente, DateTime xFecha)
        {
            List<Movimiento> Movimientos = new List<Movimiento>();
            MovimientoGeneral Entity = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT MAX(T.FECHASALDADO) AS 'FECHA',T.SUDOCUMENTO AS 'SERIE',T.NUMEROREMESA AS 'NUMERO',CAST(SUM(T.IMPORTE)AS DECIMAL(16,2)) AS 'IMPORTE',T.CODMONEDA AS MONEDA, T.ESTADO AS ESTADO  FROM TESORERIA T  WHERE T.ORIGEN = 'C' AND T.FECHASALDADO >= @FECHA AND T.CODIGOINTERNO = @CLIENTE AND T.NUMEROREMESA > -1 AND SERIE <> '****'  GROUP BY T.NUMEROREMESA,T.SUDOCUMENTO,T.CODMONEDA,T.ESTADO HAVING (CAST(SUM(T.IMPORTE)AS DECIMAL(16,2)) > 0)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CLIENTE", xCliente.IdCliente));
                    Com.Parameters.Add(new SqlParameter("@FECHA", xFecha.ToString(FechaSQL())));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Entity = (MovimientoGeneral)getMovimientoECFromReader(Reader, "R");
                            Entity.NumeroTipo = 20;
                            Movimientos.Add(Entity);
                        }
                    }
                }
            }
            return Movimientos;
        }
        protected MovimientoGeneral getMovimientoECFromReader(IDataReader Reader, string xTipo)
        {
            MovimientoGeneral Temporal = null;

            try
            {

                string Serie = (string)(Reader["SERIE"] is DBNull ? string.Empty : Reader["SERIE"]);
                DateTime Fecha = Convert.ToDateTime((Reader["FECHA"]));
                DateTime Saldado = Fecha;
                int Numero = (int)(Reader["NUMERO"]);
                string TipoDoc = string.Empty;
                decimal Importe = (decimal)(Reader["IMPORTE"]);
                int remesa = -1;
                string Descripcion = "RECIBO DE PAGO";
                string Origen = "C";
                byte Linea = 1;
                int Moneda = (int)(Reader["MONEDA"]);
                Moneda M = getMonedaByID(Moneda);
                int NumeroTipo = 0;

                if (xTipo == "R")
                {
                    Importe *= -1;
                    remesa = Numero;
                }
                else
                {
                    TipoDoc = (string)(Reader["TIPODOCUMENTO"] is DBNull ? string.Empty : Reader["TIPODOCUMENTO"]);
                    Descripcion = (string)(Reader["DESCRIPCION"] is DBNull ? string.Empty : Reader["DESCRIPCION"]);
                    NumeroTipo = Convert.ToInt32((Reader["NUMEROTIPO"] is DBNull ? 0 : Reader["NUMEROTIPO"]));
                }
                Temporal = new MovimientoGeneral(Numero, Serie, Descripcion, Importe, Fecha, (Moneda)M, Linea, Origen, 1);
                Temporal.Tipodocumento = TipoDoc;
                Temporal.Saldado = Saldado;
                Temporal.Numeroremesa = remesa;
                Temporal.NumeroTipo = NumeroTipo;

                Temporal.Estado = (string)(Reader["ESTADO"] is DBNull ? string.Empty : Reader["ESTADO"]);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Temporal;
        }
        public List<object> getLinkByCFE(string xSerie, int xNumero)
        {
            List<object> Movimientos = new List<object>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 6 TIPOCFE,SERIECFE,NUMEROCFE,LINKCFE,SERIEALB,NUMEROALB,SERIEFAC,NUMEROFAC FROM TESORERIACFE  WHERE SERIECFE = @SERIE AND NUMEROCFE = @NUMERO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@SERIE", xSerie));
                    Com.Parameters.Add(new SqlParameter("@NUMERO", xNumero));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Movimientos.Add(getCFEFromReader(Reader));
                        }
                    }
                }
            }
            return Movimientos;
        }
        public List<object> getLinkByFactura(string xSerie, int xNumero)
        {
            List<object> Movimientos = new List<object>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 6 TIPOCFE,SERIECFE,NUMEROCFE,LINKCFE,SERIEALB,NUMEROALB,SERIEFAC,NUMEROFAC FROM TESORERIACFE WHERE SERIEFAC = @SERIE AND NUMEROFAC = @NUMERO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@SERIE", xSerie));
                    Com.Parameters.Add(new SqlParameter("@NUMERO", xNumero));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Movimientos.Add(getCFEFromReader(Reader));
                        }
                    }
                }
            }
            return Movimientos;
        }






        public void ModificarLimites(object xCliente, decimal xTope, decimal xLimite, string xComentario, int xUsuario, string xLugar)
        {

            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    using (DbCommand Command = new SqlCommand("", Con))
                    {
                        try
                        {
                            Command.Parameters.Add(new SqlParameter("@CLIENTE", ((ClienteActivo)xCliente).IdCliente));
                            Command.Parameters.Add(new SqlParameter("@TOPEVIEJO", ((ClienteActivo)xCliente).Tope));
                            Command.Parameters.Add(new SqlParameter("@TOPENUEVO", xTope));
                            Command.Parameters.Add(new SqlParameter("@LINEAVIEJA", ((ClienteActivo)xCliente).Lineacredito));
                            Command.Parameters.Add(new SqlParameter("@LINEANUEVA", xLimite));
                            Command.Parameters.Add(new SqlParameter("@COMENTARIO", xComentario));
                            Command.Parameters.Add(new SqlParameter("@USUARIO", xUsuario));
                            Command.Parameters.Add(new SqlParameter("@LUGAR", xLugar));
                            Command.Transaction = Tran;
                            string Query = "SET ansi_warnings OFF; ";
                            Query = Query + "UPDATE CLIENTES SET RIESGOCONCEDIDO=@TOPENUEVO,LCREDITO=@LINEANUEVA WHERE CODCLIENTE = @CLIENTE";
                            Command.CommandText = Query;
                            ExecuteNonQuery(Command);
                            Query = "SET ansi_warnings OFF; ";
                            Query = Query + "INSERT INTO REGISTROTOPES(CODCLIENTE,FECHA,TOPEVIEJO,TOPENUEVO,LINEAVIEJA,LINEANUEVA,COMENTARIO,IDUSER,TERMINAL)VALUES(@CLIENTE,GETDATE(),@TOPEVIEJO,@TOPENUEVO,@LINEAVIEJA,@LINEANUEVA,@COMENTARIO,@USUARIO,@LUGAR)";
                            Command.CommandText = Query;
                            ExecuteNonQuery(Command);
                            Tran.Commit();
                        }
                        catch (Exception e)
                        {
                            Tran.Rollback();
                            throw new Exception(e.Message);
                        }

                    }
                }

            }
        }    

        public void UpdateSubCuenta(object xSCuenta)
        {
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (DbCommand Command = new SqlCommand("UPDATE CLIENTESSUBCUENTAS SET NOMBRECLIENTE = @NOMBRE, DIRECCION = @DIRECCION, TELEFONO = @TELEFONO,DESCATALOGADO = @DESCATALOGADO,RUT = @RUT WHERE CODCLIENTE = @CODCLIENTE AND CODSUBCTA = @SUBCUENTA", Con))
                {
                    SubCuenta xSC = (SubCuenta)xSCuenta;
                    Command.Parameters.Add(new SqlParameter("@CODCLIENTE", xSC.IdCliente));
                    Command.Parameters.Add(new SqlParameter("@SUBCUENTA", xSC.Codigo));
                    Command.Parameters.Add(new SqlParameter("@NOMBRE", xSC.Nombre));
                    Command.Parameters.Add(new SqlParameter("@DIRECCION", xSC.Direccion));
                    Command.Parameters.Add(new SqlParameter("@TELEFONO", xSC.Telefono));
                    Command.Parameters.Add(new SqlParameter("@DESCATALOGADO", setDBoolean(xSC.Descatalogado)));
                    Command.Parameters.Add(new SqlParameter("@RUT", xSC.Rut));
                    ExecuteNonQuery(Command);
                    if (xSC.Rut.Length > 10 && xSC.Rut.Length < 13)
                    {
                        Command.CommandText = "UPDATE CLIENTES SET CIF = @RUT WHERE CODCLIENTE = @CODCLIENTE";
                        ExecuteNonQuery(Command);
                    }
                }
            }
        }

        public void ModificarAsociado(object xPersona, int xTitular)
        {
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (DbCommand Command = new SqlCommand("UPDATE CLIENTESASOC SET NOMBRECLIENTE = @NOMBRE, DIRECCION = @DIRECCION, TELEFONO = @TELEFONO,DESCATALOGADO = @DESCATALOGADO,CELULAR = @CELULAR,E_MAIL = @EMAIL,OBSERVACIONES = @OBSERVACIONES,FECHAFIN = @FECHAFIN WHERE DOCASOCIADO = @DOCUMENTO AND SUBCTATIT = @SUBCUENTA AND DOCTITULAR = @TITULAR", Con))
                {
                    PersonaAutorizada PA = (PersonaAutorizada)xPersona;
                    Command.Parameters.Add(new SqlParameter("@NOMBRE", PA.Nombre));
                    Command.Parameters.Add(new SqlParameter("@DIRECCION", PA.Direccion));
                    Command.Parameters.Add(new SqlParameter("@TELEFONO", PA.Telefono));
                    Command.Parameters.Add(new SqlParameter("@DESCATALOGADO", setDBoolean(PA.Descatalogada)));
                    Command.Parameters.Add(new SqlParameter("@CELULAR", PA.Celular));
                    Command.Parameters.Add(new SqlParameter("@EMAIL", PA.Email));
                    Command.Parameters.Add(new SqlParameter("@OBSERVACIONES", PA.Observaciones));
                    Command.Parameters.Add(new SqlParameter("@FECHAFIN", PA.FechaFinal.ToString(FechaSQL())));
                    Command.Parameters.Add(new SqlParameter("@DOCUMENTO", PA.Documento));
                    Command.Parameters.Add(new SqlParameter("@SUBCUENTA", PA.Cta));
                    Command.Parameters.Add(new SqlParameter("@TITULAR", xTitular));
                    ExecuteNonQuery(Command);
                   
                }
            }
        }

        public void AgregarOrden(object xOrden)
        {
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();

                using (DbCommand Command = new SqlCommand("INSERT INTO ORDENESCOMPRASCLI(NUMORDEN,CODCLIENTE,CODSUBCTA,FECHA,FACTURADO,DESCRIPCION) VALUES (@NUMORDEN,@CODCLIENTE,@CODSUBCTA,@FECHA,@FACTURADO,@DESCRIPCION", Con))
                {
                    Command.Parameters.Add(new SqlParameter("@CODCLIENTE", ((OrdenCompra)xOrden).Cliente));
                    Command.Parameters.Add(new SqlParameter("@CODSUBCTA", ((OrdenCompra)xOrden).SubCuenta)); // DOCUMENTO DE LA PERSONA AUTORIZADA
                    Command.Parameters.Add(new SqlParameter("@NUMORDEN", ((OrdenCompra)xOrden).Numero)); // DOCUMENTO DEL TITULAR DE LA CUENTA
                    Command.Parameters.Add(new SqlParameter("@FECHA", ((OrdenCompra)xOrden).Fecha.ToString(FechaSQL())));
                    Command.Parameters.Add(new SqlParameter("@FACTURADO", 'F'));
                    Command.Parameters.Add(new SqlParameter("@DESCRIPCION", ((OrdenCompra)xOrden).Descripcion));
                    ExecuteNonQuery(Command);
                }
            }
        }






        #region MetodosPrivados
        private void AgregarAsociado(PersonaAutorizada xAut, int xCodcliente, int xSubCuenta, IDbConnection xCon, IDbTransaction xTran)
        {

            List<IDataParameter> ParameterAut = new List<IDataParameter>();
            ParameterAut.Add(new SqlParameter("@ASCNOMBRE", xAut.Nombre.ToUpper()));
            ParameterAut.Add(new SqlParameter("@ASCDOCUMENTO", xAut.Documento)); // DOCUMENTO DE LA PERSONA AUTORIZADA
            ParameterAut.Add(new SqlParameter("@ASCTDOCUMENTO", xCodcliente)); // DOCUMENTO DEL TITULAR DE LA CUENTA
            ParameterAut.Add(new SqlParameter("@ASCDIRECCION", xAut.Direccion.ToUpper()));

            ParameterAut.Add(new SqlParameter("@ASCEMAIL", xAut.Email.ToUpper()));
            ParameterAut.Add(new SqlParameter("@ASCCELULAR", xAut.Celular));
            ParameterAut.Add(new SqlParameter("@ASCTELEFONO", xAut.Telefono));


            ParameterAut.Add(new SqlParameter("@ASCHOY", DateTime.Today.ToString(FechaSQL())));
            ParameterAut.Add(new SqlParameter("@ASCFFIN", xAut.FechaFinal.ToString(FechaSQL())));
            ParameterAut.Add(new SqlParameter("@SUBCTA", xSubCuenta));
            ParameterAut.Add(new SqlParameter("@DESCATALOGADO", setDBoolean(xAut.Descatalogada)));
            using (SqlCommand Com = new SqlCommand("INSERT INTO CLIENTESASOC(DOCTITULAR,DOCASOCIADO,SUBCTATIT,NOMBRECLIENTE,DIRECCION,TELEFONO,CELULAR,E_MAIL,FECHAINICIO,FECHAFIN,DESCATALOGADO) VALUES (@ASCTDOCUMENTO,@ASCDOCUMENTO,@SUBCTA,@ASCNOMBRE,@ASCDIRECCION,@ASCTELEFONO,@ASCCELULAR,@ASCEMAIL,@ASCHOY,@ASCFFIN,@DESCATALOGADO)", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, ParameterAut);
            }

        }
        private CFE getCFEFromReader(IDataReader rd)
        {
            CFE Temporal = null;
            try
            {


                int Tipo = (int)(rd["TIPOCFE"] is DBNull ? 0 : rd["TIPOCFE"]);
                string Serie = (string)(rd["SERIECFE"] is DBNull ? string.Empty : rd["SERIECFE"]);
                int Numero = (int)(rd["NUMEROCFE"] is DBNull ? 0 : rd["NUMEROCFE"]); ;
                string Link = (string)(rd["LINKCFE"] is DBNull ? string.Empty : rd["LINKCFE"]); ;
                string Albaran = (string)(rd["SERIEALB"] is DBNull ? string.Empty : rd["SERIEALB"]); ;
                int NAlbaran = (int)(rd["NUMEROALB"] is DBNull ? 0 : rd["NUMEROALB"]); ;
                string SerieF = (string)(rd["SERIEFAC"] is DBNull ? string.Empty : rd["SERIEFAC"]); ;
                int NumeroF = (int)(rd["NUMEROFAC"] is DBNull ? 0 : rd["NUMEROFAC"]); ;



                Temporal = new CFE(Tipo, Serie, Numero, Link, Albaran, NAlbaran, SerieF, NumeroF);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener movimiento", ex);
            }
            return Temporal;
        }
        private List<object> getListaWithCFE(List<object> Lista)
        {
            List<object> L = new List<object>();
            foreach (MovimientoGeneral M in Lista)
            {
                if (M.Fecha >= new DateTime(2016, 07, 01))
                    M.CFE = getCFEByFactura(M.Numero, M.Serie);
                L.Add(M);
            }
            return L;
        }
        private CFE getCFEByFactura(int Numero, string Serie)
        {
            CFE Entity = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT top 1 * from TESORERIACFE where SERIEFAC = @SERIE and NUMEROFAC = @NUMERO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@NUMERO", Numero));
                    Com.Parameters.Add(new SqlParameter("@SERIE", Serie));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            Entity = (CFE)getCFEFromReader(Reader);
                        }
                    }

                }
                return Entity;
            }
        }
        private SubCuenta getSubCuentaFromReader(IDataReader Reader)
        {
            SubCuenta Temporal = null;
            try
            {
                int idcliente = Convert.ToInt32((Reader["TITULAR"] is DBNull ? 0 : Reader["TITULAR"]));
                int codigo = Convert.ToInt32((Reader["CODIGO"] is DBNull ? 0 : Reader["CODIGO"]));
                Temporal = new SubCuenta(idcliente, codigo);
                Temporal.Telefono = (string)(Reader["TELEFONO"] is DBNull ? 0 : Reader["TELEFONO"]);
                Temporal.Nombre = (string)(Reader["NOMBRE"] is DBNull ? string.Empty : Reader["NOMBRE"]);
                Temporal.Tipo = (string)(Reader["TIPO"] is DBNull ? string.Empty : Reader["TIPO"]);
                Temporal.Celular = (string)(Reader["CELULAR"] is DBNull ? string.Empty : Reader["CELULAR"]);
                Temporal.Direccion = (string)(Reader["DIRECCION"] is DBNull ? string.Empty : Reader["DIRECCION"]);
                Temporal.Descatalogado = getDBoolean((Reader["DESCATALOGADO"]));
                Temporal.Rut = (string)(Reader["RUT"] is DBNull ? string.Empty : Reader["RUT"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener cliente", ex);
            }
            return Temporal;
        }
        private CamposLibres ObtenerCLByID(int xCodCliente)
        {

            CamposLibres CampoLibres = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT top 1 ACTIVIDAD,REF_COMERCIALES,ANTIGUEDAD,OBSERVACIONES_,OBSERVACIONES1,TARJ_CREDITO,MAIL,VEHICULOS,BIENES,ESTADO_CIVIL,ALQUILER,INGRESOS1,ACTIVIDAD1,CARGO,INGRESOS,CONYUGE FROM CLIENTESCAMPOSLIBRES WHERE CODCLIENTE = @CODCLIENTE", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCodCliente));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            CampoLibres = (CamposLibres)getCLFromReader(Reader, xCodCliente);
                        }
                    }

                }
                return CampoLibres;
            }

          
        }

        private List<CamposLibres> ObtenerCamposLibres()
        {
            List<CamposLibres> Campos = new List<CamposLibres>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT CODCLIENTE,ACTIVIDAD,REF_COMERCIALES,ANTIGUEDAD,OBSERVACIONES_,OBSERVACIONES1,TARJ_CREDITO,MAIL,VEHICULOS,BIENES,ESTADO_CIVIL,ALQUILER,INGRESOS1,ACTIVIDAD1,CARGO,INGRESOS,CONYUGE FROM CLIENTESCAMPOSLIBRES", (SqlConnection)Con))
                {
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Campos.Add((CamposLibres)getCLFromReader(Reader, Convert.ToInt32(Reader["CODCLIENTE"])));
                        }
                    }
                }
            }
            return Campos;

            
        }

        private CamposLibres getCLFromReader(IDataReader Reader, int xCodCliente)
        {
            CamposLibres Temporal = null;
            try
            {

                int ID = xCodCliente;
                Temporal = new CamposLibres(ID);
                Temporal.Actividad = (string)(Reader["ACTIVIDAD"] is DBNull ? string.Empty : Reader["ACTIVIDAD"]);
                Temporal.Comerciales = (string)(Reader["REF_COMERCIALES"] is DBNull ? string.Empty : Reader["REF_COMERCIALES"]);
                Temporal.Antiguedad = (string)(Reader["ANTIGUEDAD"] is DBNull ? string.Empty : Reader["ANTIGUEDAD"]);
                Temporal.OtrasObservaciones = (string)(Reader["OBSERVACIONES1"] is DBNull ? string.Empty : Reader["OBSERVACIONES1"]);
                Temporal.Plasticos = (string)(Reader["TARJ_CREDITO"] is DBNull ? string.Empty : Reader["TARJ_CREDITO"]);
                Temporal.Email = (string)(Reader["MAIL"] is DBNull ? string.Empty : Reader["MAIL"]);
                Temporal.Vehiculos = (string)(Reader["VEHICULOS"] is DBNull ? string.Empty : Reader["VEHICULOS"]);
                Temporal.Bienes = (string)(Reader["BIENES"] is DBNull ? string.Empty : Reader["BIENES"]);
                Temporal.Civil = (string)(Reader["ESTADO_CIVIL"] is DBNull ? string.Empty : Reader["ESTADO_CIVIL"]);
                Temporal.Alquiler = (string)(Reader["ALQUILER"] is DBNull ? string.Empty : Reader["ALQUILER"]);
                Temporal.ConyugeIngresos = (int)(Reader["INGRESOS1"] is DBNull ? 0 : Reader["INGRESOS1"]);
                Temporal.ConyugeActividad = (string)(Reader["ACTIVIDAD1"] is DBNull ? string.Empty : Reader["ACTIVIDAD1"]);
                Temporal.Cargo = (string)(Reader["CARGO"] is DBNull ? string.Empty : Reader["CARGO"]);
                Temporal.Ingresos = (int)(Reader["INGRESOS"] is DBNull ? 0 : Reader["INGRESOS"]);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener campos libres", ex);
            }
            return Temporal;
        }
        private PersonaAutorizada getPersonaAutorizadaFromReader(IDataReader Reader)
        {
            PersonaAutorizada Temporal = null;
            try
            {
                //SELECT DOCASOCIADO AS DOCUMENTO,SUBCTAASOC AS CUENTA,NOMBRECLIENTE AS NOMBRE,DIRECCION,PROVINCIA AS DPTO,TELEFONO,CELULAR,E_MAIL,OBSERVACIONES,FECHAINICIO AS INICIO,FECHAFIN AS FIN
                string direccion = (string)(Reader["DIRECCION"] is DBNull ? string.Empty : Reader["DIRECCION"]);
                string nombre = (string)(Reader["NOMBRE"] is DBNull ? string.Empty : Reader["NOMBRE"]);
                int documento = Convert.ToInt32((Reader["DOCUMENTO"] is DBNull ? 0 : Reader["DOCUMENTO"]));
                Temporal = new PersonaAutorizada(nombre, direccion, documento);
                Temporal.Telefono = Convert.ToInt32((Reader["TELEFONO"] is DBNull ? 0 : Reader["TELEFONO"]));
                Temporal.Celular = Convert.ToInt32((Reader["CELULAR"] is DBNull ? 0 : Reader["CELULAR"]));
                Temporal.Cta = (int)(Reader["CUENTA"] is DBNull ? string.Empty : Reader["CUENTA"]);
                Temporal.Observaciones = (string)(Reader["OBSERVACIONES"] is DBNull ? string.Empty : Reader["OBSERVACIONES"]);
                Temporal.FechaFinal = Convert.ToDateTime((Reader["FINAL"]));
                Temporal.FechaInicial = Convert.ToDateTime((Reader["INICIO"] is DBNull ? DateTime.MinValue : Reader["INICIO"]));
                Temporal.Descatalogada = getDBoolean((Reader["DESCATALOGADO"]));


            }
            catch (Exception ex)
            {

                throw new Exception("Error al obtener el asociado", ex);
            }

            return Temporal;
        }

        private ClienteActivo getClienteFromReader(IDataReader Reader)
        {
            ClienteActivo Temporal = null;
            try
            {

                int ID = (int)(Reader["ID"]);
                CamposLibres CP = ObtenerCLByID(ID);

                string Nombre = (string)(Reader["NOMBRE"] is DBNull ? string.Empty : Reader["NOMBRE"]);
                string Cedula = (string)(Reader["CEDULA"] is DBNull ? string.Empty : Reader["CEDULA"]);
                Temporal = new ClienteActivo(ID, Nombre, CP, Cedula);

                Temporal.Ruta = (string)(Reader["NUMTARJETA"] is DBNull ? string.Empty : Reader["NUMTARJETA"]);
                Temporal.IsBloqueo = getDBoolean((string)(Reader["NOBLOQUEAR"] is DBNull ? bool.FalseString : Reader["NOBLOQUEAR"]));
                Temporal.DIC = getDBoolean((string)(Reader["DIC"] is DBNull ? bool.FalseString : Reader["DIC"]));
                Temporal.isActivo = getDBoolean((string)(Reader["ACTIVO"] is DBNull ? bool.TrueString : Reader["ACTIVO"]));
                Temporal.isActivoDia = getDBoolean((string)(Reader["ACTIVOCDIA"] is DBNull ? bool.TrueString : Reader["ACTIVOCDIA"]));
                Temporal.isFidelizado = getDBoolean((string)(Reader["FIDELIZADO"] is DBNull ? bool.TrueString : Reader["FIDELIZADO"]));
                Temporal.isMonedaUnica = getDBoolean((string)(Reader["SOLOPESOS"] is DBNull ? bool.TrueString : Reader["SOLOPESOS"]));
                Temporal.isOrden = getDBoolean((string)(Reader["SOLOCONORDEN"] is DBNull ? bool.TrueString : Reader["SOLOCONORDEN"]));
                Temporal.NombreComercial = (string)(Reader["NOMBRECOMERCIAL"] is DBNull ? string.Empty : Reader["NOMBRECOMERCIAL"]);
                Temporal.Cerrada = getDBoolean((string)(Reader["CERRADA"] is DBNull ? bool.TrueString : Reader["CERRADA"]));
                Temporal.Rut = (string)(Reader["RUT"] is DBNull ? string.Empty : Reader["RUT"]);
                Temporal.Telefono = (string)(Reader["TELEFONO"] is DBNull ? string.Empty : Reader["TELEFONO"]);
                Temporal.Celular = (string)(Reader["CELULAR"] is DBNull ? string.Empty : Reader["CELULAR"]);
                Temporal.Pais = (string)(Reader["PAIS"] is DBNull ? string.Empty : Reader["PAIS"]);
                Temporal.Dpto = (string)(Reader["DPTO"] is DBNull ? string.Empty : Reader["DPTO"]);
                Temporal.Cobrador = (string)(Reader["COBRADOR"] is DBNull ? string.Empty : Reader["COBRADOR"]);
                Temporal.Postal = (string)(Reader["POSTAL"] is DBNull ? string.Empty : Reader["POSTAL"]);
                Temporal.Direccion = (string)(Reader["DIRECCION"] is DBNull ? string.Empty : Reader["DIRECCION"]);
                Temporal.DireccionAlternativa = (string)(Reader["DIRECCIONOPCIONAL"] is DBNull ? string.Empty : Reader["DIRECCIONOPCIONAL"]);
                Temporal.Type = Convert.ToInt32((Reader["TIPO"] is DBNull ? 0 : Reader["TIPO"]));
                Temporal.Tope = Convert.ToDecimal((Reader["TOPE"] is DBNull ? 1 : Reader["TOPE"]));
                Temporal.Lineacredito = Convert.ToDecimal((Reader["LINEA"] is DBNull ? 1 : Reader["LINEA"]));
                Temporal.Cierre = Convert.ToByte((Reader["CIERRE"] is DBNull ? 0 : Reader["CIERRE"]));
                Temporal.Observaciones = (string)(Reader["OBS"] is DBNull ? string.Empty : Reader["OBS"]);
                Temporal.Descatalogado = Convert.ToBoolean((Reader["DESCATALOGADO"] as string == "T") ? true : false);
                Temporal.Fax = (string)(Reader["FAX"] is DBNull ? string.Empty : Reader["FAX"]);
                Temporal.Fecha = Convert.ToDateTime((Reader["FECHAN"] is DBNull ? DateTime.MinValue : Reader["FECHAN"]));
                Temporal.Interno = getDBoolean((string)(Reader["TIPOINTERNO"] is DBNull ? bool.FalseString : Reader["TIPOINTERNO"]));
                Temporal.SoloTitular = getDBoolean((string)(Reader["SOLOTITULAR"] is DBNull ? bool.FalseString : Reader["SOLOTITULAR"]));
                Temporal.FormaPago = (FPago)getFormaPagoByIDCliente(ID);
                Temporal.Moneda = (Moneda)new CobrosMapper().getMonedaByCliente(ID);
                Temporal.Tarifa = (Tarifa)getTarifaByCliente(ID);
                Temporal.SubCuentas = getSubCuentasByCliente(ID);
                foreach (SubCuenta S in Temporal.SubCuentas)
                    if (S.Autorizados == null)
                        S.Autorizados = GetListaAutorizados(ID, S.Codigo);
                Temporal.FecUltimoPago = getFecUltimoPago(ID);
                Temporal.FecUltimaCompra = getFecUltimaCompra(ID);
            }
            catch (Exception ex)
            {
              
            }


            return Temporal;
        }

        private ClienteActivo getClienteFromReader(IDataReader Reader, CamposLibres xCP, decimal xSaldo)
        {
            ClienteActivo Temporal = null;
            try
            {

                int ID = (int)(Reader["ID"]);
                if (xCP == null)
                    xCP = new CamposLibres(ID);

                string nombre = (string)(Reader["NOMBRE"] is DBNull ? string.Empty : Reader["NOMBRE"]);
                string Cedula = (string)(Reader["CEDULA"] is DBNull ? string.Empty : Reader["CEDULA"]);
                Temporal = new ClienteActivo(ID, nombre, xCP, Cedula);
                Temporal.Saldo = xSaldo;

                Temporal.Ruta = (string)(Reader["NUMTARJETA"] is DBNull ? string.Empty : Reader["NUMTARJETA"]);
                Temporal.IsBloqueo = getDBoolean((string)(Reader["NOBLOQUEAR"] is DBNull ? bool.FalseString : Reader["NOBLOQUEAR"]));
                Temporal.DIC = getDBoolean((string)(Reader["DIC"] is DBNull ? bool.FalseString : Reader["DIC"]));
                Temporal.isActivo = getDBoolean((string)(Reader["ACTIVO"] is DBNull ? bool.TrueString : Reader["ACTIVO"]));
                Temporal.isActivoDia = getDBoolean((string)(Reader["ACTIVOCDIA"] is DBNull ? bool.TrueString : Reader["ACTIVOCDIA"]));
                Temporal.isFidelizado = getDBoolean((string)(Reader["FIDELIZADO"] is DBNull ? bool.TrueString : Reader["FIDELIZADO"]));
                Temporal.isMonedaUnica = getDBoolean((string)(Reader["SOLOPESOS"] is DBNull ? bool.TrueString : Reader["SOLOPESOS"]));
                Temporal.isOrden = getDBoolean((string)(Reader["SOLOCONORDEN"] is DBNull ? bool.TrueString : Reader["SOLOCONORDEN"]));
                Temporal.NombreComercial = (string)(Reader["NOMBRECOMERCIAL"] is DBNull ? string.Empty : Reader["NOMBRECOMERCIAL"]);
                Temporal.Cerrada = getDBoolean((string)(Reader["CERRADA"] is DBNull ? bool.TrueString : Reader["CERRADA"]));
                Temporal.Rut = (string)(Reader["RUT"] is DBNull ? string.Empty : Reader["RUT"]);
                Temporal.Telefono = (string)(Reader["TELEFONO"] is DBNull ? string.Empty : Reader["TELEFONO"]);
                Temporal.Celular = (string)(Reader["CELULAR"] is DBNull ? string.Empty : Reader["CELULAR"]);
                Temporal.Pais = (string)(Reader["PAIS"] is DBNull ? string.Empty : Reader["PAIS"]);
                Temporal.Dpto = (string)(Reader["DPTO"] is DBNull ? string.Empty : Reader["DPTO"]);
                Temporal.Cobrador = (string)(Reader["COBRADOR"] is DBNull ? string.Empty : Reader["COBRADOR"]);
                Temporal.Postal = (string)(Reader["POSTAL"] is DBNull ? string.Empty : Reader["POSTAL"]);
                Temporal.Direccion = (string)(Reader["DIRECCION"] is DBNull ? string.Empty : Reader["DIRECCION"]);
                Temporal.DireccionAlternativa = (string)(Reader["DIRECCIONOPCIONAL"] is DBNull ? string.Empty : Reader["DIRECCIONOPCIONAL"]);
                Temporal.Type = Convert.ToInt32((Reader["TIPO"] is DBNull ? 0 : Reader["TIPO"]));
                Temporal.Tope = Convert.ToDecimal((Reader["TOPE"] is DBNull ? 1 : Reader["TOPE"]));
                Temporal.Lineacredito = Convert.ToDecimal((Reader["LINEA"] is DBNull ? 1 : Reader["LINEA"]));
                Temporal.Cierre = Convert.ToByte((Reader["CIERRE"] is DBNull ? 0 : Reader["CIERRE"]));
                Temporal.Observaciones = (string)(Reader["OBS"] is DBNull ? string.Empty : Reader["OBS"]);
                Temporal.Descatalogado = Convert.ToBoolean((Reader["DESCATALOGADO"] as string == "T") ? true : false);
                Temporal.Fax = (string)(Reader["FAX"] is DBNull ? string.Empty : Reader["FAX"]);
                Temporal.Fecha = Convert.ToDateTime((Reader["FECHAN"] is DBNull ? DateTime.MinValue : Reader["FECHAN"]));
                Temporal.Interno = getDBoolean((string)(Reader["TIPOINTERNO"] is DBNull ? bool.FalseString : Reader["TIPOINTERNO"]));
                Temporal.SoloTitular = getDBoolean((string)(Reader["SOLOTITULAR"] is DBNull ? bool.FalseString : Reader["SOLOTITULAR"]));

            }
            catch (Exception ex)
            {
                int n = Convert.ToInt32(Reader["ID"]);
                throw new Exception(Reader["FECHAN"].ToString());

                throw new Exception("Error al obtener cliente desde el reader", ex);
            }


            return Temporal;
        }

        private Tarifa getTarifaFromReader(IDataReader rd)
        {
            Tarifa Temporal = null;
            try
            {
                int idTarifa = (int)(rd["CODIGO"] is DBNull ? 2 : rd["CODIGO"]);
                string xdesc = (string)(rd["DESCRIPCION"] is DBNull ? "CREDITO" : rd["DESCRIPCION"]);
                Temporal = new Tarifa();
                Temporal.ID = idTarifa;
                Temporal.Nombre = xdesc;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al obtener campos libres", ex);
            }
            return Temporal;
        }

        #endregion

        #region MetodosAccesoDB




        public void Delete(object o)
        {
            throw new NotImplementedException();
        }

        public void GrabarLlamada(int xIdCLiente, int xCampania, string xUsuario, string xComentario)
        {
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();

                using (DbCommand Command = new SqlCommand("INSERT INTO LLAMADAS(CODCLIENTE,NUMCAMPANIA,FECHA,USUARIO,COMENTARIO) VALUES (@CLIENTE,@NUMCAMPANIA,@FECHA,@USUARIO,@COMENTARIO)", Con))
                {
                    Command.Parameters.Add(new SqlParameter("@CLIENTE", xIdCLiente));
                    Command.Parameters.Add(new SqlParameter("@NUMCAMPANIA", xCampania)); // DOCUMENTO DE LA PERSONA AUTORIZADA
                    Command.Parameters.Add(new SqlParameter("@FECHA", DateTime.Now.ToString(FechaSQL()))); // DOCUMENTO DEL TITULAR DE LA CUENTA
                    Command.Parameters.Add(new SqlParameter("@USUARIO", xUsuario));
                    Command.Parameters.Add(new SqlParameter("@COMENTARIO", xComentario));
                    ExecuteNonQuery(Command);
                }
            }
        }

        public string DatosLlamada(int xCodCliente, int xCampania)
        {
            string Comment = "";
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 MAX(FECHA) AS FECHA,USUARIO,COMENTARIO FROM LLAMADAS WHERE CODCLIENTE = @CODCLIENTE AND NUMCAMPANIA = @CAMPANIA GROUP BY USUARIO,COMENTARIO ORDER BY FECHA DESC", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCodCliente));
                    Com.Parameters.Add(new SqlParameter("@CAMPANIA", xCampania));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            Comment = (string)Reader["USUARIO"] + " DIJO: " + Reader["COMENTARIO"] + " EL " + Convert.ToDateTime(Reader["FECHA"]).ToShortDateString();
                        }
                    }

                }
                return Comment;
            }  
        }

        public bool PuedoLlamar(int xCliente, int xCampania)
        {
            bool NoPuede = false;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 MAX(FECHA) AS FECHA,USUARIO,COMENTARIO FROM LLAMADAS WHERE CODCLIENTE = @CODCLIENTE AND  FECHA = @FECHA AND  NUMCAMPANIA = @CAMPANIA GROUP BY USUARIO,COMENTARIO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xCliente));
                    Com.Parameters.Add(new SqlParameter("@CAMPANIA", xCampania));
                    Com.Parameters.Add(new SqlParameter("@FECHA", DateTime.Now.ToString(FechaSQL())));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            NoPuede = true;
                        }
                    }

                }
                return NoPuede;
            }


           

            
        }

        protected override MovimientoGeneral getMovimientoFromReader(IDataReader Reader)
        {
            MovimientoGeneral Temporal = null;

            try
            {
                int cTarifa = (int)(Reader["TARIFA"] is DBNull ? 1 : Reader["TARIFA"]);
                int Tipo = (int)(Reader["NUMEROTIPO"] is DBNull ? 0 : Reader["NUMEROTIPO"]);
                int SubCta = (int)(Reader["SUBCTA"] is DBNull ? 0 : Reader["SUBCTA"]);
                if (SubCta < 1)
                    SubCta = 1;
                int codFormaPago = Convert.ToInt32((Reader["FORMAPAGO"]));
                int Remesa = Convert.ToInt32((Reader["REMESA"] is DBNull ? -1 : Reader["REMESA"]));
                int Moneda = (int)(Reader["MONEDA"]);
                int Tipopago = Convert.ToInt32((Reader["TIPOPAGO"]));
                int Numero = (int)(Reader["NUMERO DE DOCUMENTO"]);
                int zSaldado = (int)(Reader["ZSALDADO"] is DBNull ? -1 : Reader["ZSALDADO"]);
                int zCodCliente = (int)(Reader["CLIENTE"] is DBNull ? -1 : Reader["CLIENTE"]);
                int zNumeroDoc = (int)(Reader["NUMERODOC"] is DBNull ? -1 : Reader["NUMERODOC"]);
                string sDoc = (string)(Reader["SERIEDOC"] is DBNull ? string.Empty : Reader["SERIEDOC"]);
                // string sCFE = (string)(Reader["LINK"] is DBNull ? string.Empty : Reader["LINK"]);
                string Origen = (string)(Reader["ORIGEN"] is DBNull ? string.Empty : Reader["ORIGEN"]);
                string apunte = (string)(Reader["APUNTE"] is DBNull ? string.Empty : Reader["APUNTE"]);
                string Descripcion = (string)(Reader["DESCRIPCION"] is DBNull ? string.Empty : Reader["DESCRIPCION"]);
                string Serie = (string)(Reader["SERIE DE DOCUMENTO"] is DBNull ? string.Empty : Reader["SERIE DE DOCUMENTO"]);
                string TipoDoc = (string)(Reader["TIPODOC"]);
                string Estado = (string)(Reader["ESTADO"]);

                DateTime FV = Convert.ToDateTime((Reader["VENCIMIENTO"] is DBNull ? DateTime.MinValue : Reader["VENCIMIENTO"]));
                DateTime FS = Convert.ToDateTime((Reader["SALDADO"] is DBNull ? DateTime.MinValue : Reader["SALDADO"]));
                DateTime Fecha = Convert.ToDateTime((Reader["FECHA DEL DOCUMENTO"] is DBNull ? DateTime.MinValue : Reader["FECHA DEL DOCUMENTO"]));
                DateTime VC = Convert.ToDateTime((Reader["PRECIOCONTADO"] is DBNull ? DateTime.MinValue : Reader["PRECIOCONTADO"]));

                decimal Mora = Convert.ToDecimal((Reader["MORA"] is DBNull ? 0 : Reader["MORA"]));
                decimal fMoneda = Convert.ToDecimal((Reader["FMONEDA"] is DBNull ? 1 : Reader["FMONEDA"]));
                decimal Importe = (decimal)(Reader["IMPORTE"]);

                byte Linea = Convert.ToByte((Reader["POSICION"]));
                int xTipoCliente = (int)(Reader["tipocliente"] is DBNull ? -1 : Reader["tipocliente"]);






                //Moneda M = (Moneda)(new CobrosMapper()).getMonedaByID(Moneda);

                Temporal = new MovimientoGeneral(Numero, Serie, Descripcion, Importe, Fecha, null, Linea, Origen, cTarifa, fMoneda);
                Temporal.Mora = Mora;
                Temporal.Codcliente = zCodCliente;
                Temporal.NumeroTipo = Tipo;
                Temporal.GenApunte = apunte;
                Temporal.TipoPago = Tipopago;
                Temporal.FormaPago = codFormaPago;
                Temporal.Estado = Estado;
                Temporal.FechaVencimiento = FV;
                Temporal.Numeroremesa = Remesa;
                Temporal.Tipodocumento = TipoDoc;
                Temporal.Saldado = FS;
                Temporal.Zsaldado = zSaldado;
                Temporal.Subcta = SubCta;
                Temporal.SerieDoc = sDoc;
                Temporal.NumeroDoc = zNumeroDoc;
                Temporal.VencimientoContado = VC;
                Temporal.Tipocliente = xTipoCliente;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Temporal;
        }

        public List<object> getAll()
        {
            List<object> L = new List<object>();
            foreach (ClienteActivo C in getClientes())
                L.Add(C);
            return L;
        }

        public decimal getSaldo(int xidCliente, int xCodMoneda)
        {
            decimal Importe = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT isnull(sum(isnull(t.importe,0)),0) as IMPORTE FROM TESORERIA T WHERE T.ORIGEN = 'C' AND T.N = 'B'  AND (T.TIPODOCUMENTO = 'L' OR T.TIPODOCUMENTO = 'F') AND T.CODIGOINTERNO = @CLIENTE AND T.ESTADO = 'P' AND T.CODMONEDA = @MONEDA", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CLIENTE", xidCliente));
                    Com.Parameters.Add(new SqlParameter("@MONEDA", xCodMoneda));
                    Importe = Convert.ToDecimal(ExecuteScalar(Com));
                }
            }
            return Importe;
            

        }

        public List<object> ClientesParaEC()
        {
            List<object> Clientes = new List<object>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT C.CODCLIENTE,C.NOMBRECLIENTE FROM  CLIENTES C INNER JOIN (SELECT T.CODIGOINTERNO, ISNULL(SUM(T .IMPORTE * T .FACTORMONEDA), 0) AS 'HOLA' FROM TESORERIA T WHERE ORIGEN = 'C' AND (T .TIPODOCUMENTO = 'L' OR T.TIPODOCUMENTO = 'F') AND N = 'B' AND ESTADO = 'P' GROUP BY T.CODIGOINTERNO HAVING SUM(T .IMPORTE * T .FACTORMONEDA) > -1) AS T ON T.CODIGOINTERNO = C.CODCLIENTE WHERE C.DESCATALOGADO = 'F'", (SqlConnection)Con))
                {
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            int xCod = Convert.ToInt32(Reader["CODCLIENTE"]);
                            Clientes.Add(getSimpleByID(xCod));
                        }
                    }
                }
            }
            return Clientes;
        }



        #endregion
    }
}

