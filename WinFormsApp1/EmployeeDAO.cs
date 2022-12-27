﻿using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    internal class EmployeeDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";


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
                        email = reader.GetString(5),
                        //site.id = reader.GetFieldValue<Site>(6),
                        //department.id = reader.GetFieldValue<Department>(7)
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

        internal int addOneEmployee(Employee employee)
        {
            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee`(`firstname`, `lastname`, `landline`, `mobile`, `email`) VALUES(@firstname, @lastname, @landline, @mobile, @email)", connection);

            command.Parameters.AddWithValue("@firstname", employee.firstname);
            command.Parameters.AddWithValue("@lastname", employee.lastname);
            command.Parameters.AddWithValue("@landline", employee.landline);
            command.Parameters.AddWithValue("@mobile", employee.mobile);
            command.Parameters.AddWithValue("@email", employee.email);

            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        public List<Employee> getOneEmployees(int site_id)
        {
            // start with an empty list
            List<Employee> returnThese = new List<Employee>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("SELECT * FROM employee WHERE site_id = @site_id", connection);
            command.Parameters.AddWithValue("@site_id", site_id);


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
 
