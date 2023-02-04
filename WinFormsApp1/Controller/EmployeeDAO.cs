using Newtonsoft.Json;
using System.Text;
using WinFormsApp1.Database;
using WinFormsApp1.Model;

namespace WinFormsApp1.Controller
{
    internal class EmployeeDAO
    {

        // get all employees
        public static async Task<string> getAllEmployees()
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

        // get employees by lastname or some letters of lastname
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

        // add one employee
        public async Task addEmployee(Employee employee)
        {
            string url = "Employees";

            var stringValues = JsonConvert.SerializeObject(employee);
            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");
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

        // get employee by id
        public static async Task<string> getOneEmployee(int employeeId)
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

        // get employees by site
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

        // get employees by department
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

        // delete selected employee
        public async Task<string> deleteEmployee(int idSelectedEmployee)
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

        // update selected employee
        public async Task updateEmployee(int id, Employee employee)
        {
            string idEmployee = id.ToString();
            string url = "Employees/";

            var stringValues = JsonConvert.SerializeObject(employee);
            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

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

