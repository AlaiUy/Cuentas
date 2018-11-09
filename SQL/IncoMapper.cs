using Aguiñagalde.Entidades;
using Aguiñagalde.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Aguiñagalde.SQL
{
    public class IncoMapper : DataAccess, IMapperInco
    {

        private List<object> _Monedas = (new CobrosMapper()).ListaMonedas;

        public void Add(object o)
        {
            throw new NotImplementedException();
        }

        public void Delete(object o)
        {
            throw new NotImplementedException();
        }

        public void Update(object o)
        {
            throw new NotImplementedException();
        }

        private SqlConnection _Connection;
        public SqlConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new SqlConnection(IncoConnectionString);
                }
                return _Connection;
            }

        }

        public int getClienteIDByCedula(string xID)
        {
            object Numero = -1;
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CODCLIENTE", xID));
            DbCommand Command = new SqlCommand("SELECT TOP 1 isnull(CODCLIENTE,0) as NUMERO FROM  CLIENTES WHERE (ALIAS = @CODCLIENTE OR CODCLIENTE = @CODCLIENTE)", Connection);
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
            Numero = ExecuteScalar(Command, P);
            CerrarConexion(_Connection);
            if (Numero == null)
                return -1;
            return (int)Numero;
        }

        public int getClienteIDRut(string xID)
        {
            object Numero = -1;
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CODCLIENTE", xID));
            DbCommand Command = new SqlCommand("SELECT TOP 1 isnull(CODCLIENTE,0) as NUMERO FROM  CLIENTES WHERE (CIF = @CODCLIENTE)", Connection);
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
            Numero = ExecuteScalar(Command, P);
            CerrarConexion(_Connection);
            if (Numero == null)
                return -1;
            return (int)Numero;

        }

        public object getSimpleByID(int xID)
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
            //CamposLibres CL = ObtenerCLByID(xID);
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CODCLIENTE", xID));
            DbCommand Command = new SqlCommand("SELECT top 1 CODCLIENTE AS ID,NOMBRECLIENTE AS NOMBRE ,NOMBRECOMERCIAL AS NOMBRECOMERCIAL,CIF AS RUT,TELEFONO1 AS TELEFONO,TELEFONO2 AS CELULAR,PAIS AS PAIS,PROVINCIA AS DPTO,ZONA AS COBRADOR,CODPOSTAL AS POSTAL,DIRECCION1 AS DIRECCION,DIRECCION2 AS DIRECCIONOPCIONAL,TIPO,RIESGOCONCEDIDO AS TOPE,DIAPAGO1 AS CIERRE,OBSERVACIONES AS OBS,DESCATALOGADO,FAX,CODMONEDA AS MONEDA,FECHANACIMIENTO AS FECHAN,ALIAS AS CEDULA FROM CLIENTES WHERE CODCLIENTE = @CODCLIENTE", Connection);

            System.Data.IDataReader rd = null;
            ClienteInco Entity = null;

            rd = ExecuteReader(Command, P);
            if (rd.Read())
            {
                Entity = (ClienteInco)getClienteFromReader(rd);
            }
            rd.Close();
            CerrarConexion(_Connection);
            return (ClienteInco)Entity;

        }


        public FPago getFormaPagoByIDCliente(int xID)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CODCLIENTE", xID));
            DbCommand Command = new SqlCommand("SELECT top 1  FP.CODFORMAPAGO as CODIGO,FP.DESCRIPCION AS DESCRIPCION FROM  FORMASPAGO FP INNER JOIN  FPAGOCLIENTE FPC ON FP.CODFORMAPAGO = FPC.CODFORMAPAGO WHERE (FPC.CODCLIENTE = @CODCLIENTE)", Connection);
            System.Data.IDataReader rd = null;
            FPago Entity = null;
            try
            {
                if (Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
                rd = ExecuteReader(Command, P);
                if (rd.Read())
                {
                    Entity = (FPago)getFPagoFromReader(rd);
                }
                rd.Close();
                CerrarConexion(_Connection);
                return Entity;
            }
            catch (Exception Ex)
            {
                CerrarConexion(_Connection);
                throw new Exception("No se puedo cargar el cliente", Ex);
            }
        }

        public Tarifa getTarifaByCliente(int ID)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CODCLIENTE", ID));
            DbCommand Command = new SqlCommand("SELECT top 1  TV.idtarifav as CODIGO,T.DESCRIPCION FROM tarifascliente as TV INNER JOIN TARIFASVENTA T ON TV.IDTARIFAV = T.IDTARIFAV where codcliente = @codcliente", Connection);
            System.Data.IDataReader rd = null;
            Tarifa Entity = null;
            try
            {
                if (Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
                rd = ExecuteReader(Command, P);
                if (rd.Read())
                {
                    Entity = (Tarifa)getTarifaFromReader(rd);
                }
                rd.Close();
                CerrarConexion(_Connection);
                return Entity;
            }
            catch (Exception Ex)
            {
                CerrarConexion(_Connection);
                throw new Exception("No se puedo cargar el cliente", Ex);
            }
        }

        public DateTime getFecUltimoPago(int xCodCliente)
        {
            DateTime FEC = DateTime.MinValue;
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CODCLIENTE", xCodCliente));

            DbCommand Command = new SqlCommand("SELECT dbo.CP_GET_ULTIMAFECHAPAGO(@CODCLIENTE) AS FECHA", Connection);
            SqlDataReader rd = null;
            try
            {
                if (Connection.State == System.Data.ConnectionState.Closed)
                    Connection.Open();
                rd = (SqlDataReader)ExecuteReader(Command, P);
                if (rd.HasRows)
                {
                    if (rd.Read())
                    {
                        FEC = (DateTime)getFechaFromReader(rd);
                    }

                    return FEC;
                }
            }
            catch (Exception)
            {

                return DateTime.MinValue;
            }
            finally
            {
                rd.Close();
                CerrarConexion(_Connection);
            }
            return DateTime.MinValue;
        }

        private FPago getFPagoFromReader(IDataReader rd)
        {
            FPago Temporal = null;
            try
            {
                //SELECT DOCASOCIADO AS DOCUMENTO,SUBCTAASOC AS CUENTA,NOMBRECLIENTE AS NOMBRE,DIRECCION,PROVINCIA AS DPTO,TELEFONO,CELULAR,E_MAIL,OBSERVACIONES,FECHAINICIO AS INICIO,FECHAFIN AS FIN
                string ID = (string)(rd["CODIGO"] is DBNull ? string.Empty : rd["CODIGO"]);
                string Descipcion = (string)(rd["DESCRIPCION"] is DBNull ? string.Empty : rd["DESCRIPCION"]);
                Temporal = new FPago();
                Temporal.ID = ID;
                Temporal.Nombre = Descipcion;
            }
            catch (Exception ex)
            {
                CerrarConexion(_Connection);
                throw new Exception("Error al obtener el asociado", ex);
            }
            CerrarConexion(_Connection);
            return Temporal;
        }

        

        private ClienteInco getClienteFromReader(IDataReader Reader)
        {
            ClienteInco Temporal = null;
            try
            {

                int ID = (int)(Reader["ID"]);
                string nombre = (string)(Reader["NOMBRE"]);
                string Cedula = (string)(Reader["CEDULA"] is DBNull ? string.Empty : Reader["CEDULA"]);
                Temporal = new ClienteInco(ID,nombre, Cedula);

                
                //Temporal.Ruta = (string)(Reader["NUMTARJETA"] is DBNull ? string.Empty : Reader["NUMTARJETA"]);
                
                
                
                Temporal.NombreComercial = (string)(Reader["NOMBRECOMERCIAL"] is DBNull ? string.Empty : Reader["NOMBRECOMERCIAL"]);
                
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
                
                //Temporal.Lineacredito = Convert.ToDecimal((Reader["LINEA"] is DBNull ? 1 : Reader["LINEA"]));
                Temporal.Cierre = Convert.ToByte((Reader["CIERRE"] is DBNull ? 0 : Reader["CIERRE"]));
                
                Temporal.Descatalogado = Convert.ToBoolean((Reader["DESCATALOGADO"] as string == "T") ? true : false);
                
                Temporal.Fecha = Convert.ToDateTime((Reader["FECHAN"] is DBNull ? DateTime.MinValue : Reader["FECHAN"]));

            }
            catch (Exception ex)
            {


                throw ex;
            }
            finally
            {
                CerrarConexion(_Connection);
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
                CerrarConexion(_Connection);
                throw new Exception("Error al obtener campos libres", ex);
            }
            CerrarConexion(_Connection);
            return Temporal;
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
                CerrarConexion(_Connection);
                throw new Exception("Error al obtener campos libres", ex);
            }
            return Temporal;
        }

        public EstadoCuenta getEstadoCuenta(DateTime xFechaDesde, DateTime xFechaHasta, ClienteInco xCliente, int xSubCuenta)
        {
            try
            {


                ClienteInco C = (ClienteInco)xCliente;
                List<Movimiento> M = new List<Movimiento>();
                M = getMovimientosByClienteEC(C);
                foreach (Movimiento xM in getMovimientosRecibos(C, xFechaDesde))
                    M.Add(xM);
                M.Sort();
                List<MovimientoGeneral> Movimientos = new List<MovimientoGeneral>();
                // Movimientos = getMovimientosByCliente(C);
                foreach (MovimientoGeneral MG in getMovimientosPendiente(C.IdCliente, false))
                {
                    Movimientos.Add(MG);
                }
                decimal zPesosAnterior = getSaldoAnterior(C.IdCliente, xFechaDesde.ToString(FechaSQL()), 1);
                decimal zDolaresAnterior = getSaldoAnterior(C.IdCliente, xFechaDesde.ToString(FechaSQL()), 2);
                EstadoCuenta EC = new EstadoCuenta(C, xFechaDesde, xFechaHasta, M, Movimientos, zPesosAnterior, zDolaresAnterior);
                CerrarConexion(_Connection);
                return EC;
            }
            catch (Exception)
            {

            }
            return null;

        }


        private decimal getSaldoAnterior(int xidCliente, string xFecha, int xCodMoneda)
        {
            object Numero = -1;
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@ID", xidCliente));
            P.Add(new SqlParameter("@FECHA", xFecha));
            P.Add(new SqlParameter("@MONEDA", xCodMoneda));
            DbCommand Command = new SqlCommand("SELECT ISNULL(dbo.JL_GETSALDOANTERIOR(@ID,@FECHA,@MONEDA),0)", Connection);
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
                Numero = ExecuteScalar(Command, P);
                CerrarConexion(_Connection);
                if (Numero != null)
                    return Convert.ToDecimal(Numero);
            }
            CerrarConexion(_Connection);
            return 0;

        }


        private List<Movimiento> getMovimientosByClienteEC(Persona xCliente)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CLIENTE", xCliente.IdCliente));
            SqlCommand Command = new SqlCommand("SELECT T.TIPODOCUMENTO,MAX(D.DESCRIPCION) AS DESCRIPCION, MAX(T.FECHADOCUMENTO) AS 'FECHA', MAX(T.SERIE) AS 'SERIE', MAX(T.NUMERO) AS 'NUMERO',CAST(SUM(T.IMPORTE) AS DECIMAL(16, 2)) AS IMPORTE,T.CODMONEDA AS MONEDA,T.ESTADO AS ESTADO FROM TESORERIA AS T LEFT OUTER JOIN FACTURASVENTA AS V ON T.SERIE = V.NUMSERIE AND T.NUMERO = V.NUMFACTURA LEFT OUTER JOIN SERIES AS D ON V.NUMSERIE = D.SERIE WHERE (T.ORIGEN = 'C') AND (T.CODIGOINTERNO = @CLIENTE)  AND T.NUMERO > -1 AND (T.SERIE <> '****') AND (T.TIPODOCUMENTO = 'F' OR T.TIPODOCUMENTO = 'L') AND NOT (T.ESTADO='S' AND T.NUMEROREMESA=-1) GROUP BY T.TIPODOCUMENTO,T.FECHADOCUMENTO, T.SERIE, T.NUMERO,T.CODMONEDA,T.ESTADO", Connection);
            //SqlCommand Command = new SqlCommand("SELECT CFE.LINKCFE as link,T.SERIEDOC,t.NUMERODOC,T.CODIGOINTERNO AS CLIENTE,V.TIPODOC as NUMEROTIPO,T.MORA AS MORA,T.CAJASALDADO AS CAJASALDADO,T.ZSALDADO AS ZSALDADO,T.FACTORMONEDA AS FMONEDA,T.ORIGEN,T.GENAPUNTE AS APUNTE,T.CODTIPOPAGO AS TIPOPAGO,T.CODFORMAPAGO AS FORMAPAGO,MAX(T.POSICION) AS POSICION,MAX(D.DESCRIPCION) AS DESCRIPCION, MAX(T.FECHADOCUMENTO) AS 'FECHA DEL DOCUMENTO', MAX(T.SERIE) AS 'SERIE DE DOCUMENTO', MAX(T.NUMERO) AS 'NUMERO DE DOCUMENTO',CAST(SUM(T.IMPORTE) AS DECIMAL(16, 2)) AS IMPORTE,T.CODMONEDA AS MONEDA,T.ESTADO AS ESTADO,T.FECHAVENCIMIENTO AS VENCIMIENTO,T.NUMEROREMESA AS REMESA, T.TIPODOCUMENTO AS TIPODOC,T.FECHASALDADO AS SALDADO,SUBCTA FROM TESORERIA AS T LEFT JOIN TESORERIACFE AS CFE ON (T.NUMERO = CFE.NUMEROFAC AND T.SERIE = CFE.SERIEFAC COLLATE DATABASE_DEFAULT) LEFT JOIN  FACTURASVENTA AS V ON (T.SERIE = V.NUMSERIE AND T.NUMERO = V.NUMFACTURA AND  V.N = 'B' and V.CODCLIENTE = @CLIENTE) LEFT JOIN SERIES AS D ON T.SERIE = D.SERIE WHERE (T.ORIGEN = 'C') AND (T.CODIGOINTERNO = @CLIENTE)  AND NOT (T.ESTADO='S' AND T.NUMEROREMESA=-1) GROUP BY CFE.LINKCFE,T.SERIEDOC,t.NUMERODOC,T.CODIGOINTERNO,V.TIPODOC,T.MORA,T.CAJASALDADO,T.ZSALDADO,T.FACTORMONEDA,T.ORIGEN,T.GENAPUNTE,T.CODTIPOPAGO,T.CODFORMAPAGO,T.FECHADOCUMENTO,T.SERIE, T.NUMERO,T.CODMONEDA,T.ESTADO,T.FECHAVENCIMIENTO,T.NUMEROREMESA, T.TIPODOCUMENTO,T.FECHASALDADO,SUBCTA", Connection);

            System.Data.IDataReader rd = null;
            List<Movimiento> Movimientos = new List<Movimiento>();
            Movimiento Entity = null;
            try
            {
                if (_Connection.State == System.Data.ConnectionState.Closed)
                    _Connection.Open();
                rd = ExecuteReader(Command, P);
                while (rd.Read())
                {
                    Entity = (Movimiento)getMovimientoECFromReader(rd, "F");
                    Movimientos.Add(Entity);
                }
                rd.Close();
                CerrarConexion(_Connection);

                return Movimientos;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                CerrarConexion(_Connection);
            }
        }



        private List<Movimiento> getMovimientosRecibos(Persona xCliente, DateTime xFecha)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CLIENTE", xCliente.IdCliente));
            P.Add(new SqlParameter("@FECHA", xFecha.ToString(FechaSQL())));
            SqlCommand Command = new SqlCommand("SELECT MAX(T.FECHASALDADO) AS 'FECHA',T.SUDOCUMENTO AS 'SERIE',T.NUMEROREMESA AS 'NUMERO',CAST(SUM(T.IMPORTE)AS DECIMAL(16,2)) AS 'IMPORTE',T.CODMONEDA AS MONEDA, T.ESTADO AS ESTADO  FROM TESORERIA T  WHERE T.ORIGEN = 'C' AND T.FECHASALDADO >= @FECHA AND T.CODIGOINTERNO = @CLIENTE AND T.NUMEROREMESA > -1 AND SERIE <> '****'  GROUP BY T.NUMEROREMESA,T.SUDOCUMENTO,T.CODMONEDA,T.ESTADO HAVING (CAST(SUM(T.IMPORTE)AS DECIMAL(16,2)) > 0)", Connection);
            System.Data.IDataReader rd = null;
            List<Movimiento> Movimientos = new List<Movimiento>();
            MovimientoGeneral Entity = null;
            try
            {
                if (_Connection.State == System.Data.ConnectionState.Closed)
                    _Connection.Open();
                rd = ExecuteReader(Command, P);
                while (rd.Read())
                {
                    Entity = (MovimientoGeneral)getMovimientoECFromReader(rd, "R");
                    Entity.NumeroTipo = 20;
                    Movimientos.Add(Entity);
                }
                rd.Close();
                CerrarConexion(_Connection);

                return Movimientos;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                CerrarConexion(_Connection);
            }
        }

        private MovimientoGeneral getMovimientoECFromReader(IDataReader Reader, string xTipo)
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


                if (xTipo == "R")
                {
                    Importe *= -1;
                    remesa = Numero;
                }
                else
                {
                    TipoDoc = (string)(Reader["TIPODOCUMENTO"] is DBNull ? string.Empty : Reader["TIPODOCUMENTO"]);
                    Descripcion = (string)(Reader["DESCRIPCION"] is DBNull ? string.Empty : Reader["DESCRIPCION"]);
                }
                Temporal = new MovimientoGeneral(Numero, Serie, Descripcion, Importe, Fecha, (Moneda)M, Linea, Origen, 1);
                Temporal.Tipodocumento = TipoDoc;
                Temporal.Saldado = Saldado;
                Temporal.Numeroremesa = remesa;

                Temporal.Estado = (string)(Reader["ESTADO"] is DBNull ? string.Empty : Reader["ESTADO"]);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Temporal;
        }

        private Moneda getMonedaByID(int xID)
        {
            foreach (object o in _Monedas)
                if (((Moneda)o).Codmoneda == xID)
                    return (Moneda)o;
            return null;
        }


        public List<MovimientoGeneral> getMovimientosPendiente(int xCodCliente, bool wCFE)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CLIENTE", xCodCliente));
            DbCommand Command = new SqlCommand("SELECT t.codigointerno as CLIENTE,V.TIPODOC as NUMEROTIPO,T.MORA AS MORA,T.CAJASALDADO AS CAJASALDADO,T.ZSALDADO AS ZSALDADO,T.FACTORMONEDA AS FMONEDA,T.ORIGEN,T.GENAPUNTE AS APUNTE,T.CODTIPOPAGO AS TIPOPAGO,T.CODFORMAPAGO AS FORMAPAGO,MAX(T.POSICION) AS POSICION,MAX(D.DESCRIPCION) AS DESCRIPCION, MAX(T.FECHADOCUMENTO) AS 'FECHA DEL DOCUMENTO', MAX(T.SERIE) AS 'SERIE DE DOCUMENTO', MAX(T.NUMERO) AS 'NUMERO DE DOCUMENTO',CAST(SUM(T.IMPORTE) AS DECIMAL(16, 2)) AS IMPORTE,T.CODMONEDA AS MONEDA,T.ESTADO AS ESTADO,T.FECHAVENCIMIENTO AS VENCIMIENTO,T.NUMEROREMESA AS REMESA, T.TIPODOCUMENTO AS TIPODOC,T.FECHASALDADO AS SALDADO FROM TESORERIA AS T LEFT OUTER JOIN FACTURASVENTA AS V ON T.SERIE = V.NUMSERIE AND T.NUMERO = V.NUMFACTURA AND T.N = V.N LEFT OUTER JOIN SERIES AS D ON V.NUMSERIE = D.SERIE WHERE (T.ORIGEN = 'C') AND (T.CODIGOINTERNO = @CLIENTE) AND T.N='B'  AND  (T.ESTADO='P') AND (T.TIPODOCUMENTO = 'F' OR T.TIPODOCUMENTO = 'L') GROUP BY t.codigointerno,V.TIPODOC,T.MORA,T.CAJASALDADO,T.ZSALDADO,T.FACTORMONEDA,T.ORIGEN,T.GENAPUNTE,T.CODTIPOPAGO,T.CODFORMAPAGO,T.FECHADOCUMENTO,T.SERIE, T.NUMERO,T.CODMONEDA,T.ESTADO,T.FECHAVENCIMIENTO,T.NUMEROREMESA, T.TIPODOCUMENTO,T.FECHASALDADO", (SqlConnection)Connection);
            System.Data.IDataReader rd = null;
            List<MovimientoGeneral> Movimientos = new List<MovimientoGeneral>();
            MovimientoGeneral Entity = null;
            try
            {
                if (_Connection.State == System.Data.ConnectionState.Closed)
                    _Connection.Open();
                rd = ExecuteReader(Command, P);
                while (rd.Read())
                {
                    Entity = (MovimientoGeneral)getMovimientoFromReader(rd);
                    Entity.Moneda = getMonedaByID((int)(rd["MONEDA"]));
                    Movimientos.Add(Entity);
                }
                rd.Close();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                CerrarConexion(_Connection);
            }

            
            return Movimientos;
        }

        protected override MovimientoGeneral getMovimientoFromReader(IDataReader Reader)
        {
            MovimientoGeneral Temporal = null;

            try
            {
                int cTarifa = 2;
                int Tipo = (int)(Reader["NUMEROTIPO"] is DBNull ? 0 : Reader["NUMEROTIPO"]);
                int SubCta = 0;
                if (SubCta < 1)
                    SubCta = 1;
                int codFormaPago = Convert.ToInt32((Reader["FORMAPAGO"]));
                int Remesa = Convert.ToInt32((Reader["REMESA"] is DBNull ? -1 : Reader["REMESA"]));
                int Moneda = (int)(Reader["MONEDA"]);
                int Tipopago = Convert.ToInt32((Reader["TIPOPAGO"]));
                int Numero = (int)(Reader["NUMERO DE DOCUMENTO"]);
                int zSaldado = (int)(Reader["ZSALDADO"] is DBNull ? -1 : Reader["ZSALDADO"]);
                int zCodCliente = (int)(Reader["CLIENTE"] is DBNull ? -1 : Reader["CLIENTE"]);
                string Origen = (string)(Reader["ORIGEN"] is DBNull ? string.Empty : Reader["ORIGEN"]);
                string apunte = (string)(Reader["APUNTE"] is DBNull ? string.Empty : Reader["APUNTE"]);
                string Descripcion = (string)(Reader["DESCRIPCION"] is DBNull ? string.Empty : Reader["DESCRIPCION"]);
                string Serie = (string)(Reader["SERIE DE DOCUMENTO"] is DBNull ? string.Empty : Reader["SERIE DE DOCUMENTO"]);
                string TipoDoc = (string)(Reader["TIPODOC"]);
                string Estado = (string)(Reader["ESTADO"]);

                DateTime FV = Convert.ToDateTime((Reader["VENCIMIENTO"] is DBNull ? DateTime.MinValue : Reader["VENCIMIENTO"]));
                DateTime FS = Convert.ToDateTime((Reader["SALDADO"] is DBNull ? DateTime.MinValue : Reader["SALDADO"]));
                DateTime Fecha = Convert.ToDateTime((Reader["FECHA DEL DOCUMENTO"] is DBNull ? DateTime.MinValue : Reader["FECHA DEL DOCUMENTO"]));
                

                decimal Mora = Convert.ToDecimal((Reader["MORA"] is DBNull ? 0 : Reader["MORA"]));
                decimal fMoneda = Convert.ToDecimal((Reader["FMONEDA"] is DBNull ? 1 : Reader["FMONEDA"]));
                decimal Importe = (decimal)(Reader["IMPORTE"]);

                byte Linea = Convert.ToByte((Reader["POSICION"]));
                






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
                Temporal.Tipocliente = 7;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Temporal;
        }
    }
}
