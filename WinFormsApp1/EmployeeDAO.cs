using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class EmployeeDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";

        // Version 1 only contains fake data. No connection to actual db yet.
       // public List<Employee> employees = new List<Employee>();

        public List<Employee> getAllEmployees()
        {
            // start with an empty list
            List<Employee> returnThese = new List<Employee>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
          connection.Open();

            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("SELECT * FROM employee", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee emp = new Employee
                    {
                        id = reader.GetInt32(0),
                        firstname = reader.GetString(1),
                        lastname = reader.GetString(2),
                        landline = reader.GetString(3),
                        mobile = reader.GetString(4),
                        email = reader.GetString(5)
                    };
                    returnThese.Add(emp);
                }
            }
            connection.Close();
            return returnThese;
        }
        public List<Employee> searchName(String searchName)
        {
            // start with an empty list
            List<Employee> returnThese = new List<Employee>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchWildPhrase = "%" + searchName + "%";
            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM employee WHERE lastname LIKE @search"; 
            command.Parameters.AddWithValue("@search",searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee emp = new Employee
                    {
                        id = reader.GetInt32(0),
                        firstname = reader.GetString(1),
                        lastname = reader.GetString(2),
                        landline = reader.GetString(3),
                        mobile = reader.GetString(4),
                        email = reader.GetString(5)
                    };
                    returnThese.Add(emp);
                }
            }
            connection.Close();
            return returnThese;

        }
    }
}
 
