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
        string connectionString = "datasource=192.168.1.76;port=8889;username=root;password=root;database=annuaire;";

        // Version 1 only contains fake data. No connection to actual db yet.
       // public List<Employee> employees = new List<Employee>();

        public List<Employee> getAllEmployees()
        {
            // start with an empty list
            List<Employee> returnThese = new List<Employee>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
          connection.Open();

            return returnThese;

        }
    }
}
