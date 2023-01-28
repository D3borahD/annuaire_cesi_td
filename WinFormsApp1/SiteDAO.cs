using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Security.Policy;
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
            var stringValues = JsonConvert.SerializeObject(site);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PostAsync(ApiHelper.url + "Sites", httpContent);

            if(httpResponse.Content != null)
            {
                try
                {
                     var responseContent = await httpResponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        public async Task<string> deleteSite(string id)
        {
           
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync(ApiHelper.url + "Sites/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public async Task updateSite(int id, Site site)
        {
            var stringValues = JsonConvert.SerializeObject(site);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PutAsync(ApiHelper.url + "Sites/"+id, httpContent);

            if (httpResponse.Content != null)
            {
                try
                {
                    var responseContent = await httpResponse.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
