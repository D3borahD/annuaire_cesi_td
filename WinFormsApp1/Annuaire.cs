﻿using System;
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

       // private void button1_Click(object sender, EventArgs e)
       // {
        //    EmployeeDAO employeeDAO = new EmployeeDAO();
          

            // connect the list to the grid view control
        //    employeeBindingSource.DataSource = employeeDAO.getAllEmployees();

        //    dataGridView1.DataSource = employeeBindingSource;
       // }



        private void Annuaire_Load(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();


            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.getAllEmployees();

            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Prénom";
            dataGridView1.Columns[2].HeaderText = "Nom";
            dataGridView1.Columns[3].HeaderText = "Téléphone Fixe";
            dataGridView1.Columns[4].HeaderText = "Mobile";
            dataGridView1.Columns[5].HeaderText = "Email";




        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();

            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.searchName(textBox1.Text);

            dataGridView1.DataSource = employeeBindingSource;
        }

        private void edition_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminEditor();
            adminForm.Show();
        }
    }
}
