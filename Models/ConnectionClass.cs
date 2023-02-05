using System.Data.SqlClient;
using System.IO;
using WebApiApp.Controllers;

namespace WebApiApp.Models
{
    class ConnectionClass
    {
        private string _connectionString;
        SqlConnection sqlConnection = new SqlConnection(GetConnectionStringClass.GetConnectionString());
        ConnectionClass() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                    sqlConnection.Open();
            }
        }
        ~ConnectionClass(){
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
