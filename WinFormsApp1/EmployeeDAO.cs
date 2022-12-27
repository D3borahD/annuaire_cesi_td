using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
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
            MySqlCommand command = new MySqlCommand("SELECT `id`, `firstname`, `lastname`,`landline`, `mobile`, `email`, `site_id`, `department_id` FROM employee", connection);

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
                       // department.id = reader.GetFieldValue<Department>(7)
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
            MySqlCommand command = new MySqlCommand("INSERT INTO `employee`(`firstname`, `lastname`, `landline`, `mobile`, `email`, `site_id`, `department_id`) VALUES(@firstname, @lastname, @landline, @mobile, @email, @site, @department)", connection);

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

        public List<JObject> getEmployeesUsingJoin(int site_id)
        {
            // start with an empty list
            List<JObject> returnThese = new List<JObject>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT `firstname`, `lastname`, `landline`, `mobile`, `email`, site.name, department_id FROM `employee` JOIN site on site_id = site.id WHERE site_id = @site_id";

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

        public List<JObject> getEmployeesUsingJoinDepartment(int department_id)
        {
            // start with an empty list
            List<JObject> returnThese = new List<JObject>();

            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT `firstname`, `lastname`, `landline`, `mobile`, `email`, site_id, department.name FROM `employee` JOIN department on department_id = department.id WHERE department_id = @department_id";

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

        internal int deleteEmployee(int idSelectedEmployee)
        {
            // connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            // define the sql statement to fetch all employees
            MySqlCommand command = new MySqlCommand("DELETE FROM `employee` WHERE `employee`.`id` = @id;", connection);

            command.Parameters.AddWithValue("@id", idSelectedEmployee);
           
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

       // internal int updateEmployee(int idSelectedEmployee)
      //  {
            // connect to the mysql server
           // MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();
            // define the sql statement to fetch all employees
           // MySqlCommand command = new MySqlCommand("DELETE FROM `employee` WHERE `employee`.`id` = @id;", connection);

           // command.Parameters.AddWithValue("@id", idSelectedEmployee);
            //command.Parameters.AddWithValue("@firstname", employee.firstname);
            //command.Parameters.AddWithValue("@lastname", employee.lastname);
            //command.Parameters.AddWithValue("@landline", employee.landline);
           // command.Parameters.AddWithValue("@mobile", employee.mobile);
           // command.Parameters.AddWithValue("@email", employee.email);
           // command.Parameters.AddWithValue("@site", employee.site);
          //  command.Parameters.AddWithValue("@department", employee.department);

          //  int result = command.ExecuteNonQuery();
           // connection.Close();
           // return result;
      //  }
    }
}
 
