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
        public AdminEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            };

            EmployeeDAO employeeDAO = new EmployeeDAO();
            int result = employeeDAO.addOneEmployee(employee);

            MessageBox.Show(result + "employés ajouté");
        }
    }
}
