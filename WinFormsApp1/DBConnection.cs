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
        private static MySqlConnection connection;


        public static MySqlConnection GetConnection()
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";

          try
         {
                if (connection == null)
                {
                    // Connection = new MySqlConnection(connectionString);

                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                };
                return connection;
            // MySqlConnection MaConnexion = new(connectionString);
            /* MySqlDataAdapter adapter = new MySqlDataAdapter();

             MySqlCommand cmd = MaConnexion.CreateCommand();
             cmd.CommandText = "SELECT * FROM site";

             adapter.SelectCommand = cmd;

             DataSet dataset = new DataSet();

             adapter.Fill(dataset);
             int nbligne = adapter.Fill(dataset, "site");

             Console.WriteLine($"{nbligne} site ont été trouvé");*/
         }
         catch (Exception e)
         {
             Console.WriteLine(e.Message);
             throw;
         }
        }

    }
}
