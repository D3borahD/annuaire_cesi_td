﻿using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminEditor : Form
    {
        BindingSource employeeBindingSource = new BindingSource();
        BindingSource siteBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();

        public AdminEditor()
        {
            InitializeComponent();
        }

        private void loadDataDepartment()
        {
            DepartmentDAO departmentDAO = new DepartmentDAO();
            departmentBindingSource.DataSource = departmentDAO.getAllDepartments();
            dataGridViewDepartmentEdit.DataSource = departmentBindingSource;
            dataGridViewDepartmentEdit.Columns["id"].Visible = false;
            dataGridViewDepartmentEdit.Columns[1].HeaderText = "Nom du Service";
        }

        private void loadDataSite()
        {
            SiteDAO siteDAO = new SiteDAO();
            // connect the list to the grid view control
            siteBindingSource.DataSource = siteDAO.getAllSites();
            dataGridViewSiteEdit.DataSource = siteBindingSource;
            dataGridViewSiteEdit.Columns["id"].Visible = false;
            dataGridViewSiteEdit.Columns[1].HeaderText = "Nom du Site";
        }

        private void loadDataEmployee()
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeBindingSource.DataSource = employeeDAO.getAllEmployees();
            dataGridViewEmployeeEdit.DataSource = employeeBindingSource;
            dataGridViewEmployeeEdit.Columns[0].Visible = false;
            dataGridViewEmployeeEdit.Columns[1].HeaderText = "Prénom";
            dataGridViewEmployeeEdit.Columns[2].HeaderText = "Nom";
            dataGridViewEmployeeEdit.Columns[3].HeaderText = "Téléphone fixe";
            dataGridViewEmployeeEdit.Columns[4].HeaderText = "Mobile";
            dataGridViewEmployeeEdit.Columns[5].HeaderText = "Email";
            dataGridViewEmployeeEdit.Columns[6].HeaderText = "Site";
            dataGridViewEmployeeEdit.Columns[7].HeaderText = "Service";
        }

        private void loadListBoxSite()
        {
            SiteDAO siteDAO = new SiteDAO();
            siteBindingSource.DataSource = siteDAO.getAllSites();
            listBoxSite.DataSource = siteBindingSource;
            listBoxSite.DisplayMember = "name";
            listBoxSite.ValueMember = "id";
        }

        private void loadListBoxDepartment()
        {
            DepartmentDAO departmentDAO = new DepartmentDAO();
            departmentBindingSource.DataSource = departmentDAO.getAllDepartments();
            listBoxDepartment.DataSource = departmentBindingSource;
            listBoxDepartment.DisplayMember = "name";
            listBoxDepartment.ValueMember = "id";
        }

        private void AdminEditor_Load_1(object sender, EventArgs e)
        {
            loadDataEmployee();
            loadDataSite();
            loadDataDepartment();
            loadListBoxSite();
            loadListBoxDepartment();
        }

      
        private void add_employee_Click(object sender, EventArgs e)
        {
           Regex numberRegex = new Regex("^[0-9]+$");
            String fixNumber = txt_employee_landline.Text;
            //int countNumber = fixNumber.Split().Length + 1;
            String mobileNumber = txt_employee_mobile.Text;


            String formatFirstname = txt_employee_firstname.Text;
            formatFirstname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(formatFirstname.ToLower());

            String getFirstletter = formatFirstname.Substring(0, 1);
            String createEmail = (getFirstletter + "." + txt_employee_lastname.Text + "@agro.bio").ToLower();
           
            

            if (!numberRegex.IsMatch(fixNumber) && !numberRegex.IsMatch(mobileNumber))
                 {
                MessageBox.Show("Le numéro de téléphone fixe doit comporter uniqument des chiffres");
            }
           // else if (countNumber != 10)
            //{
              //  MessageBox.Show("Le numéro ne comporte pas 10 chiffres");
            //}
           else 
            if (
                String.IsNullOrEmpty(txt_employee_lastname.Text) ||
                String.IsNullOrEmpty(txt_employee_firstname.Text) ||
                String.IsNullOrEmpty(txt_employee_landline.Text) ||
                String.IsNullOrEmpty(txt_employee_mobile.Text) 
                )
            {
                MessageBox.Show("Erreur : au moins un champ est vide");
            }
            else
            {
                Employee employee = new Employee
                {
                    lastname = txt_employee_lastname.Text.ToUpper(),
                    firstname = formatFirstname,
                    landline = txt_employee_landline.Text,
                    mobile = txt_employee_mobile.Text,
                    email = createEmail,
                    site = listBoxSite.SelectedValue.ToString(),
                    department = listBoxDepartment.SelectedValue.ToString(),
                };

                EmployeeDAO employeeDAO = new EmployeeDAO();
                int result = employeeDAO.addOneEmployee(employee);

                // clear input form
                // txt_employee_lastname.Clear();
                txt_employee_lastname.Text = String.Empty;
                txt_employee_firstname.Text = String.Empty;
                txt_employee_landline.Text = String.Empty;
                txt_employee_mobile.Text = String.Empty;

                MessageBox.Show("L'employé(e) " + employee.lastname + " " + employee.firstname+ " a été ajouté");

                loadDataEmployee();
            }
        }

        private void addService_Click(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(txt_department_name.Text))
            {
                MessageBox.Show("Erreur : Le champ est vide");
            } 
            else
            {
                // add a new item to the database
                Department department = new Department
                {
                name = txt_department_name.Text,
                };

                DepartmentDAO departmentDAO = new DepartmentDAO();
                int result = departmentDAO.addOneDepartment(department);

                // clear input
                txt_department_name.Text = String.Empty;

                MessageBox.Show("Le service " + department.name + " a été ajouté");

                loadDataDepartment();
            }
        }

        private void addSite_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_site_name.Text))
            {
                MessageBox.Show("Erreur : Le champ est vide");
            } 
            else
            {
                Site site = new Site
            {
                name = txt_site_name.Text,
            };

            SiteDAO siteDAO = new SiteDAO();
            int result = siteDAO.addOneSite(site);

            // clear input
            txt_site_name.Text = String.Empty;

            MessageBox.Show("Le site " + site.name + " a été ajouté");

            loadDataSite();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewEmployeeEdit.CurrentRow.Index;

            // cast don't work ??
            int idSelectedEmployee = int.Parse(dataGridViewEmployeeEdit.Rows[rowClicked].Cells[0].Value.ToString());

            EmployeeDAO employeeDAO = new EmployeeDAO();
            int result = employeeDAO.deleteEmployee(idSelectedEmployee);

            MessageBox.Show("L'employé(e) a été supprimé(e)");
            loadDataEmployee();
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewEmployeeEdit.CurrentRow.Index;
            List<String> userInfo = new List<string>();

            for (int i = 0; i < dataGridViewEmployeeEdit.ColumnCount; i++)
            {
                userInfo.Add(dataGridViewEmployeeEdit.Rows[rowClicked].Cells[i].Value.ToString());
            }

            //int userId = int.Parse(dataGridViewEmployeeEdit.Rows[rowClicked].Cells[0].Value.ToString());

            UpdateEmployee updateEmployee = new UpdateEmployee(userInfo);
            updateEmployee.Show();
        }

        private void dataGridViewEmployeeEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Reference click dataGrid
        }

        private void deleteDepartment_Click(object sender, EventArgs e)
        {

            int rowClicked = dataGridViewDepartmentEdit.CurrentRow.Index;

            int idSelectedDepartment = int.Parse(dataGridViewDepartmentEdit.Rows[rowClicked].Cells[0].Value.ToString());
            string nameSelectedDepartment = dataGridViewDepartmentEdit.Rows[rowClicked].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("ATTENTION : \n\n" + "Si vous supprimez le service : \n" + nameSelectedDepartment + "\nles employé(e)s associé(e)s à ce service seront aussi supprimé(e)s.\nVoulez_vous vraiment supprimer ce service ?", "SUPPRESSION D'UN SERVICE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult  == DialogResult.Yes)
            {
                
                DepartmentDAO departmentDAO = new DepartmentDAO();
                int result = departmentDAO.deleteDepartment(idSelectedDepartment);

                MessageBox.Show("Le service " + nameSelectedDepartment + " a été supprimé(e)");
                loadDataEmployee();
                loadDataDepartment();
            }
            else if(dialogResult == DialogResult.Yes)
            {
                return;
            }
        }
    }
}
