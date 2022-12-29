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

        public int test;
        public UpdateEmployee(List<String> userInfo)
        {
            InitializeComponent();

            test = int.Parse(userInfo[0]);
           
            txt_update_lastname.Text = userInfo[1];
            txt_update_firstname.Text = userInfo[2];
            txt_update_landline.Text = userInfo[3];
            txt_update_mobile.Text = userInfo[4];
            txt_update_email.Text = userInfo[5];
            txt_update_site.Text = userInfo[6];
            txt_update_department.Text = userInfo[7];
           
        }

        private void update_employee_Click(object sender, EventArgs e)
        {

            MessageBox.Show("test" + test);
            // EmployeeDAO employeeDAO = new EmployeeDAO();
           // employeeBindingSource.DataSource = employeeDAO.getOneEmployees(test);

            //int result = employeeDAO.updateEmployee(idSelectedEmployee);

            // MessageBox.Show("L'employé(e) a été modifié(e)" + idEmpoyee);
            // loadDataEmployee();
        }


        // int rowClicked = dataGridViewEmployeeEdit.CurrentRow.Index;

        // int idSelectedEmployee = (int)dataGridViewEmployeeEdit.Rows[rowClicked].Cells[0].Value;

        // EmployeeDAO employeeDAO = new EmployeeDAO();
        //int result = employeeDAO.updateEmployee(idSelectedEmployee);

        // MessageBox.Show("L'employé(e) a été modifié(e)");
        // loadDataEmployee();
    }
}
