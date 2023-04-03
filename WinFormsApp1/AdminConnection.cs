//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminConnection : Form
    {
        public AdminConnection()
        {
            InitializeComponent();
        }

        // button to acces admin form
        private void btn_check_password_Click(object sender, EventArgs e)
        {
            String password = "test";
            String entreePassword = txt_password_box.Text;
           
            if (String.Equals(password,entreePassword))
            {
                var adminForm = new AdminEditor();
                adminForm.Show();
                this.Close();
            }
            else
            {
                txt_password_box.Text = String.Empty;
                MessageBox.Show("Le mot de passe est erroné");
                this.Close();
            }
        }
    }
}
