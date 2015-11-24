using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class DB : IDisposable
    {
        private SqlConnection connection;

        public DB()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlserver"].ConnectionString);
            connection.Open();
        }

        public void ExecutaComando(SqlCommand command)
        {
            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        public SqlDataReader ExecutaComandoRetorno(SqlCommand command)
        {
            SqlDataAdapter ad = new SqlDataAdapter();
            command.Connection = connection;
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

        }
    }
