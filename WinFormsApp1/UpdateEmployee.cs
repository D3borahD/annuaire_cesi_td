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
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee(List<String> userInfo)
        {
            InitializeComponent();
            txt_update_lastname.Text = userInfo[1];
            txt_update_firstname.Text = userInfo[2];
            txt_update_landline.Text = userInfo[3];
            txt_update_mobile.Text = userInfo[4];
            txt_update_email.Text = userInfo[5];
            txt_update_site.Text = userInfo[6];
            txt_update_department.Text = userInfo[7];
        }
    }
}
