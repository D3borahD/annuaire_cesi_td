//using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
using WinFormsApp1.Model;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class EmployeeCardView : Form
    {
        public int id;
        private async void loadDataEmployee()
        {
            var response = await EmployeeDAO.getOneEmployee(id);
            var result = JsonConvert.DeserializeObject<EmployeeFormated>(response);

            var siteName = await siteDAO.getSiteById(result.SiteId);
            String siteN = siteName.name;

            var departmentName = await DepartmentDAO.getDepartmentById(result.DepartmentId);
            String departmentN = departmentName.name;

            lastname.Text = result.Lastname;
            firstname.Text = result.Firstname;
            landline.Text = result.Landline;
            mobile.Text = result.Mobile;
            email.Text = result.Email;
            Site.Text = siteN;
            Department.Text = departmentN;
        }
        public EmployeeCardView(int userId)
        {
            InitializeComponent();
            id = userId;
            loadDataEmployee();
        }
    }
}
