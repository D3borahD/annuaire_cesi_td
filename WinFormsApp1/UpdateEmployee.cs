using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace WinFormsApp1
{

    public partial class UpdateEmployee : Form
    {

        BindingSource siteBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();

        public int employeeId;
        public int departmentId;
        public int siteId;

        private async Task loadListBoxSiteAsync(int siteId)
        {
           // SiteDAO siteDAO = new SiteDAO();
           // siteBindingSource.DataSource = siteDAO.getAllSites();

            IList<Site> siteList = await siteDAO.getSites();
            siteBindingSource.DataSource = siteList.ToList();

            listBoxSiteUpdate.DataSource = siteBindingSource;
            listBoxSiteUpdate.DisplayMember = "name";
            listBoxSiteUpdate.ValueMember = "id";
            listBoxSiteUpdate.SelectedValue = siteId;
        }

        private async void loadListBoxDepartment(int departmentId)
        {
            IList<Department> departmentList = await DepartmentDAO.getDepartments();
            departmentBindingSource.DataSource = departmentList.ToList();

            listBoxDepartmentUpdate.DataSource = departmentBindingSource;
            listBoxDepartmentUpdate.DisplayMember = "name";
            listBoxDepartmentUpdate.ValueMember = "id";
            listBoxDepartmentUpdate.SelectedValue = departmentId;
        }

        private void loadEmployee(int employeeId)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            Employee employee = (Employee)employeeDAO.getOneEmployee(employeeId);
            txt_update_lastname.Text = employee.lastname;
            txt_update_firstname.Text = employee.firstname;
            txt_update_landline.Text = employee.landline;
            txt_update_mobile.Text = employee.mobile;
            txt_update_email.Text = employee.email;
            departmentId = int.Parse(employee.department);
            siteId = int.Parse(employee.site);
        }

        public UpdateEmployee(List<String> userInfo)
        {
            InitializeComponent();
            employeeId = int.Parse(userInfo[0]);
            loadEmployee(employeeId);
            loadListBoxDepartment(departmentId);
            loadListBoxSiteAsync(siteId);
        }
      
        private void update_employee_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^\d{10}$");
            String fixnumber = txt_update_landline.Text;
            String mobilenumber = txt_update_mobile.Text;

            String formatFirstname = txt_update_firstname.Text;
            formatFirstname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(formatFirstname.ToLower());

            String getFirstLetter = formatFirstname.Substring(0, 1);

            if (
              String.IsNullOrEmpty(txt_update_lastname.Text) ||
              String.IsNullOrEmpty(txt_update_firstname.Text) ||
              String.IsNullOrEmpty(txt_update_landline.Text) ||
              String.IsNullOrEmpty(txt_update_mobile.Text)
              )
            {
                MessageBox.Show("Erreur : au moins un champ est vide");
                return;
            }

            if (!numberRegex.IsMatch(fixnumber))
            {
                MessageBox.Show("Le numéro de téléphone fixe n'est pas correct");
                return;
            }
            if (!numberRegex.IsMatch(mobilenumber))
            {
                MessageBox.Show("Le numéro de téléphone mobile n'est pas correct");
                return;
            }
            else
            {
                Employee employee = new Employee
                {
                    id = employeeId,
                    lastname = txt_update_lastname.Text.ToUpper(),
                    firstname = formatFirstname,
                    landline = txt_update_landline.Text,
                    mobile = txt_update_mobile.Text,
                    email = txt_update_email.Text.ToLower(),
                    site = listBoxSiteUpdate.SelectedValue.ToString(),
                    department = listBoxDepartmentUpdate.SelectedValue.ToString(),
                };

                EmployeeDAO employeeDAO = new EmployeeDAO();
                int result = employeeDAO.updateEmployee(employee);

                MessageBox.Show("L'employé(e)" + employee.lastname + " a été modifié(e)");
                this.Close();
            }

        }

        private void listBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
