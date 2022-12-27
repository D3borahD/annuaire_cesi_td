using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class DepartmentDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";

        // Version 1 only contains fake data. No connection to actual db yet.
        // public List<Employee> employees = new List<Employee>();

        public List<Department> getAllDepartments()
        {
            // start with an empty list
            List<Department> returnThese = new List<Department>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("SELECT * FROM department", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Department dep = new Department
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1)
                    };
                    returnThese.Add(dep);
                }
            }
            connection.Close();
            return returnThese;
        }

        internal int addOneDepartment(Department department)
        {
            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("INSERT INTO `department`(`name`) VALUES(@name)", connection);

            command.Parameters.AddWithValue("@name", department.name);
         
            int newRows = command.ExecuteNonQuery();
            connection.Close();
            return newRows;
        }

        // Don't work => foreignkey pb
        //internal int deleteDepartment(int departmentId)
        //{
            // connect to the mysql server
           // MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();
            // define the sql statement to fetch all employees
           // MySqlCommand command = new MySqlCommand("DELETE FROM `department` WHERE `department`.`id` = @id; ", connection);

            //command.Parameters.AddWithValue("@id", departmentId);
          

           // int result = command.ExecuteNonQuery();
           // connection.Close();
           // return result;
        //}
    }
}
