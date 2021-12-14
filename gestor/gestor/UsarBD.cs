using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor
{
    public class UsarBD
    {
        public static SqlException exSalida;

        public static string SqlConnection()
        {
            string line = "";
            int nBD = ConfigurationManager.ConnectionStrings.Count;
            if (nBD > 0)
            {
                line = ConfigurationManager.ConnectionStrings[nBD - 1].ConnectionString;
            }
            return line;
        }
        public static SqlConnection ConexionBD(string stringConexion)
        {
            SqlConnection con = new SqlConnection(stringConexion);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                con.Close();
                exSalida = ex;
                return null;
            }
            return con;
        }
        public static SqlDataReader ConsultaSQL(string seletLine, SqlConnection con)
        {
            SqlDataReader leer = null;
            SqlCommand consulta = new SqlCommand(seletLine, con);
            try
            {
                leer = consulta.ExecuteReader();
            }
            catch (SqlException ex)
            {
                con.Close();
                exSalida = ex;
                return null;
            }
            return leer;
        }
        public static int InsertSql(string sql, SqlConnection con)
        {
            int exito = 0;
            string intert = sql;
            SqlCommand ins = new SqlCommand(intert, con);
            exito = ins.ExecuteNonQuery();
            con.Close();
            return exito;
        }
        public static int UpdateSql(string line, SqlConnection con)
        {
            int exito = 0;
            string update = line;
            SqlCommand command = new SqlCommand(update, con);
            exito = command.ExecuteNonQuery();
            con.Close();
            return exito;
        }
    }
}
