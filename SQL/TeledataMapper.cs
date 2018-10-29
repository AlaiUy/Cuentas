using Aguiñagalde.Entidades;
using Aguiñagalde.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Aguiñagalde.SQL
{
    public class TeledataMapper : DataAccess, ImapperTeledata
    {
        private IDbConnection _MySQL;

        private IDbConnection MySQL
        {
            get
            {
                if (_MySQL == null)
                {
                    _MySQL = new MySqlConnection(MySQLConnectionString);
                }
                return _MySQL;
            }

        }

        public void Add(object o)
        {
            throw new NotImplementedException();
        }

        public void BorrarCliente(int xIdCliente, int xCampania)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new MySqlParameter("@ID", xIdCliente));
            P.Add(new MySqlParameter("@CMP", xCampania));
            if (MySQL.State == System.Data.ConnectionState.Closed)
            {
                MySQL.Open();
                DbCommand Command = new MySqlCommand("DELETE from clientes where id_client = @ID and id_campania = @CMP", (MySqlConnection)MySQL);
                ExecuteNonQuery(Command, P);
                CerrarConexion(MySQL);
            }
         
        }

        public DataTable ClientesMYSQL()
        {
           
            DbCommand Command = new MySqlCommand("select id,apellido,direccion,llamar,id_campania,llamar1,llamar3,id_client,terminado from clientes", (MySqlConnection)MySQL);
            if (MySQL.State == System.Data.ConnectionState.Closed)
            {
                //_MySQL.ConnectionString = "Server = 172.22.20.227; Port = 3306; Database = callcenter; Uid = aguinagalde;Pwd = aGu1.nIAg,aLDe!;";
                MySQL.Open();
                DataTable DT = new DataTable();
                DT.Load(ExecuteReader(Command));
                CerrarConexion(MySQL);
                return DT;
            }
            return null;
        }

        public void Delete(object o)
        {
            throw new NotImplementedException();
        }

        public bool ExisteCliente(int xIdCliente,int xCampania)
        {
            List<IDataParameter> P = new List<IDataParameter>();
            P.Add(new MySqlParameter("@ID", xIdCliente));
            P.Add(new MySqlParameter("@CMP", xCampania));
            if (MySQL.State == System.Data.ConnectionState.Closed)
            {
                MySQL.Open();
                DbCommand Command = new MySqlCommand("SELECT IFNULL(id_client,0) from clientes where id_client = @ID and id_campania = @CMP", (MySqlConnection)MySQL);
                int idClient = Convert.ToInt32(ExecuteScalar(Command, P));
                if ( idClient > 0)
                {
                    CerrarConexion(MySQL);
                    return true;
                }
                CerrarConexion(MySQL);
            }
            return false;
        }

        public void setIngresarLlamada(object xCliente,int xIdCampania)
        {
            ClienteActivo C = (ClienteActivo)xCliente;
            List<IDataParameter> P = new List<IDataParameter>();
            
            P.Add(new MySqlParameter("@CEDULA", C.IdCliente));
            P.Add(new MySqlParameter("@NOMBRE", C.Nombre));
            P.Add(new MySqlParameter("@DIRECCION", C.Direccion));
            P.Add(new MySqlParameter("@CELULAR", C.Celular));
            P.Add(new MySqlParameter("@ALTERNATIVO", C.Telefono));
            P.Add(new MySqlParameter("@CAMPANIA", xIdCampania));
            if (MySQL.State == System.Data.ConnectionState.Closed)
            {
                MySQL.Open();
                
                DbCommand Command = new MySqlCommand("INSERT INTO clientes(nombre,direccion,telefono,telefono2,id_campania,llamar,id_client,terminado) values (@NOMBRE,@DIRECCION,@CELULAR,@ALTERNATIVO,@CAMPANIA,1,@CEDULA,0)", (MySqlConnection)MySQL);
                ExecuteNonQuery(Command, P);
                CerrarConexion(MySQL);
            }
        }

        public void Update(object o)
        {
            throw new NotImplementedException();
        }

        protected override MovimientoGeneral getMovimientoFromReader(IDataReader Reader)
        {
            throw new NotImplementedException();
        }
    }
}
