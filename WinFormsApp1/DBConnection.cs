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

        private static string connnectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";
        // IT WORK !!!
           static MySqlConnection db = null;

           static MySqlConnection CreateConnection()
           {
               var db = new MySqlConnection(connnectionString);
                //db.Open();
               return db;
           }

        static void CloseConnection()
        {
            if (db != null) { db.Close(); db = null; }
        }

           public static MySqlConnection Connection { 
               get { 
                   if (db == null)
                   {
                       LazyInitializer.EnsureInitialized(ref db, CreateConnection);
                   }
                   return db; }
           }




        
        
        /*  private static MySqlConnection connection = new MySqlConnection(connectionString);
        private static string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";
        private MySqlConnection() { }
        public static MySqlConnection Connection { get { return connection; } }

        public void DoThat() {
            MessageBox.Show("test");
        }
      
   

      /*  public static MySqlConnection GetConnection()
        {

          try
         {
                if (connection == null)
                {
                    // Connection = new MySqlConnection(connectionString);

                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                   
                };
                MessageBox.Show("ok !!!");
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
      /*   }
         catch (Exception e)
         {
             Console.WriteLine(e.Message);
              MessageBox.Show(e.StackTrace + "erreur je plante !!!");
             throw;
         }
        }*/

    }
}
