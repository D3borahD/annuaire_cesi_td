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
            EmployeeDAO employeeDAO = new EmployeeDAO();
            SiteDAO siteDAO = new SiteDAO();
            DepartmentDAO departmentDAO = new DepartmentDAO();


            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.getAllEmployees();

            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Prénom";
            dataGridView1.Columns[2].HeaderText = "Nom";
            dataGridView1.Columns[3].HeaderText = "Téléphone Fixe";
            dataGridView1.Columns[4].HeaderText = "Mobile";
            dataGridView1.Columns[5].HeaderText = "Email";

            // connect the list to the grid view control
            siteBindingSource.DataSource = siteDAO.getAllSites();
            dataGridViewSiteDisplay.DataSource = siteBindingSource;
            dataGridViewSiteDisplay.Columns["id"].Visible = false;
            dataGridViewSiteDisplay.Columns[1].HeaderText = "Nom du Site";


            // connect the list to the grid view control
            departmentBindingSource.DataSource = departmentDAO.getAllDepartments();
            dataGridViewDepartmentDisplay.DataSource = departmentBindingSource;
            dataGridViewDepartmentDisplay.Columns["id"].Visible = false;
            dataGridViewDepartmentDisplay.Columns[1].HeaderText = "Nom du Service";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();

            // connect the list to the grid view control
            employeeBindingSource.DataSource = employeeDAO.searchName(textBox1.Text);

            dataGridView1.DataSource = employeeBindingSource;
        }

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
            //MessageBox.Show(" row " + rowClicked + " ID " + idOfChoosen);

            employeeBindingSource.DataSource = employeeDAO.getOneEmployees((int) dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Prénom";
            dataGridView1.Columns[2].HeaderText = "Nom";
            dataGridView1.Columns[3].HeaderText = "Téléphone Fixe";
            dataGridView1.Columns[4].HeaderText = "Mobile";
            dataGridView1.Columns[5].HeaderText = "Email";
        }
    }
}
