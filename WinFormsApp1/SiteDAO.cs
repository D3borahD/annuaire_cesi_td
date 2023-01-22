using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SiteDAO

       
    {

        public static async Task<List<Site>> getSites()
        {
            var url = "Sites";
           
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
               // MessageBox.Show("mon site" );
                if (response.IsSuccessStatusCode)
                {
                    List<Site> sites = await response.Content.ReadAsAsync<List<Site>>();
                    // MessageBox.Show("succes");
                   // foreach (Site s in sites )
                   // {
                     //   MessageBox.Show("succes");
                      //  s = await response.Content.ReadAsAsync<Site>();
                       // sites.Add(s);
                      //  MessageBox.Show("mon site" + s);
                  //  }
                   
                    return sites.ToList();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

       /* public List<Site> getAllSites()
        {
            List<Site> returnThese = new List<Site>();

            // MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            var connection = DBConnection.Connection;
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
          
        }*/

     
        public static async Task<Site> getSiteById(int id)
        {
            var url = "Sites/" + id;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Site site = await response.Content.ReadAsAsync<Site>();
                    return site;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }



        internal int addOneSite(Site site) 
        {
            // MySqlConnection connection = new MySqlConnection(connectionString);
            // connection.Open();

            var connection = DBConnection.Connection;
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
            // MySqlConnection connection = new MySqlConnection(connectionString);
            // connection.Open();

            var connection = DBConnection.Connection;
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
           // MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            var connection = DBConnection.Connection;
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
