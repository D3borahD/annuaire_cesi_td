//using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.Design.Serialization;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Security.Policy;
//using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Xml.Linq;
using WinFormsApp1.Controller;
using WinFormsApp1.Model;
//using static System.Net.Mime.MediaTypeNames;
//using Application = System.Windows.Forms.Application;
using Site = WinFormsApp1.Model.Site;

namespace WinFormsApp1
{
    public partial class UpdateEmployee : Form
    {

        BindingSource siteBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();

        public int employeeId;
        public int departmentId;
        public int siteId;

        // load data's site
        private async void loadListBoxSite(int siteId)
        {
            IList<Site> siteList = await siteDAO.getSites();
            siteBindingSource.DataSource = siteList.ToList();

            //custom grid view
             listBoxSiteUpdate.DataSource = siteBindingSource;
             listBoxSiteUpdate.DisplayMember = "name";
             listBoxSiteUpdate.ValueMember = "id";
             listBoxSiteUpdate.SelectedValue = siteId;
        }

        // load data department
        private async void loadListBoxDepartment(int departmentId)
        {
            IList<Department> departmentList = await DepartmentDAO.getDepartments();
            departmentBindingSource.DataSource = departmentList.ToList();

            // custom grid view
             listBoxDepartmentUpdate.DataSource = departmentBindingSource;
             listBoxDepartmentUpdate.DisplayMember = "name";
             listBoxDepartmentUpdate.ValueMember = "id";
             listBoxDepartmentUpdate.SelectedValue = departmentId;
        }

        // load employee
        private async void loadEmployee(int employeeId)
        {
            var response = await EmployeeDAO.getOneEmployee(employeeId);
            var result = JsonConvert.DeserializeObject<EmployeeFormated>(response);
     
            txt_update_lastname.Text = result.Lastname;
            txt_update_firstname.Text = result.Firstname;
            txt_update_landline.Text = result.Landline;
            txt_update_mobile.Text = result.Mobile;
            txt_update_email.Text = result.Email;
            departmentId = result.DepartmentId;
            siteId = result.SiteId;

             loadListBoxDepartment(departmentId);
             loadListBoxSite(siteId);
        }

        public UpdateEmployee(int userInfo)
        {
            InitializeComponent();
            employeeId = userInfo;
            loadEmployee(employeeId);
        }
      
        private async void update_employee_Click(object sender, EventArgs e)
        {
            // regex to check phone number
            //only 10 number
            Regex numberRegex = new Regex(@"^\d{10}$");
            String fixnumber = txt_update_landline.Text;
            String mobilenumber = txt_update_mobile.Text;

            //format firstname with low case and first letter in capital
            String formatFirstname = txt_update_lastname.Text;
            formatFirstname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(formatFirstname.ToLower());

            String getFirstLetter = formatFirstname.Substring(0, 1);

            // check if input is empty
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
                    firstname = txt_update_firstname.Text.ToUpper(),
                    lastname = formatFirstname,
                    landline = txt_update_landline.Text,
                    mobile = txt_update_mobile.Text,
                    email = txt_update_email.Text.ToLower(),
                    siteId = (int)listBoxSiteUpdate.SelectedValue,
                    departmentId = (int)listBoxDepartmentUpdate.SelectedValue,
                };
               
                EmployeeDAO employeeDAO = new EmployeeDAO();

                await employeeDAO.updateEmployee(employee.id, employee);

                MessageBox.Show("L'employé(e)" + employee.firstname + " a été modifié(e)");
                this.Close();
            }
        }
    }
}
