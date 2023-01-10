using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class EmployeeCardView : Form
    {
        public EmployeeCardView(List<string> userInfo)
        {
            InitializeComponent();

            lastname.Text = userInfo[1];
            firstname.Text = userInfo[2];
            landline.Text = userInfo[3];
            mobile.Text = userInfo[4];
            email.Text = userInfo[5];
            Site.Text = userInfo[6];
            Department.Text = userInfo[7];
        }
    }
}
