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
    public partial class AdminEditor : Form
    {
        BindingSource employeeBindingSource = new BindingSource();
        BindingSource siteBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();

        public AdminEditor()
        {
            InitializeComponent();
        }

        private void AdminEditor_Load_1(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            SiteDAO siteDAO = new SiteDAO();
            DepartmentDAO departmentDAO = new DepartmentDAO();

            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.getAllEmployees();
            dataGridViewEmployeeEdit.DataSource = employeeBindingSource;
            dataGridViewEmployeeEdit.Columns["id"].Visible = false;
            dataGridViewEmployeeEdit.Columns[1].HeaderText = "Prénom";
            dataGridViewEmployeeEdit.Columns[2].HeaderText = "Nom";
            dataGridViewEmployeeEdit.Columns[3].HeaderText = "Téléphone Fixe";
            dataGridViewEmployeeEdit.Columns[4].HeaderText = "Mobile";
            dataGridViewEmployeeEdit.Columns[5].HeaderText = "Email";

            // connect the list to the grid view control
            siteBindingSource.DataSource = siteDAO.getAllSites();
            dataGridViewSiteEdit.DataSource = siteBindingSource;
            dataGridViewSiteEdit.Columns["id"].Visible = false;
            dataGridViewSiteEdit.Columns[1].HeaderText = "Nom du Site";

            // connect the list to the grid view control
            departmentBindingSource.DataSource = departmentDAO.getAllDepartments();
            dataGridViewDepartmentEdit.DataSource = departmentBindingSource;
            dataGridViewDepartmentEdit.Columns["id"].Visible = false;
            dataGridViewDepartmentEdit.Columns[1].HeaderText = "Nom du Service";
        }

        private void add_employee_Click(object sender, EventArgs e)
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

            MessageBox.Show("L'employé " + employee.lastname + " " + employee.firstname+ " a été ajouté");
        }

        private void addService_Click(object sender, EventArgs e)
        {
            // add a new item to the database
            Department department = new Department
            {
                name = txt_department_name.Text,
              
            };

            DepartmentDAO departmentDAO = new DepartmentDAO();
            int result = departmentDAO.addOneDepartment(department);

            MessageBox.Show(result + " service ajouté");
        }

        private void addSite_Click(object sender, EventArgs e)
        {
            Site site = new Site
            {
                name = txt_site_name.Text,

            };

            SiteDAO siteDAO = new SiteDAO();
            int result = siteDAO.addOneSite(site);

            MessageBox.Show(result + " site ajouté");

      

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

      

        // Don't work, foreignkey => pb !
        private void button1_Click(object sender, EventArgs e)
        {
           // int rowClicked = dataGridViewDepartmentEdit.CurrentRow.Index;

           // int departmentId = (int) dataGridViewDepartmentEdit.Rows[rowClicked].Cells[0].Value;
            
           // DepartmentDAO departmentDAO = new DepartmentDAO();

           // int result = departmentDAO.deleteDepartment(departmentId);

          //  MessageBox.Show("result " + result);

        }
    }
}
