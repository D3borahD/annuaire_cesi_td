//using MySqlX.XDevAPI.Common;
using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using Org.BouncyCastle.Bcpg;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Security.Policy;
//using System.Text;
using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows.Forms;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public partial class AdminEditor : Form
    {
        //BindingSource employeeBindingSource = new BindingSource();
        BindingSource siteBindingSource = new BindingSource();
        BindingSource departmentBindingSource = new BindingSource();

        public AdminEditor()
        {
            InitializeComponent();         
        }

        private async void loadDataDepartment()
        {
            IList<Department> departmentList = await DepartmentDAO.getDepartments();
            departmentBindingSource.DataSource = departmentList.ToList();

            dataGridViewDepartmentEdit.DataSource = departmentBindingSource;
            dataGridViewDepartmentEdit.Columns["id"].Visible = false;
            dataGridViewDepartmentEdit.Columns[1].HeaderText = "Nom du Service";
            dataGridViewDepartmentEdit.DefaultCellStyle.SelectionBackColor = Color.Navy;
        }

        private async void loadDataSite()
        {
            IList<Site> siteList = await siteDAO.getSites();
            siteBindingSource.DataSource = siteList.ToList();

            dataGridViewSiteEdit.DataSource = siteBindingSource;
            dataGridViewSiteEdit.Columns["id"].Visible = false;
            dataGridViewSiteEdit.Columns[1].HeaderText = "Nom du Site";
            dataGridViewSiteEdit.DefaultCellStyle.SelectionBackColor = Color.Navy;
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
                employee.Landline = result[i].Landline;
                employee.Mobile = result[i].Mobile;
                employee.Email = result[i].Email;
                employee.Site = siteN;
                employee.Department = departmentN;
                employees.Add(employee);
            }

            dataGridViewEmployeeEdit.DataSource = employees;

            dataGridViewEmployeeEdit.DefaultCellStyle.SelectionBackColor = Color.Navy;
            int count = int.Parse(dataGridViewEmployeeEdit.Rows.Count.ToString());
            if (count != 0)
            {
                dataGridViewEmployeeEdit.Columns[0].Visible = false;
                dataGridViewEmployeeEdit.Columns[1].HeaderText = "Nom";
                dataGridViewEmployeeEdit.Columns[2].HeaderText = "Prénom";
                dataGridViewEmployeeEdit.Columns[3].HeaderText = "Téléphone fixe";
                dataGridViewEmployeeEdit.Columns[4].HeaderText = "Mobile";
                dataGridViewEmployeeEdit.Columns[5].HeaderText = "Email";
                dataGridViewEmployeeEdit.Columns[6].Visible = false;
                dataGridViewEmployeeEdit.Columns[7].HeaderText = "Site";
                dataGridViewEmployeeEdit.Columns[8].Visible = false;
                dataGridViewEmployeeEdit.Columns[9].HeaderText = "Service";
            }
        }

        private async void loadListBoxSite()
        {
             IList<Site> siteList = await siteDAO.getSites();
             siteBindingSource.DataSource = siteList.ToList();

             listBoxSite.DataSource = siteBindingSource;
             listBoxSite.DisplayMember = "name";
             listBoxSite.ValueMember = "Id";
        }

        private async void loadListBoxDepartment()
        {
              IList<Department> departmentList = await DepartmentDAO.getDepartments();
              departmentBindingSource.DataSource = departmentList.ToList();

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

        private async void add_employee_Click(object sender, EventArgs e)
        {
           Regex numberRegex = new Regex(@"^\d{10}$");
            String fixNumber = txt_employee_landline.Text;
            String mobileNumber = txt_employee_mobile.Text;

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

            String formatLastname = txt_employee_firstname.Text;
            formatLastname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(formatLastname.ToLower());

            String getFirstletter = formatLastname.Substring(0, 1);
            String createEmail = (getFirstletter + "." + txt_employee_lastname.Text + "@natural.product").ToLower();


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

                    firstname = txt_employee_lastname.Text.ToUpper(),
                    lastname = formatLastname,
                    landline = txt_employee_landline.Text,
                    mobile = txt_employee_mobile.Text,
                    email = createEmail,
                    siteId = (int)listBoxSite.SelectedValue,
                    departmentId = (int)listBoxDepartment.SelectedValue,
                };
                EmployeeDAO employeeDAO = new EmployeeDAO();
                await employeeDAO.addEmployee(employee);

                txt_employee_lastname.Clear();
                txt_employee_firstname.Clear();
                txt_employee_landline.Clear();
                txt_employee_mobile.Clear();

                MessageBox.Show("L'employé(e) " + employee.firstname + " " + employee.lastname+ " a été ajouté(e)");
                loadDataEmployee();
            }
        }

        //Add department
        private async void addService_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_department_name.Text))
            {
                MessageBox.Show("Erreur : Le champ est vide");
            } 
            else
            {
                String name = txt_department_name.Text;
                name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

                Department department = new Department
                {
                name = name,
                };

                await DepartmentDAO.addDepartment(department);

                txt_department_name.Clear();

                if (department != null)
                {
                    MessageBox.Show("Le service " + department.name + " a été ajouté");
                } 
              
                loadDataDepartment();
            }
        }

        private async void addSite_Click(object sender, EventArgs e)
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
            
                await siteDAO.addSite(site);
                txt_site_name.Clear();

                if (site != null)
                {
                    MessageBox.Show("Le site " + site.name + " a été ajouté");
                }

                loadDataSite();
            }
        }

        private async void deleteEmployee_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewEmployeeEdit.CurrentRow.Index;

            int idSelectedEmployee = int.Parse(dataGridViewEmployeeEdit.Rows[rowClicked].Cells[0].Value.ToString());

            String nameSelectedEmployee = dataGridViewEmployeeEdit.Rows[rowClicked].Cells[1].Value.ToString();
       
            DialogResult dialogResult = MessageBox.Show("Etes-vous sûre de vouloir supprimer l'employé(e) " + nameSelectedEmployee + "?", "SUPPRESSION D'UN SERVICE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                EmployeeDAO employeeDAO = new EmployeeDAO();
                var response = await employeeDAO.deleteEmployee(idSelectedEmployee);
    
                MessageBox.Show("L'employé(e) " + nameSelectedEmployee + " a été supprimé(e)");
                loadDataEmployee();
    
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void updateEmployee_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewEmployeeEdit.CurrentRow.Index;
            int employeeId = int.Parse(dataGridViewEmployeeEdit.Rows[rowClicked].Cells[0].Value.ToString());

            UpdateEmployee updateEmployee = new UpdateEmployee(employeeId);
            updateEmployee.Show();
        }

        private async void deleteDepartment_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewDepartmentEdit.CurrentRow.Index;
            int id = int.Parse(dataGridViewDepartmentEdit.Rows[rowClicked].Cells[0].Value.ToString());
            String nameSelectedDepartment = dataGridViewDepartmentEdit.Rows[rowClicked].Cells[1].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("ATTENTION : \n\n" + "Si vous supprimez le service : " + nameSelectedDepartment + "\nles employé(e)s associé(e)s à ce service seront aussi supprimé(e)s.\nVoulez-vous vraiment supprimer ce service ?", "SUPPRESSION D'UN SERVICE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult  == DialogResult.Yes)
            {
                var departmentDAO = new DepartmentDAO();
                await departmentDAO.deleteDepartment(id);

                MessageBox.Show("Le service " + nameSelectedDepartment + " a été supprimé(e)");
                loadDataEmployee();
                loadDataDepartment();
            }
            else if(dialogResult == DialogResult.No)
            {
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


        public async void refresh_Click(object sender, EventArgs e)
        {
            loadDataEmployee();
            loadDataDepartment();
            loadDataSite();
        }

        public async void deleteSite_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridViewSiteEdit.CurrentRow.Index;
            String id = dataGridViewSiteEdit.Rows[rowClicked].Cells[0].Value.ToString();
            String nameSelectedSite = dataGridViewSiteEdit.Rows[rowClicked].Cells[1].Value.ToString();

            var siteDAO = new siteDAO();
            
            DialogResult dialogResult = MessageBox.Show(
                "ATTENTION : \n\n" +
                "Si vous supprimez le site : " +
                nameSelectedSite + 
                "\nles employé(e)s associé(e)s à ce site seront aussi supprimé(e)s.\n" +
                "Voulez-vous vraiment supprimer ce site ?", 
                "SUPPRESSION D'UN SITE", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
             {
                var response = await siteDAO.deleteSite(id);

                MessageBox.Show("Le site " + nameSelectedSite + " a été supprimé(e)");
                   loadDataEmployee();
                   loadDataSite();
            }
            else if (dialogResult == DialogResult.No)
            {
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

        private async void searchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await EmployeeDAO.getEmployeesByName(textBoxSearch.Text);

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
                    employee.Landline = result[i].Landline;
                    employee.Mobile = result[i].Mobile;
                    employee.Email = result[i].Email;
                    employee.Site = siteN;
                    employee.Department = departmentN;
                    employees.Add(employee);
                }

                dataGridViewEmployeeEdit.DataSource = employees;

                dataGridViewEmployeeEdit.DefaultCellStyle.SelectionBackColor = Color.Navy;
                int count = int.Parse(dataGridViewEmployeeEdit.Rows.Count.ToString());
                if (count != 0)
                {
                    dataGridViewEmployeeEdit.Columns[0].Visible = false;
                    dataGridViewEmployeeEdit.Columns[1].HeaderText = "Nom";
                    dataGridViewEmployeeEdit.Columns[2].HeaderText = "Prénom";
                    dataGridViewEmployeeEdit.Columns[3].HeaderText = "Téléphone fixe";
                    dataGridViewEmployeeEdit.Columns[4].HeaderText = "Mobile";
                    dataGridViewEmployeeEdit.Columns[5].HeaderText = "Email";
                    dataGridViewEmployeeEdit.Columns[6].Visible = false;
                    dataGridViewEmployeeEdit.Columns[7].HeaderText = "Site";
                    dataGridViewEmployeeEdit.Columns[8].Visible = false;
                    dataGridViewEmployeeEdit.Columns[9].HeaderText = "Service";
                }
                textBoxSearch.Clear();
            }
            catch(Exception ex)
            {

            }
        }

       }
}
