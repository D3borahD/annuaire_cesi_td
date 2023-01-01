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
    public partial class UpdateDepartment : Form
    {
        BindingSource departmentBindingSource = new BindingSource();
        public int departmentId;
       

        private void loadDataDepartment(int departmentId)
        {
            DepartmentDAO departmentDAO = new DepartmentDAO();
            List<Department> department = (List<Department>)departmentDAO.getDepartmentById(departmentId);
            //String name = department.name;
            labelDepartment.Text = department[0].name;
           // MessageBox.Show("test" + department[0].name );
        }

        public UpdateDepartment(List<String> departmentInfo)
        {
            InitializeComponent();
            departmentId = int.Parse(departmentInfo[0]);

            loadDataDepartment(departmentId);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department department = new Department
            {
                id = departmentId,
                name = txt_department_update.Text,
            };


            DepartmentDAO departmentDAO = new DepartmentDAO();

            int result = departmentDAO.updateDepartment(department);

           // MessageBox.Show("Le service " + nameSelectedDepartment + "a été modifié(e) en ");
        }
    }
}
