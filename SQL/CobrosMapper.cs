using System;
using System.Collections.Generic;
using Aguiñagalde.Interfaces;
using Aguiñagalde.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Text;
using System.Linq;

namespace Aguiñagalde.SQL
{
    public class CobrosMapper : DataAccess, IMapperCobros
    {
        private List<object> _ListaMonedas;
        public List<object> ListaMonedas
        {
            get
            {
                return _ListaMonedas;
            }
        }

        public CobrosMapper()
        {
            _ListaMonedas = new List<object>();
            _ListaMonedas = getMonedas();
            SetRegion();
        }

        private void SetRegion()
        {
            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ",";
            r.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;
        }
        public Tarifa getTarifaByID(int xID)
        {
            object ObjTarifa = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 IDTARIFAV AS ID,DESCRIPCION AS NOMBRE FROM TARIFASVENTA WHERE IDTARIFAV = @ID", Con))
                {
                    Com.Parameters.Add(new SqlParameter("@ID", xID));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {

                            ObjTarifa = getTarifaFromReader(Reader);
                        }
                    }
                }
            }
            return (Tarifa)ObjTarifa;

        }
        public List<object> getTarifasVenta()
        {
            object ObjTarifa = null;
            List<object> Tarifasventa = new List<object>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT IDTARIFAV AS ID,DESCRIPCION AS NOMBRE FROM TARIFASVENTA", Con))
                {
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            ObjTarifa = getTarifaFromReader(Reader);
                            Tarifasventa.Add(ObjTarifa);
                        }
                    }
                }
            }
            return Tarifasventa;
        }
        private Tarifa getTarifaFromReader(IDataReader Reader)
        {
            try
            {
                Tarifa Entity = new Tarifa();
                Entity.ID = (int)(Reader["ID"]);
                Entity.Nombre = (string)(Reader["Nombre"]);
                return Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Moneda getMonedaByID(int xID)
        {
            foreach (object o in _ListaMonedas)
                if (((Moneda)o).Codmoneda == xID)
                    return (Moneda)o;
            return null;
        }

        public object getMonedaByCliente(int xIDCliente)
        {
            object ObjMoneda = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT isnull(M.CODMONEDA,1) AS ID,DESCRIPCION AS NOMBRE, INICIALES,MORA FROM MONEDAS M INNER JOIN CLIENTES C ON C.CODMONEDA = M.CODMONEDA WHERE (C.CODCLIENTE = @CODCLIENTE)", Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODCLIENTE", xIDCliente));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {

                            ObjMoneda = getMonedaFromReader(Reader);
                        }
                    }
                }
            }
            return (Moneda)ObjMoneda;
        }

        public List<object> getMonedas()
        {
            object ObjMoneda = null;
            List<object> Monedas = new List<object>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT top 2 CODMONEDA AS ID,DESCRIPCION AS NOMBRE, INICIALES,MORA FROM MONEDAS where codmoneda between 1 and 2 Order by CodMoneda asc", Con))
                {
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            ObjMoneda = getMonedaFromReader(Reader);
                            if (((Moneda)ObjMoneda).Descripcion.Length > 0)
                                Monedas.Add(ObjMoneda);
                        }
                    }
                }
            }
            return Monedas;
        }

        public void AgregarAgengaLin(string xCodCLiente, DateTime xFechaVisita, int xCodUsuario, string xDirCobro, string xComentario)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@CLIENTE", xCodCLiente));
            P.Add(new SqlParameter("@FECHAV", xFechaVisita.ToShortDateString()));
            P.Add(new SqlParameter("@FECHAA", DateTime.Now));
            P.Add(new SqlParameter("@DIRECCION", xDirCobro));
            P.Add(new SqlParameter("@COMENTARIO", xComentario));
            P.Add(new SqlParameter("@USUARIO", xCodUsuario));

            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("INSERT INTO COBVISITAS(CODCLIENTE,FECVISITA,DIRCOBRO,FECAGENDADO,COMENTARIO,USUARIO) VALUES (@CLIENTE,@FECHAV,@DIRECCION,@FECHAA,@COMENTARIO,@USUARIO)", Con))
                {
                    ExecuteNonQuery(Com, P);
                }
            }
        }
        public List<object> getFormasPago()
        {
            List<object> FormasPago = new List<object>();
            FPago Entity = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT CODFORMAPAGO AS ID,DESCRIPCION AS NOMBRE FROM FORMASPAGO WHERE VISIBLEFRONT = 'T'", Con))
                {
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Entity = (FPago)getFpagoFromReader(Reader);
                            FormasPago.Add(Entity);
                        }
                    }
                }
            }
            return FormasPago;
        }
        private Moneda getMonedaFromReader(IDataReader Reader)
        {
            try
            {
                Moneda Entity = new Moneda((int)Reader["ID"], (string)Reader["Nombre"]);
                Entity.Iniciales = (string)(Reader["INICIALES"] is DBNull ? 0 : Reader["INICIALES"]);
                Entity.Mora = (decimal)Convert.ToDouble(((Reader["MORA"] is DBNull ? 0 : Reader["MORA"])));
                return Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object getCajaByID(string xNombreMaquina, object xUser)
        {

            List<int> Configs = new List<int>();
            Configs.Add(10);
            Configs.Add(43);
            Configs.Add(44);
            Configs.Add(45);
            Configs.Add(54);
            Configs.Add(53);
            Configs.Add(46);
            Configs.Add(56);
            Configs.Add(55);
            Configs.Add(57);
            Configs.Add(66);


            List<Config> ltsConfigs = getConfig(xNombreMaquina, Configs);
            string Serie = ltsConfigs.Find(Obj => Obj.ID == 10).Dato;



            decimal xFM = (decimal)getCotizacion();


            int Z = getNumeroZ(Serie);

            List<int> Lista = new List<int>();
            Lista.Add(19);
            Lista.Add(20);
            Lista.Add(21);
            Lista.Add(22);
            Lista.Add(23);
            Lista.Add(62);



            List<Serie> Series = getSeries(Serie, Lista);
            CajaGeneral C = new CajaGeneral(ltsConfigs, Z, xFM, Series);



            if (xUser != null)
                C.Usuario = (Usuario)xUser;

            return C;
        }

        #region Parametros

        private List<Config> getConfig(string xNombreMaquina, List<int> xIDs)
        {

            string cadena = "";
            List<IDataParameter> P = new List<IDataParameter>();
            StringBuilder SB = new StringBuilder("SELECT  VALOR AS SERIE,ID AS NUMERO  FROM PARTERMINAL WHERE IDTERMINAL = @EQUIPO  AND ID IN (");
            foreach (int Numero in xIDs)
            {
                cadena = cadena + (",@ID" + Numero.ToString());
                P.Add(new SqlParameter("@ID" + Numero.ToString(), Numero));
            }

            SB.Append(cadena.Remove(0, 1));
            SB.Append(")");

            List<Config> Configs = new List<Config>();
            using (SqlConnection Con = new SqlConnection(GeneralConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand(SB.ToString(), (SqlConnection)Con))
                {
                    P.Add(new SqlParameter("@EQUIPO", xNombreMaquina));
                    using (IDataReader Reader = ExecuteReader(Com, P))
                    {
                        while (Reader.Read())
                            Configs.Add(getConfigFromReader(Reader));
                    }
                }
            }
            return Configs;
        }
        public void UpdateParameters(List<Config> xLista, string xNombreEquipo)
        {
            using (SqlConnection Con = new SqlConnection(GeneralConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    try
                    {
                        DeleteParameters(xNombreEquipo, Tran, Con);
                        AddParameters(xLista, xNombreEquipo, Tran, Con);
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
        private void AddParameters(List<Config> xLista, string xNombreEquipo, IDbTransaction xTran, IDbConnection xCon)
        {
            List<string> Querys = new List<string>();
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@EQUIPO", xNombreEquipo));
            foreach (Config C in xLista)
            {
                P.Add(new SqlParameter("@ID" + C.ID, C.ID));
                P.Add(new SqlParameter("@VALOR" + C.ID, C.Dato));

                Querys.Add("INSERT INTO PARTERMINAL (IDTERMINAL,ID,CLAVE,VALOR) VALUES (@EQUIPO,@ID" + C.ID + ",DBO.JL_NOMBREBYCODIGO(@ID" + C.ID + "),@VALOR" + C.ID + ")");

            }
            using (SqlCommand Com = new SqlCommand("", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                try
                {
                    ExecuteNonQuery(Com, P, Querys);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        private void DeleteParameters(string xNombreEquipo, IDbTransaction xTran, IDbConnection xCon)
        {
            using (SqlCommand Com = new SqlCommand("DELETE FROM PARTERMINAL where IDTERMINAL = @EQUIPO", (SqlConnection)xCon))
            {
                Com.Parameters.Add(new SqlParameter("@EQUIPO", xNombreEquipo));
                Com.Transaction = (SqlTransaction)xTran;
                try
                {
                    ExecuteNonQuery(Com);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        public object Parametros(string xNombreMaquina, List<int> Indexs)
        {
            string cadena = "";
            DataTable DT;
            List<IDataParameter> P = new List<IDataParameter>();
            StringBuilder SB = new StringBuilder("SELECT  PF.ID,PF.CLAVE,PT.VALOR  FROM PARTERMINAL AS PT INNER JOIN PARAMETROSFRONT PF ON PF.ID = PT.ID WHERE PT.IDTERMINAL = @EQUIPO  AND PT.ID IN (");
            foreach (int Numero in Indexs)
            {
                cadena = cadena + (",@ID" + Numero.ToString());
                P.Add(new SqlParameter("@ID" + Numero.ToString(), Numero));
            }

            SB.Append(cadena.Remove(0, 1));
            SB.Append(") ORDER BY PT.ID ASC");

            using (SqlConnection Con = new SqlConnection(GeneralConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand(SB.ToString(), (SqlConnection)Con))
                {
                    P.Add(new SqlParameter("@EQUIPO", xNombreMaquina));
                    DT = new DataTable();
                    DT.Load(ExecuteReader(Com, P));
                }
            }
            return DT;
        }

        #endregion

        public object getUsuario(string xUsuario, string xPassword)
        {
            Usuario U = null;

            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT TOP 1 IDUSER,NOMBRE,PASSWORD,EMAIL,PASSEMAIL,EMAILHOST,CODVENDEDOR,NOMBRE_REAL FROM USUARIOS WHERE NOMBRE = @USUARIO AND PASSWORD = @PASSWORD", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@USUARIO", xUsuario));
                    Com.Parameters.Add(new SqlParameter("@PASSWORD", xPassword));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            U = getUsuarioFromReader(Reader);
                        }
                    }
                }
            }

            return U;
        }
        public object getUsuarioByVendedor(int xVendedor)
        {
            Usuario U = null;

            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT IDUSER,NOMBRE,PASSWORD,EMAIL,PASSEMAIL,EMAILHOST,CODVENDEDOR,NOMBRE_REAL FROM USUARIOS WHERE CODVENDEDOR = @CODV", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CODV", xVendedor));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            U = getUsuarioFromReader(Reader);
                        }
                    }
                }
            }

            return U;

        }
        private Usuario getUsuarioFromReader(IDataReader Reader)
        {
            Usuario U = null;
            int IdUsuario = ((int)Reader["IDUSER"]);
            List<Permiso> L = getPermisos(IdUsuario);
            U = new Usuario(IdUsuario, L);
            U.CodVendedor = (int)(Reader["CODVENDEDOR"] is DBNull ? 0 : Reader["CODVENDEDOR"]);
            U.Email = (string)(Reader["EMAIL"] is DBNull ? string.Empty : Reader["EMAIL"]);
            U.EmailHost = (string)(Reader["EMAILHOST"] is DBNull ? string.Empty : Reader["EMAILHOST"]);
            U.Nombre = (string)(Reader["NOMBRE"] is DBNull ? string.Empty : Reader["NOMBRE"]);
            U.PassEmail = (string)(Reader["PASSEMAIL"] is DBNull ? string.Empty : Reader["PASSEMAIL"]);
            U.Password = (string)(Reader["PASSWORD"] is DBNull ? string.Empty : Reader["PASSWORD"]);
            U.NombreReal = (string)(Reader["NOMBRE_REAL"] is DBNull ? string.Empty : Reader["NOMBRE_REAL"]);
            return U;
        }
        private List<Permiso> getPermisos(int xUsuario)
        {

            List<Permiso> Permisos = new List<Permiso>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT IDPERMISO FROM PERMISOSUSUARIO WHERE IDUSUARIO =  @ID", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@ID", xUsuario));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                            Permisos.Add(getPermisoFromReader(Reader));
                    }
                }
            }
            return Permisos;
        }
        private Permiso getPermisoFromReader(IDataReader rd)
        {
            Permiso P = null;
            try
            {
                P = new Permiso((int)rd["IDPERMISO"]);
            }
            catch (Exception e)
            {
                throw e;
            }
            return P;
        }
        public List<object> getMovimientosByRecibo(string xSerie, int xID, object xCliente)
        {
            List<object> Movimientos = new List<object>();
            MovimientoGeneral Entity = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT T.SERIEDOC,t.NUMERODOC,t.codigointerno as cliente,V.TIPODOC as NUMEROTIPO,T.MORA AS MORA,T.CAJASALDADO AS CAJASALDADO,T.ZSALDADO AS ZSALDADO,T.FACTORMONEDA AS FMONEDA,T.ORIGEN,T.GENAPUNTE AS APUNTE,T.CODTIPOPAGO AS TIPOPAGO,T.CODFORMAPAGO AS FORMAPAGO,MAX(T.POSICION) AS POSICION,MAX(D.DESCRIPCION) AS DESCRIPCION, MAX(T.FECHADOCUMENTO) AS 'FECHA DEL DOCUMENTO', MAX(T.SERIE) AS 'SERIE DE DOCUMENTO', MAX(T.NUMERO) AS 'NUMERO DE DOCUMENTO',CAST(SUM(T.IMPORTE) AS DECIMAL(16, 2)) AS IMPORTE,T.CODMONEDA AS MONEDA,T.ESTADO AS ESTADO,T.FECHAVENCIMIENTO AS VENCIMIENTO,T.NUMEROREMESA AS REMESA, T.TIPODOCUMENTO AS TIPODOC,T.FECHASALDADO AS SALDADO,T.SUBCTA FROM TESORERIA AS T LEFT OUTER JOIN FACTURASVENTA AS V ON T.SERIE = V.NUMSERIE AND T.NUMERO = V.NUMFACTURA AND T.N = V.N LEFT OUTER JOIN SERIES AS D ON V.NUMSERIE = D.SERIE WHERE     (T.ORIGEN = 'C') AND (T.NUMEROREMESA = @RECIBO and t.sudocumento = @SERIE) GROUP BY T.SERIEDOC,t.NUMERODOC,t.codigointerno,V.TIPODOC,T.MORA,T.CAJASALDADO,T.ZSALDADO,T.FACTORMONEDA,T.ORIGEN,T.GENAPUNTE,T.CODTIPOPAGO,T.CODFORMAPAGO,T.FECHADOCUMENTO,T.SERIE, T.NUMERO,T.CODMONEDA,T.ESTADO,T.FECHAVENCIMIENTO,T.NUMEROREMESA, T.TIPODOCUMENTO,T.FECHASALDADO,T.SUBCTA", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@RECIBO", xID));
                    Com.Parameters.Add(new SqlParameter("@SERIE", xSerie));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Moneda M = getMonedaByID((int)(Reader["MONEDA"]));
                            Entity = (MovimientoGeneral)getMovimientoFromReader(Reader);
                            Entity.Moneda = M;
                            Movimientos.Add(Entity);
                        }
                    }
                }
            }
            return Movimientos;
        }
        public void GuardarCFE(object gCFE)
        {
            CFE C = (CFE)gCFE;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (IDbTransaction Tran = Con.BeginTransaction())
                {
                    GuardarCFE(C, Con, Tran);
                }
            }
        }
         private int NumeroRecibo(string xSerie, IDbConnection xCon, IDbTransaction xTran,int xTipoDoc)
        {
            int Numero = -1;

            using (SqlCommand Com = new SqlCommand("UPDATE SERIESDOC SET CONTADORB = CONTADORB+1 WHERE (SERIE = @SERIERECIBO) AND TIPODOC = @TIPO", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                Com.Parameters.Add(new SqlParameter("@SERIERECIBO", xSerie));
                Com.Parameters.Add(new SqlParameter("@TIPO", xTipoDoc));
                ExecuteNonQuery(Com);
                Com.CommandText = "SELECT  CONTADORB+1 FROM SERIESDOC WHERE (SERIE = @SERIERECIBO) AND TIPODOC = @TIPO";
                Numero = (int)ExecuteScalar(Com);
            }
            return Numero;

        }
        private FPago getFpagoFromReader(IDataReader Reader)
        {
            try
            {
                FPago Entity = new FPago();
                Entity.ID = (string)(Reader["ID"]);
                Entity.Nombre = (string)(Reader["Nombre"]);
                return Entity;
            }
            catch (Exception ex)
            {
                throw new Exception("Error obtener Forma de pago", ex);
            }
        }
        private decimal getCotizacion()
        {
            decimal Cotizacion = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT GENERAL.DBO.MICOTIZACION(GETDATE(),@MONEDA) AS DECIMAL", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@MONEDA", 2));
                    Cotizacion = Convert.ToDecimal(ExecuteScalar(Com));
                }
            }
            return Convert.ToDecimal(Cotizacion);

        }
        private List<Serie> getSeries(string _Caja, List<int> xTipoDoc)
        {
            List<Serie> Series = new List<Serie>();
            string cadena = "";
            List<IDataParameter> P = new List<IDataParameter>();
            StringBuilder SB = new StringBuilder("SELECT SERIE as SERIE,IDTIPODOC as NUMERO  FROM SERIESCAJA WHERE IDCAJA = @CAJA  AND IDTIPODOC IN (");
            foreach (int Numero in xTipoDoc)
            {
                cadena = cadena + (",@ID" + Numero.ToString());
                P.Add(new SqlParameter("@ID" + Numero.ToString(), Numero));
            }

            SB.Append(cadena.Remove(0, 1));
            SB.Append(")");


            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand(SB.ToString(), (SqlConnection)Con))
                {
                    P.Add(new SqlParameter("@CAJA", _Caja));
                    using (IDataReader Reader = ExecuteReader(Com, P))
                    {
                        while (Reader.Read())
                            Series.Add(getSerieFromReader(Reader));
                    }
                }
            }


            return Series;

        }
        private Serie getSerieFromReader(IDataReader rd)
        {
            Serie S = null;
            try
            {
                string Serie = (string)(rd["SERIE"] is DBNull ? string.Empty : rd["SERIE"]);


                S = new Serie(Serie, (int)rd["NUMERO"]);
            }
            catch (Exception e)
            {
                throw e;
            }
            return S;
        }
        private Config getConfigFromReader(IDataReader rd)
        {
            Config S = null;
            try
            {
                string Serie = (string)(rd["SERIE"] is DBNull ? string.Empty : rd["SERIE"]);
                int Numero = (int)(rd["NUMERO"] is DBNull ? -1 : rd["NUMERO"]);
                S = new Config(Serie, Numero);
            }
            catch (Exception e)
            {
                throw e;
            }
            return S;
        }
        private int getNumeroZ(string xCaja)
        {
            int Z = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT ISNULL(CONVERT(INT,MAX(NUMERO+1)),1) AS NUMERO FROM ARQUEOS WHERE (FO = 1) AND (Arqueo = 'Z') AND (CAJA = @CAJA)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@CAJA", xCaja));
                    Z = (int)ExecuteScalar(Com);
                }
            }
            return Z;
        }


        public void Add(object o)
        {
            throw new Exception("No implementado");
        }
        public void Update(object o)
        {
            throw new Exception("No implementado");
        }
        public void Delete(object o)
        {
            throw new Exception("No implementado");
        }


        public int GenerarRemitos(object xRe, object xUsuario)
        {
            int Numero = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    try
                    {
                        Remito R = (Remito)xRe;
                        Numero = NumeroRecibo(R.Serie, Con, Tran,R.TipoDoc());
                        GuardarCabecera(R, Con, Numero, Tran);
                        GuardarVentaLin(R, Con, Numero, Tran);
                        GuardarFVentas(R, Con, Numero, Tran);
                        GuardatVentasTotales(R, Con, Numero, Tran);
                        GuardarTesoreria(R, Con, Numero, Tran);
                        if (R.Comentario.Length > 0)
                            GuardarComentario(R, Numero, ((Usuario)xUsuario).CodUsuario, Con, Tran);
                        Tran.Commit();
                    }
                    catch (Exception E)
                    {
                        Tran.Rollback();
                        throw E;
                    }
                }

            }
            return Numero;
        }
        private void GuardarComentario(Remito xRemito, int xNumero, int xUsuario, IDbConnection xCon, IDbTransaction xTran)
        {

            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@NUMERO", xNumero));
            P.Add(new SqlParameter("@SERIE", xRemito.Serie));
            P.Add(new SqlParameter("@COMENTARIO", xRemito.Comentario));
            P.Add(new SqlParameter("@USUARIO", xUsuario));
            using (SqlCommand Com = new SqlCommand("INSERT INTO COMENTARIODOCUMENTOS(SERIE,NUMERO,COMENTARIO,USUARIO) VALUES (@SERIE,@NUMERO,@COMENTARIO,@USUARIO)", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, P);
            }
        }
        private void GuardarCFE(object xCFE, IDbConnection xConexion, IDbTransaction xTran)
        {
            CFE CFE = (CFE)xCFE;
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@TIPOCFE", CFE.Tipo));
            P.Add(new SqlParameter("@SERIECFE", CFE.Serie));
            P.Add(new SqlParameter("@NUMEROCFE", CFE.Numero));
            P.Add(new SqlParameter("@LINKCFE", CFE.Link));
            P.Add(new SqlParameter("@SERIEALB", CFE.SerieAlbaran));
            P.Add(new SqlParameter("@NUMEROALB", CFE.NumeroAlbaran));
            P.Add(new SqlParameter("@SERIEFAC", CFE.SerieFactura));
            P.Add(new SqlParameter("@NUMEROFAC", CFE.NumeroFactura));
            DbCommand Command = new SqlCommand("INSERT INTO TESORERIACFE(TIPOCFE,SERIECFE,NUMEROCFE,LINKCFE,SERIEALB,NUMEROALB,SERIEFAC,NUMEROFAC) VALUES (@TIPOCFE,@SERIECFE,@NUMEROCFE,@LINKCFE,@SERIEALB,@NUMEROALB,@SERIEFAC,@NUMEROFAC)", (SqlConnection)xConexion);
            Command.Transaction = (SqlTransaction)xTran;
            ExecuteNonQuery(Command, P);

        }
        private void GuardatVentasTotales(Remito R, IDbConnection xCon, int xNumero, IDbTransaction xTran)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@SERIE", R.Serie));
            P.Add(new SqlParameter("@NUMERO", xNumero));
            P.Add(new SqlParameter("@N", "B"));
            P.Add(new SqlParameter("@NUMLINEA", 1));
            P.Add(new SqlParameter("@BRUTO", R.TotalBruto()));
            P.Add(new SqlParameter("@DTOCOMERC", Convert.ToInt32(0)));
            P.Add(new SqlParameter("@TOTDTOCOMERC", Convert.ToInt32(0)));
            P.Add(new SqlParameter("@DTOPP", Convert.ToInt32(0)));
            P.Add(new SqlParameter("@TOTDTOPP", Convert.ToInt32(0)));
            P.Add(new SqlParameter("@BASEIMPONIBLE", R.TotalBruto()));
            P.Add(new SqlParameter("@IVA", 22));
            P.Add(new SqlParameter("@TOTIVA", R.Importe() - R.TotalBruto()));
            P.Add(new SqlParameter("@REQ", Convert.ToInt32(0)));
            P.Add(new SqlParameter("@TOTREQ", Convert.ToInt32(0)));
            P.Add(new SqlParameter("@TOTAL", R.Importe()));
            P.Add(new SqlParameter("@ESGASTO", 'F'));
            P.Add(new SqlParameter("@CODDTO", -1));
            P.Add(new SqlParameter("@DESCRIPCION", string.Empty));
            using (SqlCommand Com = new SqlCommand("INSERT INTO ALBVENTATOT(SERIE,NUMERO,N,NUMLINEA,BRUTO,DTOCOMERC,TOTDTOCOMERC,DTOPP,TOTDTOPP,BASEIMPONIBLE,IVA,TOTIVA,REQ,TOTREQ,TOTAL,ESGASTO,CODDTO,DESCRIPCION) VALUES (@SERIE,@NUMERO,@N,@NUMLINEA,@BRUTO,@DTOCOMERC,@TOTDTOCOMERC,@DTOPP,@TOTDTOPP,@BASEIMPONIBLE,@IVA,@TOTIVA,@REQ,@TOTREQ,@TOTAL,@ESGASTO,@CODDTO,@DESCRIPCION)", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, P);
                Com.CommandText = "INSERT INTO FACTURASVENTATOT(SERIE,NUMERO,N,NUMLINEA,BRUTO,DTOCOMERC,TOTDTOCOMERC,DTOPP,TOTDTOPP,BASEIMPONIBLE,IVA,TOTIVA,REQ,TOTREQ,TOTAL,ESGASTO,CODDTO,DESCRIPCION) VALUES (@SERIE,@NUMERO,@N,@NUMLINEA,@BRUTO,@DTOCOMERC,@TOTDTOCOMERC,@DTOPP,@TOTDTOPP,@BASEIMPONIBLE,@IVA,@TOTIVA,@REQ,@TOTREQ,@TOTAL,@ESGASTO,@CODDTO,@DESCRIPCION)";
                ExecuteNonQuery(Com);
            }


        }
        private void GuardarFVentas(Remito R, IDbConnection xCon, int xNumero, IDbTransaction xTran)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@NUMSERIE", R.Serie));
            P.Add(new SqlParameter("@NUMFACTURA", xNumero));
            P.Add(new SqlParameter("@N", "B"));
            P.Add(new SqlParameter("@CODCLIENTE", R.Cliente.IdCliente));
            P.Add(new SqlParameter("@FECHA", R.Fecha));
            P.Add(new SqlParameter("@TOTALBRUTO", R.TotalBruto()));
            P.Add(new SqlParameter("@TOTALIMPUESTOS", R.TotalImpuestos()));
            P.Add(new SqlParameter("@TOTALNETO", R.Importe()));
            P.Add(new SqlParameter("@TOTALCOSTE", R.Costo()));
            P.Add(new SqlParameter("@CODMONEDA", R.Moneda.Codmoneda));
            P.Add(new SqlParameter("@FACTORMONEDA", R.FactorMoneda));
            P.Add(new SqlParameter("@IVAINCLUIDO", 'T'));
            P.Add(new SqlParameter("@CODVENDEDOR", R.CodVendedor));
            P.Add(new SqlParameter("@TIPODOC", R.TipoDoc()));
            P.Add(new SqlParameter("@Z", R.NumeroZ()));
            P.Add(new SqlParameter("@CAJA", R.SerieCaja()));
            P.Add(new SqlParameter("@TOTALCOSTEIVA", R.TotalCostoIva()));

            using (SqlCommand Com = new SqlCommand("INSERT INTO FACTURASVENTA (NUMSERIE,NUMFACTURA,N,CODCLIENTE,FECHA,TOTALBRUTO,TOTALIMPUESTOS,TOTALNETO,TOTALCOSTE,CODMONEDA,FACTORMONEDA,IVAINCLUIDO,CODVENDEDOR,TIPODOC,Z,CAJA,TOTALCOSTEIVA) VALUES (@NUMSERIE,@NUMFACTURA,@N,@CODCLIENTE,@FECHA,@TOTALBRUTO,@TOTALIMPUESTOS,@TOTALNETO,@TOTALCOSTE,@CODMONEDA,@FACTORMONEDA,@IVAINCLUIDO,@CODVENDEDOR,@TIPODOC,@Z,@CAJA,@TOTALCOSTEIVA)", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, P);
            }

        }
        private void GuardarVentaLin(Remito R, IDbConnection xCon, int xNumero, IDbTransaction xTran)
        {
            foreach (LineaRemito L in R.Lineas)
            {
                List<IDataParameter> Lin = new List<IDataParameter>();
                Lin.Add(new SqlParameter("@NUMSERIE", L.Serie));
                Lin.Add(new SqlParameter("@NUMALBARAN", xNumero));
                Lin.Add(new SqlParameter("@N", L.N));
                Lin.Add(new SqlParameter("@NUMLIN", L.NumLin));
                Lin.Add(new SqlParameter("@CODARTICULO", L.CodArticulo));
                Lin.Add(new SqlParameter("@REFERENCIA", L.Referencia));
                Lin.Add(new SqlParameter("@DESCRIPCION", L.Descripcion));
                Lin.Add(new SqlParameter("@COLOR", L.Color));
                Lin.Add(new SqlParameter("@TALLA", L.Talla));
                Lin.Add(new SqlParameter("@UNID1", L.Unid1));
                Lin.Add(new SqlParameter("@UNID2", L.Unid2));
                Lin.Add(new SqlParameter("@UNID3", L.Unid3));
                Lin.Add(new SqlParameter("@UNID4", L.Unid4));
                Lin.Add(new SqlParameter("@UNIDADESTOTAL", L.Unidadestotal));
                Lin.Add(new SqlParameter("@PRECIO", L.Precio));
                Lin.Add(new SqlParameter("@DTO", L.Dto));
                Lin.Add(new SqlParameter("@TOTAL", L.Total()));
                Lin.Add(new SqlParameter("@COSTE", L.Costo));
                Lin.Add(new SqlParameter("@PRECIODEFECTO", L.PrecioDefecto()));
                Lin.Add(new SqlParameter("@TIPOIMPUESTO", L.Tipoimpuesto));
                Lin.Add(new SqlParameter("@IVA", L.Iva));
                Lin.Add(new SqlParameter("@CODTARIFA", L.Codtarifa));
                Lin.Add(new SqlParameter("@CODALMACEN", L.CodAlmacen));
                Lin.Add(new SqlParameter("@CODVENDEDOR", R.CodVendedor));
                Lin.Add(new SqlParameter("@PRECIOIVA", L.Precioiva));
                Lin.Add(new SqlParameter("@UDSEXPANSION", L.Udsexpansion));
                Lin.Add(new SqlParameter("@EXPANDIDA", L.Expandida));
                Lin.Add(new SqlParameter("@TOTALEXPANSION", L.Totalexpansion));
                Lin.Add(new SqlParameter("@COSTEIVA", L.Costeiva));
                Lin.Add(new SqlParameter("@FECHAENTREGA", R.Fecha));
                Lin.Add(new SqlParameter("@NUMKGEXPANSION", L.Numkgentrega));
                using (SqlCommand Com = new SqlCommand("INSERT INTO ALBVENTALIN (NUMSERIE,NUMALBARAN,N,NUMLIN,CODARTICULO,REFERENCIA,DESCRIPCION,COLOR,TALLA,UNID1,UNID2,UNID3,UNID4,UNIDADESTOTAL,PRECIO,DTO,TOTAL,COSTE,PRECIODEFECTO,TIPOIMPUESTO,IVA,CODTARIFA,CODALMACEN,CODVENDEDOR,PRECIOIVA,UDSEXPANSION,EXPANDIDA,TOTALEXPANSION,COSTEIVA,FECHAENTREGA,NUMKGEXPANSION) VALUES (@NUMSERIE,@NUMALBARAN,@N,@NUMLIN,@CODARTICULO,@REFERENCIA,@DESCRIPCION,@COLOR,@TALLA,@UNID1,@UNID2,@UNID3,@UNID4,@UNIDADESTOTAL,@PRECIO,@DTO,@TOTAL,@COSTE,@PRECIODEFECTO,@TIPOIMPUESTO,@IVA,@CODTARIFA,@CODALMACEN,@CODVENDEDOR,@PRECIOIVA,@UDSEXPANSION,@EXPANDIDA,@TOTALEXPANSION,@COSTEIVA,@FECHAENTREGA,@NUMKGEXPANSION)", (SqlConnection)xCon))
                {
                    Com.Transaction = (SqlTransaction)xTran;
                    ExecuteNonQuery(Com, Lin);
                }

            }
        }
        private void GuardarTesoreria(Remito R, IDbConnection xCon, int xNumero, IDbTransaction xTran)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@SUDOCUMENTO", R.Sudocumento()));
            P.Add(new SqlParameter("@CAJASALDADO", R.SerieCaja()));
            P.Add(new SqlParameter("@ZSALDADO", R.NumeroZ()));
            P.Add(new SqlParameter("@NUMEROREMESA", R.Remesa()));
            P.Add(new SqlParameter("@GENAPUNTE", R.GenApunte()));
            P.Add(new SqlParameter("@ESTADO", R.Estado()));
            P.Add(new SqlParameter("@ORIGEN", "C"));
            P.Add(new SqlParameter("@TIPODOCUMENTO", "F"));
            P.Add(new SqlParameter("@SERIE", R.Serie));
            P.Add(new SqlParameter("@NUMERO", xNumero));
            P.Add(new SqlParameter("@N", 'B'));
            P.Add(new SqlParameter("@POSICION", 1));
            P.Add(new SqlParameter("@FECHADOCUMENTO", DateTime.Today));
            P.Add(new SqlParameter("@FECHAVENCIMIENTO", DateTime.Today));
            P.Add(new SqlParameter("@CODIGOINTERNO", R.Cliente.IdCliente));
            P.Add(new SqlParameter("@IMPORTE", R.Importe()));
            P.Add(new SqlParameter("@CODFORMAPAGO", R.FormaPago()));
            P.Add(new SqlParameter("@CODTIPOPAGO", R.TipoPago()));
            P.Add(new SqlParameter("@FECHASALDADO", R.Fecha));
            P.Add(new SqlParameter("@FACTORMONEDA", R.FactorMoneda));
            P.Add(new SqlParameter("@CODMONEDA", R.Moneda.Codmoneda));
            P.Add(new SqlParameter("@SUBCTA", R.IS.Codigo));
            using (SqlCommand Com = new SqlCommand("INSERT INTO TESORERIA (ORIGEN,TIPODOCUMENTO,SERIE,NUMERO,N,POSICION,FECHADOCUMENTO,FECHAVENCIMIENTO,CODIGOINTERNO,IMPORTE,CODFORMAPAGO,CODTIPOPAGO,ESTADO,FECHASALDADO,FACTORMONEDA,CODMONEDA,ZSALDADO,CAJASALDADO,NUMEROREMESA,GENAPUNTE,SUDOCUMENTO,SUBCTA) VALUES (@ORIGEN,@TIPODOCUMENTO,@SERIE,@NUMERO,@N,@POSICION,@FECHADOCUMENTO,@FECHAVENCIMIENTO,@CODIGOINTERNO,@IMPORTE,@CODFORMAPAGO,@CODTIPOPAGO,@ESTADO,@FECHASALDADO,@FACTORMONEDA,@CODMONEDA,@ZSALDADO,@CAJASALDADO,@NUMEROREMESA,@GENAPUNTE,@SUDOCUMENTO,@SUBCTA)", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, P);
            }
        }
        private void GuardarCabecera(Remito R, IDbConnection xCon, int xNumero, IDbTransaction xTran)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            decimal ImporteBruto = R.TotalBruto();
            decimal Impuestos = R.TotalImpuestos();
            decimal Costo = R.Costo();
            decimal Importe = R.Importe();
            decimal CostoIva = R.TotalCostoIva();
            DateTime F = DateTime.Today;
            P.Add(new SqlParameter("@NUMSERIE", R.Serie));
            P.Add(new SqlParameter("@NUMALBARAN", xNumero));
            P.Add(new SqlParameter("@N", 'B'));
            P.Add(new SqlParameter("@FACTURADO", 'T'));
            P.Add(new SqlParameter("@NUMSERIEFAC", R.Serie));
            P.Add(new SqlParameter("@NUMFAC", xNumero));
            P.Add(new SqlParameter("@CODCLIENTE", R.Cliente.IdCliente));
            P.Add(new SqlParameter("@CODVENDEDOR", R.CodVendedor));
            P.Add(new SqlParameter("@FECHA", F));
            P.Add(new SqlParameter("@TOTALBRUTO", ImporteBruto));
            P.Add(new SqlParameter("@TOTALIMPUESTOS", Impuestos));
            P.Add(new SqlParameter("@TOTALNETO", Importe));
            P.Add(new SqlParameter("@TOTALCOSTE", Costo));
            P.Add(new SqlParameter("@CODMONEDA", R.Moneda.Codmoneda));
            P.Add(new SqlParameter("@IVAINCLUIDO", 'T'));
            P.Add(new SqlParameter("@CODTARIFA", R.Tarifa));
            P.Add(new SqlParameter("@TIPODOC", R.TipoDoc()));
            P.Add(new SqlParameter("@TIPODOCFAC", R.TipoDoc()));
            P.Add(new SqlParameter("@FACTORMONEDA", R.FactorMoneda));
            P.Add(new SqlParameter("@CAJA", R.SerieCaja()));
            P.Add(new SqlParameter("@Z", R.NumeroZ()));
            P.Add(new SqlParameter("@TOTALCOSTEIVA", CostoIva));
            P.Add(new SqlParameter("@SALA", -1));
            P.Add(new SqlParameter("@MESA", -1));
            P.Add(new SqlParameter("@IDESTADO", -1));
            using (SqlCommand Com = new SqlCommand("INSERT INTO ALBVENTACAB(NUMSERIE,NUMALBARAN,N,FACTURADO,NUMSERIEFAC,NUMFAC,CODCLIENTE,CODVENDEDOR,FECHA,TOTALBRUTO,TOTALIMPUESTOS,TOTALNETO,TOTALCOSTE,CODMONEDA,IVAINCLUIDO,CODTARIFA,TIPODOC,TIPODOCFAC,Z,CAJA,TOTALCOSTEIVA,FACTORMONEDA,SALA,MESA,IDESTADO) VALUES (@NUMSERIE,@NUMALBARAN,@N,@FACTURADO,@NUMSERIEFAC,@NUMFAC,@CODCLIENTE,@CODVENDEDOR,@FECHA,@TOTALBRUTO,@TOTALIMPUESTOS,@TOTALNETO,@TOTALCOSTE,@CODMONEDA,@IVAINCLUIDO,@CODTARIFA,@TIPODOC,@TIPODOCFAC,@Z,@CAJA,@TOTALCOSTEIVA,@FACTORMONEDA,@SALA,@MESA,@IDESTADO)", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, P);
            }

        }
        public object getClavesEmpresa()
        {
            Empresa E = null;

            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT * FROM CLAVESEMPRESA WHERE (SUCURSAL = @SUCURSAL)", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@SUCURSAL", 1));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                        {
                            E = (Empresa)getEmpresaFromReader(Reader);
                        }
                    }
                }

            }

            return E;
        }
        private Empresa getEmpresaFromReader(IDataReader rd)
        {
            try
            {
                int xSucursal = (int)(rd["Sucursal"]);
                string xClave = (string)(rd["Clave"]);
                int xCodEmpresa = (int)(rd["CodEmpresa"]);
                Empresa E = new Empresa(xSucursal, xClave, xCodEmpresa);
                return E;
            }
            catch (Exception ex)
            {
                throw new Exception("Error obtener el usuario", ex);
            }
        }
        public void CambiarClaveUsuario(int xcodUsuario, string xpassword)
        {
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("UPDATE USUARIOS SET PASSWORD = @PASS WHERE IDUSER = @USUARIO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@USUARIO", xcodUsuario));
                    Com.Parameters.Add(new SqlParameter("@PASS", xpassword));
                    ExecuteNonQuery(Com);
                }

            }
        }
        public object getAllRecibos(int xZ, string xCaja)
        {
            DataTable DT;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT A.CODIGOINTERNO,A.SUDOCUMENTO AS SERIE,A.NUMEROREMESA AS NUMERO,SUM(A.IMPORTE) AS IMPREC,a.codmoneda AS MONEDA FROM TESORERIA AS A WHERE A.ORIGEN='C' AND A.NUMEROREMESA > 0 AND A.ZSALDADO = @Z AND A.CAJASALDADO = @CAJA GROUP BY A.CODIGOINTERNO,A.CODMONEDA,A.SUDOCUMENTO,A.NUMEROREMESA HAVING SUM(A.IMPORTE) > 0 ", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@Z", xZ));
                    Com.Parameters.Add(new SqlParameter("@CAJA", xCaja));
                    DT = new DataTable();
                    DT.Load(ExecuteReader(Com));
                }
            }
            return DT;
        }
        public object getContadosPendientes()
        {
            DataTable DT;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT T.POSICION AS COMPOSICION,T.FECHADOCUMENTO as FECHA,T.SERIE,T.NUMERO,M.INICIALES,T.CODMONEDA,isnull(T.IMPORTE,0) as IMPORTE,T.FACTORMONEDA AS COTIZACION,ISNULL(DBO.JL_PENDIENTEDEENTREGA(SERIE,NUMERO),0) AS PENDIENTE FROM TESORERIA T INNER JOIN MONEDAS AS M ON T.CODMONEDA = M.CODMONEDA  WHERE T.ORIGEN = 'C' AND (T.TIPODOCUMENTO = 'L' OR T.TIPODOCUMENTO = 'F') AND T.FECHADOCUMENTO > '20170401' AND (T.CODFORMAPAGO = 112 OR T.CODFORMAPAGO = 113) and T.ESTADO = 'P' and T.IMPORTE > 0 ORDER BY FECHA,NUMERO ASC", (SqlConnection)Con))
                {
                    DT = new DataTable();
                    DT.Load(ExecuteReader(Com));
                }
            }
            return DT;
        }
        public object getCajaDia(string xNombreMaquina, object xUser)
        {
            List<int> Configs = new List<int>();
            Configs.Add(10);
            List<Config> ltsConfigs = getConfig(xNombreMaquina, Configs);
            string Serie = "VC1";
            CajaCtaDia C;

            int Z = getNumeroZ(Serie);
            C = new CajaCtaDia(Serie, Z, 0);
            if (xUser != null)
                C.Usuario = (Usuario)xUser;
            return C;
        }
        public object DetallePosicion(string xSerie, int xNumero)
        {
            DataTable DT;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT  POSICION, IMPORTE, CODMONEDA, SERIEDOC AS SERIE, NUMERODOC AS NUMERO FROM TESORERIA  WHERE ORIGEN = 'C' AND N = 'B' AND SERIE = @SERIE AND NUMERO = @NUMERO", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@NUMERO", xNumero));
                    Com.Parameters.Add(new SqlParameter("@SERIE", xSerie));
                    DT = new DataTable();
                    DT.Load(ExecuteReader(Com));
                }
            }
            return DT;
        }
        public void SaldarCP(List<object> xLista, object xCaja)
        {
            Caja C = (Caja)xCaja;
            using (SqlConnection Con = new SqlConnection(GeneralConnectionString))
            {
                Con.Open();
                using (SqlTransaction Tran = Con.BeginTransaction())
                {
                    try
                    {
                        int Z = getNumeroZ(C.Id);
                        decimal zImporte = 0;
                        foreach (Movimiento m in xLista)
                        {
                            MovimientoCP mCP = (MovimientoCP)m;
                            zImporte += mCP.Importe * mCP.Cotizacion;
                            SaldarTesoreria(mCP, Z, Con, Tran);
                        }
                        GuardarArqueo(zImporte, Z, C.Id, C.Usuario.CodVendedor, Con, Tran);
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
        private void GuardarArqueo(decimal zImporte, int xZ, string xCaja, int xCodVendedor, IDbConnection xCon, IDbTransaction xTran)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@TOTAL", zImporte));
            P.Add(new SqlParameter("@NUMERO", xZ));
            P.Add(new SqlParameter("@FO", 1));
            P.Add(new SqlParameter("@ARQUEO", 'Z'));
            P.Add(new SqlParameter("@CAJA", xCaja));
            P.Add(new SqlParameter("@CODVENDEDOR", xCodVendedor));
            P.Add(new SqlParameter("@FECHA", DateTime.Now.ToString(FechaSQL())));
            P.Add(new SqlParameter("@HORA", DateTime.Now.ToString("HH:mm")));
            P.Add(new SqlParameter("@DESCUADRE", Convert.ToInt32(0)));
            P.Add(new SqlParameter("@PUNTEO", Convert.ToInt32(0)));
            using (SqlCommand Com = new SqlCommand("INSERT INTO ARQUEOS (FO,ARQUEO,CAJA,NUMERO,CODVENDEDOR,FECHA,HORA,TOTAL,DESCUADRE,PUNTEO) values (@FO,@ARQUEO,@CAJA,@NUMERO,@CODVENDEDOR,@FECHA,@HORA,@TOTAL,@DESCUADRE,@PUNTEO)", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, P);
            }
        }
        private void SaldarTesoreria(Movimiento xMov, int xZ, IDbConnection xCon, IDbTransaction xTran)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new SqlParameter("@SERIE", xMov.Serie));
            P.Add(new SqlParameter("@NUMERO", xMov.Numero));
            P.Add(new SqlParameter("@LINEA", xMov.Linea));
            P.Add(new SqlParameter("@Z", xZ));
            using (SqlCommand Com = new SqlCommand("UPDATE TESORERIA SET ESTADO = 'S', ZSALDADO = @Z  WHERE SERIE = @SERIE AND NUMERO = @NUMERO AND POSICION = @LINEA", (SqlConnection)xCon))
            {
                Com.Transaction = (SqlTransaction)xTran;
                ExecuteNonQuery(Com, P);
            }
        }
        public List<object> getListaMonedas()
        {
            return _ListaMonedas;
        }
        public object getArqueoByID(int xIdArqueo, string xCaja)
        {
            object Arq = null;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT NUMERO,FECHA,CODVENDEDOR FROM ARQUEOS WHERE NUMERO = @ARQUEO and CAJA = @CAJA", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@ARQUEO", xIdArqueo));
                    Com.Parameters.Add(new SqlParameter("@CAJA", xCaja));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        if (Reader.Read())
                            Arq = (Arqueo)getArqueoFromReader(Reader);
                    }

                }
            }

            return Arq;
        }
        private Arqueo getArqueoFromReader(IDataReader rd)
        {
            ArqueoCP ACP;
            int zNumero = Convert.ToInt32((rd["NUMERO"]));
            DateTime xFecha = (DateTime)(rd["FECHA"]);
            ACP = new ArqueoCP(zNumero, xFecha);
            return ACP;
        }
        public List<object> getMovimientosByArqueo(int numero, string xCaja)
        {
            List<object> Movimientos = new List<object>();
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT NUMERO,FECHA,CODVENDEDOR FROM ARQUEOS WHERE NUMERO = @ARQUEO and CAJA = @CAJA", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@ARQUEO", numero));
                    Com.Parameters.Add(new SqlParameter("@CAJA", xCaja));
                    using (IDataReader Reader = ExecuteReader(Com))
                    {
                        while (Reader.Read())
                        {
                            Movimientos.Add((MovimientoCP)getMovimientoCPFromReader(Reader));
                        }
                    }
                }
            }
            return Movimientos;
        }
        private MovimientoCP getMovimientoCPFromReader(IDataReader Reader)
        {
            MovimientoCP Temporal = null;

            try
            {


                int Numero = (int)(Reader["NUMERO"]);
                string Serie = (string)(Reader["SERIE"] is DBNull ? string.Empty : Reader["SERIE"]);
                DateTime Fecha = Convert.ToDateTime((Reader["FECHA"]));
                decimal fMoneda = Convert.ToDecimal((Reader["COTIZACION"] is DBNull ? 1 : Reader["COTIZACION"]));
                decimal Importe = (decimal)(Reader["IMPORTE"]);
                byte Linea = Convert.ToByte((Reader["COMPOSICION"]));
                Temporal = new MovimientoCP(Numero, Serie, Fecha, Importe, Linea, fMoneda);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Temporal;
        }
        public int getNumeroUsuarioArqueo(int xIdArqueo, string xCaja)
        {

            int Numero = -1;
            using (SqlConnection Con = new SqlConnection(GlobalConnectionString))
            {
                Con.Open();
                using (SqlCommand Com = new SqlCommand("SELECT CODVENDEDOR FROM ARQUEOS WHERE NUMERO = @NUMERO and CAJA = @CAJA", (SqlConnection)Con))
                {
                    Com.Parameters.Add(new SqlParameter("@NUMERO", xIdArqueo));
                    Com.Parameters.Add(new SqlParameter("@CAJA", xCaja));
                    Numero = (int)ExecuteScalar(Com);
                }
            }
            return Numero;
        }
        public decimal getImportePendiente(string xSerie, string xNumero)
        {
            throw new NotImplementedException();
        }
        protected override MovimientoGeneral getMovimientoFromReader(IDataReader Reader)
        {
            throw new NotImplementedException();
        }
        public int getz(Caja xCaja)
        {
            return getNumeroZ(xCaja.Id);
        }


    }
}

