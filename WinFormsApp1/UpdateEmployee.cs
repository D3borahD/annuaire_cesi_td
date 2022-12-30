using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{

    public partial class UpdateEmployee : Form
    {
        BindingSource employeeBindingSource = new BindingSource();
        BindingSource siteBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();

        public int employeeId;
        //public int departmentId;
       // public int siteId;

        private void loadListBoxSite()
        {
            SiteDAO siteDAO = new SiteDAO();
            siteBindingSource.DataSource = siteDAO.getAllSites();
            listBoxSiteUpdate.DataSource = siteBindingSource;
            listBoxSiteUpdate.DisplayMember = "name";
            listBoxSiteUpdate.ValueMember = "id";
        }

        private void loadListBoxDepartment()
        {
            DepartmentDAO departmentDAO = new DepartmentDAO();

            departmentBindingSource.DataSource = departmentDAO.getAllDepartments();
            listBoxDepartmentUpdate.DataSource = departmentBindingSource;
            listBoxDepartmentUpdate.DisplayMember = "name";
            listBoxDepartmentUpdate.ValueMember = "id";
            //listBoxDepartmentUpdate.Focus();



            listBoxDepartmentUpdate.SelectedValue = 4;
           // var listBoxItem = (listBoxItem)listBoxDepartmentUpdate.ItemContainerGenerator.ContainerFromItem(listBoxDepartmentUpdate.SelectedItem);

        }
        

        public UpdateEmployee(List<String> userInfo)
        {
            InitializeComponent();
            loadListBoxSite();
            loadListBoxDepartment();

            employeeId = int.Parse(userInfo[0]);

            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeBindingSource.DataSource = employeeDAO.getOneEmployees(employeeId);


            Employee employee = new Employee();
           /* {
                id = employeeId,
                lastname = txt_update_lastname.Text,
                firstname = txt_update_firstname.Text,
                landline = txt_update_landline.Text,
                mobile = txt_update_mobile.Text,
                email = txt_update_email.Text,
                site = listBoxSiteUpdate.SelectedValue.ToString(),
                department = listBoxDepartmentUpdate.SelectedValue.ToString(),
            };*/
            MessageBox.Show("mon site : " + employee.site);

            string departmentId = userInfo[7];

            MessageBox.Show(" depart" + departmentId);
            //Label labelUpdate = new Label();
            //int departmentSelected = int.Parse(userInfo[6].ToString());

            txt_update_lastname.Text = userInfo[1];
            txt_update_firstname.Text = userInfo[2];
            txt_update_landline.Text = userInfo[3];
            txt_update_mobile.Text = userInfo[4];
            txt_update_email.Text = userInfo[5];
            labelSiteUpdate.Text = userInfo[6];
            //listBoxDepartmentUpdate.SelectedIndex = ;
            //txt_update_site.Text = userInfo[6];
            labelDepartmentUpdate.Text = userInfo[7];
        }

      
        private void update_employee_Click(object sender, EventArgs e)
        {

            Employee employee = new Employee
            {
                id = employeeId,
                lastname = txt_update_lastname.Text,
                firstname = txt_update_firstname.Text,
                landline = txt_update_landline.Text,
                mobile = txt_update_mobile.Text,
                email = txt_update_email.Text,
                site = listBoxSiteUpdate.SelectedValue.ToString(),
                department = listBoxDepartmentUpdate.SelectedValue.ToString(),
            };


            EmployeeDAO employeeDAO = new EmployeeDAO();

            int result = employeeDAO.updateEmployee(employee);

            MessageBox.Show("L'employé(e) a été modifié(e)" + employeeId);
        }

        private void listBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
