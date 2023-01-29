//using Microsoft.VisualBasic;
//using MySql.Data.MySqlClient;
//using MySqlX.XDevAPI;
using Newtonsoft.Json;
using System.Security.Policy;
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
            var url = "Employees";

                using (HttpResponseMessage res = await ApiHelper.ApiClient.GetAsync(url))
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
        
        public static async Task<string> getEmployeesByName(string name)
        {
            string url = "Employees/lastname/";
          
                using (HttpResponseMessage res = await ApiHelper.ApiClient.GetAsync(url + name))
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

        public async Task addEmployee(Employee employee)
        {
            
            var stringValues = JsonConvert.SerializeObject(employee);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            string url = "Employees";

            var httpResponse = await ApiHelper.ApiClient.PostAsync(url, httpContent);

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
            string url = "Employees/";
            
                using (HttpResponseMessage res = await ApiHelper.ApiClient.GetAsync(url + id))
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

        public static async Task<string> getEmployeesBySite(int site_id)
        {

            string url = "Employees/site/";
                using (HttpResponseMessage res = await ApiHelper.ApiClient.GetAsync(url + site_id))
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

        public static async Task<string> getEmployeesByDepartment(int department_id)
        {

            string url = "Employees/Department/";
                using (HttpResponseMessage res = await ApiHelper.ApiClient.GetAsync(url + department_id))
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

        public async Task<String> deleteEmployee(int idSelectedEmployee)
        {
            string id = idSelectedEmployee.ToString();
            string url = "Employees/";
            
                using (HttpResponseMessage res = await ApiHelper.ApiClient.DeleteAsync(url + id))
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

        public async Task updateEmployee(int id, Employee employee)
        {
            string idEmployee = id.ToString();

            var stringValues = JsonConvert.SerializeObject(employee);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            string url = "Employees/";

            var httpResponse = await ApiHelper.ApiClient.PutAsync(url + idEmployee, httpContent);

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
 
