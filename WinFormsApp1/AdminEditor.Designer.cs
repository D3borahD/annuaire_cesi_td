namespace WinFormsApp1
{
    partial class AdminEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEmployee = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_employee_lastname = new System.Windows.Forms.TextBox();
            this.txt_employee_firstname = new System.Windows.Forms.TextBox();
            this.txt_employee_service = new System.Windows.Forms.TextBox();
            this.txt_employee_site = new System.Windows.Forms.TextBox();
            this.txt_employee_email = new System.Windows.Forms.TextBox();
            this.txt_employee_mobile = new System.Windows.Forms.TextBox();
            this.txt_employee_landline = new System.Windows.Forms.TextBox();
            this.addEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addEmployee.Controls.Add(this.txt_employee_email);
            this.addEmployee.Controls.Add(this.txt_employee_mobile);
            this.addEmployee.Controls.Add(this.txt_employee_landline);
            this.addEmployee.Controls.Add(this.txt_employee_service);
            this.addEmployee.Controls.Add(this.txt_employee_site);
            this.addEmployee.Controls.Add(this.txt_employee_firstname);
            this.addEmployee.Controls.Add(this.txt_employee_lastname);
            this.addEmployee.Controls.Add(this.label7);
            this.addEmployee.Controls.Add(this.label6);
            this.addEmployee.Controls.Add(this.label5);
            this.addEmployee.Controls.Add(this.label4);
            this.addEmployee.Controls.Add(this.label3);
            this.addEmployee.Controls.Add(this.label2);
            this.addEmployee.Controls.Add(this.name);
            this.addEmployee.Location = new System.Drawing.Point(61, 73);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(301, 299);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.TabStop = false;
            this.addEmployee.Text = "Ajouter un employé";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(16, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(34, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Site";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Téléphone Fixe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // txt_employee_lastname
            // 
            this.txt_employee_lastname.Location = new System.Drawing.Point(134, 33);
            this.txt_employee_lastname.Name = "txt_employee_lastname";
            this.txt_employee_lastname.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_lastname.TabIndex = 7;
            // 
            // txt_employee_firstname
            // 
            this.txt_employee_firstname.Location = new System.Drawing.Point(134, 68);
            this.txt_employee_firstname.Name = "txt_employee_firstname";
            this.txt_employee_firstname.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_firstname.TabIndex = 8;
            // 
            // txt_employee_service
            // 
            this.txt_employee_service.Location = new System.Drawing.Point(134, 141);
            this.txt_employee_service.Name = "txt_employee_service";
            this.txt_employee_service.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_service.TabIndex = 10;
            // 
            // txt_employee_site
            // 
            this.txt_employee_site.Location = new System.Drawing.Point(134, 106);
            this.txt_employee_site.Name = "txt_employee_site";
            this.txt_employee_site.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_site.TabIndex = 9;
            // 
            // txt_employee_email
            // 
            this.txt_employee_email.Location = new System.Drawing.Point(134, 249);
            this.txt_employee_email.Name = "txt_employee_email";
            this.txt_employee_email.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_email.TabIndex = 13;
            // 
            // txt_employee_mobile
            // 
            this.txt_employee_mobile.Location = new System.Drawing.Point(134, 214);
            this.txt_employee_mobile.Name = "txt_employee_mobile";
            this.txt_employee_mobile.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_mobile.TabIndex = 12;
            // 
            // txt_employee_landline
            // 
            this.txt_employee_landline.Location = new System.Drawing.Point(134, 176);
            this.txt_employee_landline.Name = "txt_employee_landline";
            this.txt_employee_landline.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_landline.TabIndex = 11;
            // 
            // AdminEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.addEmployee);
            this.Name = "AdminEditor";
            this.Text = "Administrateur Edition";
            this.addEmployee.ResumeLayout(false);
            this.addEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox addEmployee;
        private TextBox txt_employee_email;
        private TextBox txt_employee_mobile;
        private TextBox txt_employee_landline;
        private TextBox txt_employee_service;
        private TextBox txt_employee_site;
        private TextBox txt_employee_firstname;
        private TextBox txt_employee_lastname;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label name;
    }
}