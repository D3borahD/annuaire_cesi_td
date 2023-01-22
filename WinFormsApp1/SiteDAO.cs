using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class siteDAO
    {
        public static async Task<List<Site>> getSites()
        {
            var url = "Sites";
           
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Site> sites = await response.Content.ReadAsAsync<List<Site>>();    
                    return sites.ToList();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
     
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
        public static async Task addSite(Site site)
        {

            var url = "http://127.0.0.1:5163/api/Sites";

            var client = new HttpClient();

           /* var site = new Site{
                id = 100,
                name =  "nouveauSite" 
            };*/

            var stringValues = JsonConvert.SerializeObject(site);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PostAsync("http://127.0.0.1:5163/api/Sites", httpContent);

            if(httpResponse.Content != null)
            {
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
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
