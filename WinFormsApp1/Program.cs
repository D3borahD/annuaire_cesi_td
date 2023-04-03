//using MySql.Data.MySqlClient;
//using System.Data;
using WinFormsApp1.Database;

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

            // initialise ApiHelper
            ApiHelper.InitializeClient();
            Application.Run(new Annuaire());

        }

      
    }
}