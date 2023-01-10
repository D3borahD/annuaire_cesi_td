using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DBConnection
    {
        private static string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";

        static MySqlConnection connection = null;

        public static MySqlConnection CreateConnection()
        {
            var connection = new MySqlConnection(connectionString);
            return connection;
        }

        static void CloseConnection()
        {
            if(connection != null) {
                connection.Close();
                connection = null;
            }
        }

        public static MySqlConnection Connection
        {
            get
            {
                try
                {
                    if (connection == null)
                    {
                        LazyInitializer.EnsureInitialized(ref connection, CreateConnection);
                    }
                    return connection;
                }
                catch (Exception ex)
                {
                    CloseConnection();
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
