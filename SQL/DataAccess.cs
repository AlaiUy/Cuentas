using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Common;
using Aguiñagalde.Tools;
using System.Data;
using Aguiñagalde.Entidades;

namespace Aguiñagalde.SQL
{
    public abstract class DataAccess
    {


        private static string globalConnectionString;

        private static string generalConnectionString;

        private static string mySQLConnectionString;

        private static string _IncoConnectionString;


        public static string GlobalConnectionString
        {
            get
            {
                if (globalConnectionString == null)
#if DEBUG
                    globalConnectionString = ConfigurationManager.ConnectionStrings["Servidor2AguinaG"].ConnectionString;
#else
                    globalConnectionString = ConfigurationManager.ConnectionStrings["ServidorAguinaG"].ConnectionString;
#endif


                return DataAccess.globalConnectionString;
            }
            set { DataAccess.globalConnectionString = value; }
        }

        public static string GeneralConnectionString
        {
            get
            {
                if (generalConnectionString == null)
#if DEBUG
                    generalConnectionString = ConfigurationManager.ConnectionStrings["Servidor2Gestion"].ConnectionString;
#else
                    generalConnectionString = ConfigurationManager.ConnectionStrings["ServidorGestion"].ConnectionString;
#endif

                return DataAccess.generalConnectionString;
            }
            set { DataAccess.generalConnectionString = value; }
        }


        public static string MySQLConnectionString
        {
            get
            {
                if(mySQLConnectionString == null)
#if DEBUG
                    mySQLConnectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
#else
                    mySQLConnectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
#endif

                return DataAccess.mySQLConnectionString;
            }
            set { DataAccess.mySQLConnectionString = value; }
        }

        public static string IncoConnectionString
        {
            get
            {
                if (_IncoConnectionString == null)
#if DEBUG
                    _IncoConnectionString = ConfigurationManager.ConnectionStrings["IncosAguinaG"].ConnectionString;
#else
                    _IncoConnectionString = ConfigurationManager.ConnectionStrings["IncosAguinaG"].ConnectionString;
#endif

                return DataAccess._IncoConnectionString;
            }
            set { DataAccess._IncoConnectionString = value; }
        }

        public int ExecuteNonQuery(DbCommand cmd)
        {
            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                CerrarConexion(cmd.Connection);
                throw new Exception(e.Message);
            }
        }

        public int ExecuteNonQuery(DbCommand cmd, IDataParameter Param)
        {
            try
            {
                cmd.Parameters.Add(Param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                CerrarConexion(cmd.Connection);
                throw new Exception(e.Message);
            }
        }


        public int ExecuteNonQuery(DbCommand cmd, List<IDataParameter> Lts)
        {
            foreach (IDataParameter P in Lts)
            {
                cmd.Parameters.Add(P);
            }

            try
            {
                return cmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                CerrarConexion(cmd.Connection);
                throw E;
            }
        }

        public int ExecuteNonQuery(DbCommand cmd, List<IDataParameter> Lts,List<string> xQuerys)
        {
            foreach (IDataParameter P in Lts)
            {
                cmd.Parameters.Add(P);
            }

            try
            {
                if(xQuerys.Count > 0)
                {
                    foreach(string S in xQuerys)
                    {
                        cmd.CommandText = S;
                        cmd.ExecuteNonQuery();
                    }

                }
                return 1;
            }
            catch (Exception E)
            {
                CerrarConexion(cmd.Connection);
                throw E;
            }
        }



        public IDataReader ExecuteReader(DbCommand cmd)
        {
            try
            {
                return cmd.ExecuteReader(CommandBehavior.Default);
            }
            catch (Exception e)
            {
                CerrarConexion(cmd.Connection);
                throw e;
            }
        }

        public IDataReader ExecuteReader(DbCommand cmd, List<IDataParameter> Lts)
        {
            foreach (IDataParameter P in Lts)
            {
                cmd.Parameters.Add(P);
            }
            try
            {
                return cmd.ExecuteReader(CommandBehavior.Default);
            }
            catch (Exception e)
            {
                CerrarConexion(cmd.Connection);
                throw e;
            }
        }

        public IDataReader ExecuteReader(DbCommand cmd, IDataParameter Param)
        {
            cmd.Parameters.Add(Param);
            try
            {
                return cmd.ExecuteReader(CommandBehavior.Default);
            }
            catch (Exception e)
            {
                CerrarConexion(cmd.Connection);
                throw e;
            }
        }


        public object ExecuteScalar(DbCommand cmd, List<IDataParameter> Lts)
        {
            foreach (IDataParameter P in Lts)
            {
                cmd.Parameters.Add(P);
            }
            try
            {
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                CerrarConexion(cmd.Connection);
                throw e;
            }
        }


        public object ExecuteScalar(DbCommand cmd)
        {
            try
            {
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                CerrarConexion(cmd.Connection);
                throw e;
            }
        }
        

        protected bool getDBoolean(object Value)
        {
            string V = (string)Value;
            if (V == "T")
                return true;
            return false;
        }

        protected char setDBoolean(bool Value)
        {
            if (Value)
                return 'T';
            return 'F';
        }

      

      
        
        protected void CerrarConexion(IDbConnection CN)
        {
            if (CN.State == ConnectionState.Open)
                CN.Close();
        }

        protected void CerrarConexion(IDbConnection CN,bool xVar)
        {
            if (CN.State == ConnectionState.Open && xVar)
                CN.Close();
        }
        protected DateTime getFechaFromReader(IDataReader rd)
        {
            DateTime ztmp = DateTime.MinValue;
            try
            {
                ztmp = Convert.ToDateTime((rd["FECHA"] is DBNull ? DateTime.MinValue : rd["FECHA"]));
                return ztmp;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la fecha", ex);
            }
        }


        protected abstract MovimientoGeneral getMovimientoFromReader(IDataReader Reader);
        
            
       


        protected string FechaSQL()
        {
#if DEBUG
            return "yyyyMMdd";
#else
            return "yyyyMMdd";
#endif

        }



    }
}
