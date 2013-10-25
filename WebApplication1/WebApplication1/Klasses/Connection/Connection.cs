using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Klasses.Connection
{
    public class Connection : IDisposable
    {
        public const string CONNECTION_STRING = "Data Source=JIM-HP\\JIM;Initial Catalog=Project5;Integrated Security=True";//ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString;//"Data Source=JIM-HP\\JIM;Initial Catalog=Project5;Integrated Security=True";

        public SqlConnection MSSQLConnection { set; get; }

        public Connection()
        {
            if ((MSSQLConnection = mssqlTestConnection()) == null)
                this.Dispose();
        }

        private SqlConnection mssqlTestConnection()
        {
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = CONNECTION_STRING;
                connection.Open();
                return connection;
            }
            catch
            {
                connection.Dispose();
                return null;
            }
        }

        public void Dispose()
        {
            if (MSSQLConnection != null)
            {
                MSSQLConnection.Dispose();
            }
        }
    }
}