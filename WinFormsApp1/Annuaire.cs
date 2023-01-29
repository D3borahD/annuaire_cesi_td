﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class Annuaire : Form
    {
        BindingSource employeeBindingSource = new BindingSource();
        BindingSource siteBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();
 
        public Annuaire()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private async void loadDataDepartment()
        {
            IList<Department> departmentList = await DepartmentDAO.getDepartments();
            departmentBindingSource.DataSource = departmentList.ToList();

            dataGridViewDepartmentDisplay.DataSource = departmentBindingSource;
            dataGridViewDepartmentDisplay.DefaultCellStyle.SelectionBackColor = Color.Navy;
            dataGridViewDepartmentDisplay.Columns["id"].Visible = false;
            dataGridViewDepartmentDisplay.Columns[1].HeaderText = "Nom du Service";
        }

        private async void loadDataSite()
        {
            IList<Site> siteList = await siteDAO.getSites();
            siteBindingSource.DataSource = siteList.ToList();

            dataGridViewSiteDisplay.DataSource = siteBindingSource;
            dataGridViewSiteDisplay.DefaultCellStyle.SelectionBackColor = Color.Navy;
            dataGridViewSiteDisplay.Columns["id"].Visible = false;
            dataGridViewSiteDisplay.Columns[1].HeaderText = "Nom du Site";
        }

        private async void loadDataEmployee()
        {
            var response = await EmployeeDAO.getAllEmployees();

            var result = JsonConvert.DeserializeObject<List<EmployeeFormated>>(response);

            List<EmployeeFormated> employees = new List<EmployeeFormated>();

            for (int i = 0; i < result.Count; i++)
            {
                var employee = new EmployeeFormated();

                var siteName = await siteDAO.getSiteById(result[i].SiteId);
                String siteN = siteName.name;

                var departmentName = await DepartmentDAO.getDepartmentById(result[i].DepartmentId);
                String departmentN = departmentName.name;

                employee.Id = result[i].Id;
                employee.Firstname = result[i].Firstname;
                employee.Lastname = result[i].Lastname;
                employee.Site = siteN;
                employee.Department = departmentN;
                employees.Add(employee);
             }

            dataGridView1.DataSource = employees;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Navy;
            int count = int.Parse(dataGridView1.Rows.Count.ToString());
            if (count != 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].HeaderText = "Site";
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[8].HeaderText = "Service";
            }
       
        }
     
        private void Annuaire_Load(object sender, EventArgs e)
        {
            loadDataEmployee();
            loadDataDepartment();
            loadDataSite();
   
        }

        // SearchName function 
        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeBindingSource.DataSource = employeeDAO.searchName(textBox1.Text);

            dataGridView1.DataSource = employeeBindingSource;

            int count = int.Parse(dataGridView1.Rows.Count.ToString());
            if (count != 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Site";
                dataGridView1.Columns[7].HeaderText = "Service";
            }

            textBox1.Clear();

        }

        // remove at the end project => button to acces on admin windows during conception
        // remove on Annuaire conception on 08/01/2023
        private void edition_Click(object sender, EventArgs e)
        {
           // var adminForm = new AdminEditor();
           // adminForm.Show();
        }

        private void dataGridViewSiteDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            EmployeeDAO employeeDAO = new EmployeeDAO();

            int rowClicked = dataGridView.CurrentRow.Index;

            employeeBindingSource.DataSource = employeeDAO.getEmployeesUsingJoin((int) dataGridView.Rows[rowClicked].Cells[0].Value);
            dataGridView1.DataSource = employeeBindingSource;

            int count = int.Parse(dataGridView1.Rows.Count.ToString());
            if (count != 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Site";
                dataGridView1.Columns[7].HeaderText = "Service";
            }
        }

        private void dataGridViewDepartmentDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            EmployeeDAO employeeDAO = new EmployeeDAO();

            int rowClicked = dataGridView.CurrentRow.Index;

            employeeBindingSource.DataSource = employeeDAO.getEmployeesUsingJoinDepartment((int)dataGridView.Rows[rowClicked].Cells[0].Value);
            dataGridView1.DataSource = employeeBindingSource;

            int count = int.Parse(dataGridView1.Rows.Count.ToString());
            if (count != 0)
            {
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nom";
                dataGridView1.Columns[2].HeaderText = "Prénom";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Site";
                dataGridView1.Columns[7].HeaderText = "Service";
            }

        }

        public void displayEmplyeeCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int userId = int.Parse(dataGridView1.Rows[rowClicked].Cells[0].Value.ToString());
             
              EmployeeCardView employeeCardView = new EmployeeCardView(userId);
              employeeCardView.Show(); 
        }

        private void AdminAcces_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control && e.KeyCode == Keys.E)
            {
                var adminConnection = new AdminConnection();
                adminConnection.Show();
            }
        }
    }
}
