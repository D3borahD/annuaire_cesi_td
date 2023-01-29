using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DepartmentDAO
    {
        public static async Task<List<Department>> getDepartments()
        {
            var url = "Departments";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<Department> departments = await response.Content.ReadAsAsync<List<Department>>();
                    return departments.ToList();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<Department> getDepartmentById(int id)
        {
            var url = "Departments/" + id;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Department department = await response.Content.ReadAsAsync<Department>();
                    return department;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task addDepartment(Department department)
        {
            var stringValues = JsonConvert.SerializeObject(department);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PostAsync(ApiHelper.url + "Departments", httpContent);

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
        
        public async Task<String> deleteDepartment(int id)
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

        public async Task updateDepartment(int id, Department department)
        {
            var stringValues = JsonConvert.SerializeObject(department);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PutAsync(ApiHelper.url + "Departments/" + id, httpContent);

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
