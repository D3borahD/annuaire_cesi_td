﻿using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public List<JObject> searchName(String searchName)
        {
            List<JObject> returnThese = new List<JObject>();


            var connection = DBConnection.Connection;
            connection.Open();

            try
            {
                String searchWildPhrase = "%" + searchName + "%";
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "SELECT employee.id as employee_id, `lastname`, `firstname`, `landline`, `mobile`, `email`, site.name as site_name, department.name FROM `employee` JOIN site on site_id = site.id JOIN department on department_id = department.id  WHERE lastname LIKE @search;";
                command.Parameters.AddWithValue("@search", searchWildPhrase);
                command.Connection = connection;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JObject emp = new JObject();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            emp.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                        }
                        returnThese.Add(emp);
                    }
                }
                connection.Close();
                return returnThese;
            }
            catch (MySqlException ex)
            {
                throw;
            }
        }

        public static async Task addOneEmployee(Employee employee)
        {

          //  string idEmployee = id.ToString();

            var stringValues = JsonConvert.SerializeObject(employee);

            var httpContent = new StringContent(stringValues, Encoding.UTF8, "application/json");

            var httpClient = new HttpClient();

            var httpResponse = await httpClient.PutAsync("http://127.0.0.1:5163/api/Employees/", httpContent);

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



            // MySqlConnection connection = new MySqlConnection(connectionString);
            // connection.Open();

            /*  var connection = DBConnection.Connection;
              connection.Open();

              try
              {
                  MySqlCommand command = new MySqlCommand("INSERT INTO `employee`( `lastname`,`firstname`, `landline`, `mobile`, `email`, `site_id`, `department_id`) VALUES(@firstname, @lastname, @landline, @mobile, @email, @site, @department)", connection);
                  command.Parameters.AddWithValue("@firstname", employee.firstname);
                  command.Parameters.AddWithValue("@lastname", employee.lastname);
                  command.Parameters.AddWithValue("@landline", employee.landline);
                  command.Parameters.AddWithValue("@mobile", employee.mobile);
                  command.Parameters.AddWithValue("@email", employee.email);
                  command.Parameters.AddWithValue("@site", employee.site);
                  command.Parameters.AddWithValue("@department", employee.department);

                  int newRows = command.ExecuteNonQuery();
                  connection.Close();
                  return newRows;
              }
              catch (MySqlException ex)
              {
                  throw;
              }*/
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

        // Get employee with Site search
        public List<JObject> getEmployeesUsingJoin(int site_id)
        {           
            List<JObject> returnThese = new List<JObject>();

            // MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            var connection = DBConnection.Connection;
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand();

                command.CommandText = "SELECT employee.id as employee_id, `lastname`, `firstname`, `landline`, `mobile`, `email`, site.name as site_name, department.name FROM `employee` JOIN site on site_id = site.id JOIN department on department_id = department.id  WHERE site_id = @site_id;";
                command.Parameters.AddWithValue("@site_id", site_id);
                command.Connection = connection;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JObject newEmployee = new JObject();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            newEmployee.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                        }
                        returnThese.Add(newEmployee);
                    }
                }
                connection.Close();
                return returnThese;
            }
            catch (MySqlException ex)
            {
                throw;
            }
        }

        // get employee with department search 
        public List<JObject> getEmployeesUsingJoinDepartment(int department_id)
        {
            List<JObject> returnThese = new List<JObject>();

            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            var connection = DBConnection.Connection;
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "SELECT employee.id as employee_id,  `lastname`, `firstname`, `landline`, `mobile`, `email`, site.name as site_name, department.name FROM `employee` JOIN site on site_id = site.id JOIN department on department_id = department.id  WHERE department_id = @department_id;";

                command.Parameters.AddWithValue("@department_id", department_id);
                command.Connection = connection;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        JObject newEmployee = new JObject();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            newEmployee.Add(reader.GetName(i).ToString(), reader.GetValue(i).ToString());
                        }
                        returnThese.Add(newEmployee);
                    }
                }
                connection.Close();
                return returnThese;
            }
            catch(MySqlException ex)
            {
                throw;
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
            //MySqlConnection connection = new MySqlConnection(connectionString);
            // connection.Open();

            /*  var connection = DBConnection.Connection;
              connection.Open();

              try
              {
                  MySqlCommand command = new MySqlCommand();
                  command.CommandText = "UPDATE `employee` " +
                      "SET " +
                      "`lastname`= @lastname," +
                      "`firstname`= @firstname," +
                      "`landline`= @landline," +
                      "`mobile`= @mobile," +
                      "`email`= @email," +
                      "`site_id`= @site," +
                      "`department_id`= @department" +
                      " WHERE `id`= @id";

                  command.Connection = connection;
                  command.Parameters.AddWithValue("@firstname", employee.firstname);
                  command.Parameters.AddWithValue("@lastname", employee.lastname);
                  command.Parameters.AddWithValue("@landline", employee.landline);
                  command.Parameters.AddWithValue("@mobile", employee.mobile);
                  command.Parameters.AddWithValue("@email", employee.email);
                  command.Parameters.AddWithValue("@site", employee.site);
                  command.Parameters.AddWithValue("@department", employee.department);
                  command.Parameters.AddWithValue("@id", employee.id);

                  int result = command.ExecuteNonQuery();
                  connection.Close();
                  return result;
              }
              catch (MySqlException ex)
              {
                  throw;
              }*/
        }

     
    }
}
 
