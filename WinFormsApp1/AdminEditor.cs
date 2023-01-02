using Org.BouncyCastle.Bcpg;
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
            int count = int.Parse(dataGridViewEmployeeEdit.Rows.Count.ToString());
            if (count != 0)
            {
                dataGridViewEmployeeEdit.Columns[0].Visible = false;
                dataGridViewEmployeeEdit.Columns[1].HeaderText = "Nom";
                dataGridViewEmployeeEdit.Columns[2].HeaderText = "Prénom";
                dataGridViewEmployeeEdit.Columns[3].HeaderText = "Téléphone fixe";
                dataGridViewEmployeeEdit.Columns[4].HeaderText = "Mobile";
                dataGridViewEmployeeEdit.Columns[5].HeaderText = "Email";
                dataGridViewEmployeeEdit.Columns[6].HeaderText = "Site";
                dataGridViewEmployeeEdit.Columns[7].HeaderText = "Service";
            }
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
            Regex numberRegex = new Regex(@"^\d{10}$");
            String fixNumber = txt_employee_landline.Text;
            String mobileNumber = txt_employee_mobile.Text;

            String formatFirstname = txt_employee_firstname.Text;
            formatFirstname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(formatFirstname.ToLower());

            String getFirstletter = formatFirstname.Substring(0, 1);
            String createEmail = (getFirstletter + "." + txt_employee_lastname.Text + "@natural.product").ToLower();

            if (
               String.IsNullOrEmpty(txt_employee_lastname.Text) ||
               String.IsNullOrEmpty(txt_employee_firstname.Text) ||
               String.IsNullOrEmpty(txt_employee_landline.Text) ||
               String.IsNullOrEmpty(txt_employee_mobile.Text)
               )
            {
                MessageBox.Show("Erreur : au moins un champ est vide");
                return;
            }

            if (!numberRegex.IsMatch(fixNumber))
                 {
                MessageBox.Show("Le numéro de téléphone fixe n'est pas correct");
                return;
            }
            if(!numberRegex.IsMatch(mobileNumber))
            {
                MessageBox.Show("Le numéro de téléphone mobile n'est pas correct");
                return;
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

                txt_employee_lastname.Clear();
                txt_employee_firstname.Clear();
                txt_employee_landline.Clear();
                txt_employee_mobile.Clear();

                MessageBox.Show("L'employé(e) " + employee.lastname + " " + employee.firstname+ " a été ajouté(e)");
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
                String name = txt_department_name.Text;
                name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

                // add a new item to the database
                Department department = new Department
                {
                name = name,
                };

                DepartmentDAO departmentDAO = new DepartmentDAO();
                int result = departmentDAO.addOneDepartment(department);

                txt_department_name.Clear();

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
                String name = txt_site_name.Text;
                name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

                Site site = new Site
            {
                name = name,
            };

            SiteDAO siteDAO = new SiteDAO();
            int result = siteDAO.addOneSite(site);

            txt_site_name.Clear();

            MessageBox.Show("Le site " + site.name + " a été ajouté");

            loadDataSite();
            }
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
            String nameSelectedDepartment = dataGridViewDepartmentEdit.Rows[rowClicked].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("ATTENTION : \n\n" + "Si vous supprimez le service : " + nameSelectedDepartment + "\nles employé(e)s associé(e)s à ce service seront aussi supprimé(e)s.\nVoulez-vous vraiment supprimer ce service ?", "SUPPRESSION D'UN SERVICE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult  == DialogResult.Yes)
            {
                DepartmentDAO departmentDAO = new DepartmentDAO();
                int result = departmentDAO.deleteDepartment(idSelectedDepartment);

                MessageBox.Show("Le service " + nameSelectedDepartment + " a été supprimé(e)");
                loadDataEmployee();
                loadDataDepartment();
            }
            else if(dialogResult == DialogResult.No)
            {
               // Application.OpenForms["UpdateDepartment"].Close();
                return;
            }
        }

        private void updateDepartment_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewDepartmentEdit.CurrentRow.Index;
            List<String> departmentInfo = new List<string>();

            for (int i = 0; i < dataGridViewDepartmentEdit.ColumnCount; i++)
            {
                departmentInfo.Add(dataGridViewDepartmentEdit.Rows[rowClicked].Cells[i].Value.ToString());
            }

            UpdateDepartment updateDepartment = new UpdateDepartment(departmentInfo);
            updateDepartment.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {

        }

        private void deleteSite_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewSiteEdit.CurrentRow.Index;
            int idSelectedSite = int.Parse(dataGridViewSiteEdit.Rows[rowClicked].Cells[0].Value.ToString());
            String nameSelectedSite = dataGridViewSiteEdit.Rows[rowClicked].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("ATTENTION : \n\n" + "Si vous supprimez le site : " + nameSelectedSite + "\nles employé(e)s associé(e)s à ce site seront aussi supprimé(e)s.\nVoulez-vous vraiment supprimer ce site ?", "SUPPRESSION D'UN SITE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                SiteDAO siteDAO = new SiteDAO();
                int result = siteDAO.deleteSite(idSelectedSite);

                MessageBox.Show("Le service " + nameSelectedSite + " a été supprimé(e)");
                loadDataEmployee();
                loadDataSite();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Application.OpenForms["UpdateDepartment"].Close();
                return;
            }
        }

        private void updateSite_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewSiteEdit.CurrentRow.Index;
            List<String> siteInfo = new List<string>();

            for (int i = 0; i < dataGridViewSiteEdit.ColumnCount; i++)
            {
                siteInfo.Add(dataGridViewSiteEdit.Rows[rowClicked].Cells[i].Value.ToString());
            }

            UpdateSite updateSite = new UpdateSite(siteInfo);
            updateSite.Show();
        }


        private void dataGridViewSiteEdit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* int rowClicked = dataGridViewSiteEdit.CurrentRow.Index;
            List<String> siteInfo = new List<string>();

            for (int i = 0; i < dataGridViewSiteEdit.ColumnCount; i++)
            {
                siteInfo.Add(dataGridViewSiteEdit.Rows[rowClicked].Cells[i].Value.ToString());
            }

            UpdateSite updateSite = new UpdateSite(siteInfo);
            updateSite.Show();*/
           // loadDataEmployee();
           // loadDataSite();
        }

        private void searchEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeBindingSource.DataSource = employeeDAO.searchName(textBoxSearch.Text);

            dataGridViewEmployeeEdit.DataSource = employeeBindingSource;

            int count = int.Parse(dataGridViewEmployeeEdit.Rows.Count.ToString());
            if (count != 0)
            {
                dataGridViewEmployeeEdit.Columns[0].Visible = false;
                dataGridViewEmployeeEdit.Columns[1].HeaderText = "Nom";
                dataGridViewEmployeeEdit.Columns[2].HeaderText = "Prénom";
                dataGridViewEmployeeEdit.Columns[3].HeaderText = "Téléphone Fixe";
                dataGridViewEmployeeEdit.Columns[4].HeaderText = "Mobile";
                dataGridViewEmployeeEdit.Columns[5].HeaderText = "Email";
                dataGridViewEmployeeEdit.Columns[6].HeaderText = "Site";
                dataGridViewEmployeeEdit.Columns[7].HeaderText = "Service";
            }

            textBoxSearch.Clear();
        }
    }
}
