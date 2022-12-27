using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dataGridViewEmployeeEdit.Columns["id"].Visible = false;
            dataGridViewEmployeeEdit.Columns[1].HeaderText = "Prénom";
            dataGridViewEmployeeEdit.Columns[2].HeaderText = "Nom";
            dataGridViewEmployeeEdit.Columns[3].HeaderText = "Téléphone Fixe";
            dataGridViewEmployeeEdit.Columns[4].HeaderText = "Mobile";
            dataGridViewEmployeeEdit.Columns[5].HeaderText = "Email";
            dataGridViewEmployeeEdit.Columns[6].HeaderText = "Site";
            dataGridViewEmployeeEdit.Columns[7].HeaderText = "Service";
        }

        private void AdminEditor_Load_1(object sender, EventArgs e)
        {
            loadDataEmployee();
            loadDataSite();
            loadDataDepartment();
        }

        private void add_employee_Click(object sender, EventArgs e)
        {
           //Regex numberRegex = new Regex("^[0-9]+$");
           // String fixNumber = txt_employee_landline.Text;
            //int countNumber = fixNumber.Split().Length + 1;
           // String mobileNumber = txt_employee_mobile.Text;

            //Console.WrteLine(coun);

          //  if (!numberRegex.IsMatch(fixNumber) && !numberRegex.IsMatch(mobileNumber))
               //  {
           //     MessageBox.Show("Le numéro de téléphone fixe doit comporter uniqument des chiffres");
          //  }
           // else if (countNumber != 10)
            //{
              //  MessageBox.Show("Le numéro ne comporte pas 10 chiffres");
            //}
           // else 
            if (
                String.IsNullOrEmpty(txt_employee_lastname.Text) ||
                String.IsNullOrEmpty(txt_employee_firstname.Text) ||
                String.IsNullOrEmpty(txt_employee_landline.Text) ||
                String.IsNullOrEmpty(txt_employee_mobile.Text) ||
                String.IsNullOrEmpty(txt_employee_email.Text) ||
                String.IsNullOrEmpty(txt_employee_site.Text) ||
                String.IsNullOrEmpty(txt_employee_service.Text)
                )
            {
                MessageBox.Show("Erreur : au moins un champ est vide");
            }
            else
            {

                // add a new item to the database
                Employee employee = new Employee
            {
                lastname = txt_employee_lastname.Text,
                firstname = txt_employee_firstname.Text,
                landline = txt_employee_landline.Text,
                mobile = txt_employee_mobile.Text,
                email = txt_employee_email.Text,
                site = txt_employee_site.Text,
                department = txt_employee_service.Text,
            };

            EmployeeDAO employeeDAO = new EmployeeDAO();
            int result = employeeDAO.addOneEmployee(employee);

            loadDataEmployee();

            // clear input form
            txt_employee_lastname.Text = String.Empty;
            txt_employee_firstname.Text = String.Empty;
            txt_employee_landline.Text = String.Empty;
            txt_employee_mobile.Text = String.Empty;
            txt_employee_email.Text = String.Empty;
            txt_employee_site.Text = String.Empty;
            txt_employee_service.Text = String.Empty;

            MessageBox.Show("L'employé(e) " + employee.lastname + " " + employee.firstname+ " a été ajouté");
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
          
            loadDataDepartment();

            // clear input
            txt_department_name.Text = String.Empty;

            MessageBox.Show("Le service " + department.name + " a été ajouté");
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

            loadDataSite();

            // clear input
            txt_site_name.Text = String.Empty;

            MessageBox.Show("Le site " + site.name + " a été ajouté");
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

   

   
    }
}
