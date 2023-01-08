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
        //string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=annuaire;";

        public List<Department> getAllDepartments()
        {
            List<Department> returnThese = new List<Department>();

            // MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();
            var connection = DBConnection.Connection;
            connection.Open();

            try
            {
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
            catch (MySqlException ex)
            {
                throw;
            }
        }

        internal int addOneDepartment(Department department)
        {
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();
            var connection = DBConnection.Connection;
            connection.Open(); 

            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `department`(`name`) VALUES(@name)", connection);
                command.Parameters.AddWithValue("@name", department.name);

                int newRows = command.ExecuteNonQuery();
                connection.Close();
                return newRows;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Le service existe déjà");
                return 0;
            }
           
        }
        
        internal int deleteDepartment(int departmentId)
        {
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            var connection = DBConnection.Connection;
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM `department` WHERE `department`.`id` = @id; ", connection);
                command.Parameters.AddWithValue("@id", departmentId);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            catch (MySqlException ex)
            {
                throw;
            }
        }

        internal object getDepartmentById(int departmentId)
        {
            Department department = new Department();
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            var connection = DBConnection.Connection;
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `department`WHERE department.id = @id", connection);
                command.Parameters.AddWithValue("@id", departmentId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        department.name = reader.GetString(1);
                    }
                }
                connection.Close();
                return department;
            }
            catch (MySqlException ex)
            {
                throw;
            }

        }

        internal int updateDepartment(Department department)
        {
            //MySqlConnection connection = new MySqlConnection(connectionString);
            //connection.Open();

            var connection = DBConnection.Connection;
            connection.Open();

            try
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "UPDATE `department` SET `name`= @name WHERE id = @id";
                command.Connection = connection;
                command.Parameters.AddWithValue("@name", department.name);
                command.Parameters.AddWithValue("@id", department.id);

                int result = command.ExecuteNonQuery();
                connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le service existe déjà");
                return 0;
            }
          
        }
    }
}
