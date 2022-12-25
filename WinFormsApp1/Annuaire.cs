using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Annuaire : Form
    {
        BindingSource employeeBindingSource = new BindingSource();

        public Annuaire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            //Employee employee1 = new Employee
           // {
               // id = 1,
               // firstname = "Jean",
              //  lastname = "Dipon",
              //  landline = "0598674325",
                //mobile = "0798764325",
                //email = "j.dipon",
           // };
           // Employee employee2 = new Employee
          //  {
               // id = 2,
             //   firstname = "Richard",
            //    lastname = "Repon",
               // landline = "0598674325",
              //  mobile = "0798764325",
              //  email = "r.repon",
           // };

           // employeeDAO.employees.Add(employee1);
           // employeeDAO.employees.Add(employee2);

            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.getAllEmployees();

            dataGridView1.DataSource = employeeBindingSource;
        }

        private void Annuaire_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();

            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.searchName(textBox1.Text);

            dataGridView1.DataSource = employeeBindingSource;
        }
    }
}
