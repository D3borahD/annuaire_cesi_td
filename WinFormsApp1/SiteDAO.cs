using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SiteDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";

        // Version 1 only contains fake data. No connection to actual db yet.
        // public List<Employee> employees = new List<Employee>();

        public List<Site> getAllSites()
        {
            // start with an empty list
            List<Site> returnThese = new List<Site>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("SELECT * FROM site", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Site site = new Site
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1)
                    };
                    returnThese.Add(site);
                }
            }
            connection.Close();
            return returnThese;
        }

        internal int addOneSite(Site site)
        {
            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("INSERT INTO `site`(`name`) VALUES(@name)", connection);

            command.Parameters.AddWithValue("@name", site.name);

            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

    }
}
