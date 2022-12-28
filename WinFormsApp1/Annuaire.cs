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

        private void loadDataDepartment()
        {
            DepartmentDAO departmentDAO = new DepartmentDAO();
            departmentBindingSource.DataSource = departmentDAO.getAllDepartments();
            dataGridViewDepartmentDisplay.DataSource = departmentBindingSource;
            dataGridViewDepartmentDisplay.Columns["id"].Visible = false;
            dataGridViewDepartmentDisplay.Columns[1].HeaderText = "Nom du Service";
        }

        private void loadDataSite()
        {
            SiteDAO siteDAO = new SiteDAO();
            siteBindingSource.DataSource = siteDAO.getAllSites();
            dataGridViewSiteDisplay.DataSource = siteBindingSource;
            dataGridViewSiteDisplay.Columns["id"].Visible = false;
            dataGridViewSiteDisplay.Columns[1].HeaderText = "Nom du Site";
        }

        private void loadDataEmployee()
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeBindingSource.DataSource = employeeDAO.getAllEmployees();
            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Prénom";
            dataGridView1.Columns[2].HeaderText = "Nom";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "Site";
            dataGridView1.Columns[7].HeaderText = "Service";
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
            loadDataEmployee();
            loadDataDepartment();
            loadDataSite();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();

            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.searchName(textBox1.Text);

            dataGridView1.DataSource = employeeBindingSource;
        }

        // remove at the end project
        private void edition_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminEditor();
            adminForm.Show();
        }

        private void dataGridViewSiteDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            EmployeeDAO employeeDAO = new EmployeeDAO();

            int rowClicked = dataGridView.CurrentRow.Index;

            String idOfChoosen = dataGridView.Rows[rowClicked].Cells[0].Value.ToString();

            employeeBindingSource.DataSource = employeeDAO.getEmployeesUsingJoin((int) dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView1.DataSource = employeeBindingSource;
           /* dataGridView1.Columns[0].HeaderText = "Prénom";
            dataGridView1.Columns[1].HeaderText = "Nom";
            dataGridView1.Columns[2].HeaderText = "Téléphone Fixe";
            dataGridView1.Columns[3].HeaderText = "Mobile";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Site";
            dataGridView1.Columns[6].HeaderText = "Service";*/
        }

        private void dataGridViewDepartmentDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            EmployeeDAO employeeDAO = new EmployeeDAO();

            int rowClicked = dataGridView.CurrentRow.Index;

            String idOfChoosen = dataGridView.Rows[rowClicked].Cells[0].Value.ToString();

            employeeBindingSource.DataSource = employeeDAO.getEmployeesUsingJoinDepartment((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView1.DataSource = employeeBindingSource;
           /* dataGridView1.Columns[0].HeaderText = "Prénom";
            dataGridView1.Columns[1].HeaderText = "Nom";
            dataGridView1.Columns[2].HeaderText = "Téléphone Fixe";
            dataGridView1.Columns[3].HeaderText = "Mobile";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Site";
            dataGridView1.Columns[6].HeaderText = "Service";*/
        }

        // DO COMPLETE
        public void displayEmplyeeCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;

            string userId = dataGridView1.Rows[rowClicked].Cells[0].Value.ToString();

            MessageBox.Show("" + userId);

            EmployeeCardView employeeCardView = new EmployeeCardView(userId);
            employeeCardView.Show(); 
       
        // send id in new box ?

    }

        private void AdminAcces_KeyDown(object sender, KeyEventArgs e)
        {
           // System.Diagnostics.Debug.Write(e.KeyCode);
            if (e.Shift && e.Control && e.KeyCode == Keys.E)
            {
                var adminConnection = new AdminConnection();
                adminConnection.Show();

            }

        }
    }
}
