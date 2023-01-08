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

        public List<Site> getAllSites()
        {
            List<Site> returnThese = new List<Site>();

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
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
            catch(Exception ex) {
                throw;
            }
          
        }

        internal object getSiteById(int siteId)
        {
            Site site = new Site();
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `site`WHERE site.id = @id", connection);
                command.Parameters.AddWithValue("@id", siteId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        site.name = reader.GetString(1);
                    }
                }
                connection.Close();
                return site;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal int addOneSite(Site site) 
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `site`(`name`) VALUES(@name)", connection);

                command.Parameters.AddWithValue("@name", site.name);

                int newRows = command.ExecuteNonQuery();
                connection.Close();

                return newRows;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le site existe déjà");
                return 0;
            }
        }

        internal int deleteSite(int idSelectedSite)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM `site` WHERE `site`.`id` = @id; ", connection);
                command.Parameters.AddWithValue("@id", idSelectedSite);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal int updateSite(Site site)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "UPDATE `site` SET `name`= @name WHERE id = @id";
                command.Connection = connection;
                command.Parameters.AddWithValue("@name", site.name);
                command.Parameters.AddWithValue("@id", site.id);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Le site existe déjà");
                return 0;
            }
            
        }
    }
}
