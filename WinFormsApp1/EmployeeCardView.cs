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
        //public event SendId Send;
        public string GetUserId;

        public EmployeeCardView(string userId)
        {
            InitializeComponent();

            lastname.Text = userId;
        }

    }
}
