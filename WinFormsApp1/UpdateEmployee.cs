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

        public int employeeId;
        public UpdateEmployee(List<String> userInfo)
        {
            InitializeComponent();

            employeeId = int.Parse(userInfo[0]);
           
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

           //MessageBox.Show("test" + employeeId);
            Employee employee = new Employee
            {
                id = employeeId,
                lastname = txt_update_lastname.Text,
                firstname = txt_update_firstname.Text,
                landline = txt_update_landline.Text,
                mobile = txt_update_mobile.Text,
                email = txt_update_email.Text,
                site = txt_update_site.Text,
                department = txt_update_department.Text,
            };


            EmployeeDAO employeeDAO = new EmployeeDAO();

            int result = employeeDAO.updateEmployee(employee);

             MessageBox.Show("L'employé(e) a été modifié(e)" + employeeId);
        }


        // int rowClicked = dataGridViewEmployeeEdit.CurrentRow.Index;

        // int idSelectedEmployee = (int)dataGridViewEmployeeEdit.Rows[rowClicked].Cells[0].Value;

        // EmployeeDAO employeeDAO = new EmployeeDAO();
        //int result = employeeDAO.updateEmployee(idSelectedEmployee);

        // MessageBox.Show("L'employé(e) a été modifié(e)");
        // loadDataEmployee();
    }
}
