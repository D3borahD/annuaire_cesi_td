//using Microsoft.VisualBasic;
//using MySql.Data.MySqlClient;
//using MySqlX.XDevAPI;
using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using Org.BouncyCastle.Utilities.Collections;
//using System;
//using System.Collections.Generic;
//using System.Collections.Immutable;
//using System.Data;
//using System.Linq;
//using System.Net.Http;
//using System.Net.NetworkInformation;
//using System.Reflection;
using System.Text;
//using System.Threading.Tasks;
//using WinFormsApp1.Model;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    internal class EmployeeDAO
    {
        public static async Task<String> getAllEmployees()
        {
          //  var url = "Employees";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://127.0.0.1:5163/api/Employees"))
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
        
        public static async Task<string> getEmployeesByName(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://127.0.0.1:5163/api/Employees/lastname/" + name))
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
            
                return string.Empty;
            }
        }

        public async Task addEmployee(Employee employee)
        {
            
            var stringValues = JsonConvert.SerializeObject(employee);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PostAsync("http://127.0.0.1:5163/api/Employees/", httpContent);

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

        public static async Task<String> getOneEmployee(int employeeId)
        {
            string id = employeeId.ToString();
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://127.0.0.1:5163/api/Employees/" + id))
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

        public static async Task<string> getEmployeesBySite(int site_id)
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://127.0.0.1:5163/api/Employees/site/" + site_id))
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

                return string.Empty;
            }

        }

        public static async Task<string> getEmployeesByDepartment(int department_id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://127.0.0.1:5163/api/Employees/department/" + department_id))
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

                return string.Empty;
            }

        }

        public async Task<String> deleteEmployee(int idSelectedEmployee)
        {
            string id = idSelectedEmployee.ToString();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://127.0.0.1:5163/api/Employees/" + id))
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

        public async Task updateEmployee(int id, Employee employee)
        {
            string idEmployee = id.ToString();

            var stringValues = JsonConvert.SerializeObject(employee);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PutAsync("http://127.0.0.1:5163/api/Employees/" + idEmployee, httpContent);

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
 
