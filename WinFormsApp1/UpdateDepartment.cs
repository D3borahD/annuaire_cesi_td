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
        public int departmentId;
        public string oldName;

        private void loadDataDepartment(int departmentId)
        {
            DepartmentDAO departmentDAO = new DepartmentDAO();
            Department department = (Department)departmentDAO.getDepartmentById(departmentId);
            labelDepartment.Text = department.name;
        }

        public UpdateDepartment(List<String> departmentInfo)
        {
            InitializeComponent();
            departmentId = int.Parse(departmentInfo[0]);
            loadDataDepartment(departmentId);
            oldName = departmentInfo[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txt_department_update.Text;
            name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());

            Department department = new Department
            {
                id = departmentId,
                name = name,
            };

            DepartmentDAO departmentDAO = new DepartmentDAO();

            DialogResult dialogResult = MessageBox.Show(
                "ATTENTION : \n\n" +
                "En modifiant ce service, vous allez modifier les employé(e)s qui y sont rattaché(e)s\n" +
                "Voulez-vous  vraiment renommer le service " + oldName + " en " + department.name + "?", 
                "MODIFICATION D'UN SERVICE",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                int result = departmentDAO.updateDepartment(department);
           
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                return;
            }
            this.Close();
           
        }
    }
}
