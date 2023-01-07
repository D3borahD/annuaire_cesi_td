using MySql.Data.MySqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Annuaire());

           /* string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";

            try
            {
                MySqlConnection MaConnexion = new(connectionString);
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand cmd = MaConnexion.CreateCommand();
                cmd.CommandText = "SELECT * FROM site";

                adapter.SelectCommand = cmd;

                DataSet dataset = new DataSet();

                adapter.Fill(dataset);
                int nbligne = adapter.Fill(dataset, "site");

                Console.WriteLine($"{nbligne} site ont été trouvé");
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
                throw;
            }*/
        }
    }
}