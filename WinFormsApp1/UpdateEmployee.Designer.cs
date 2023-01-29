namespace WinFormsApp1
{
    partial class UpdateEmployee
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.txt_update_landline = new System.Windows.Forms.TextBox();
            this.txt_update_firstname = new System.Windows.Forms.TextBox();
            this.txt_update_mobile = new System.Windows.Forms.TextBox();
            this.txt_update_email = new System.Windows.Forms.TextBox();
            this.txt_update_lastname = new System.Windows.Forms.TextBox();
            this.update_employee = new System.Windows.Forms.Button();
            this.listBoxDepartmentUpdate = new System.Windows.Forms.ListBox();
            this.listBoxSiteUpdate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Site";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Téléphone Fixe";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstname.Location = new System.Drawing.Point(64, 108);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(85, 28);
            this.firstname.TabIndex = 15;
            this.firstname.Text = "Prénom";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(64, 45);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(58, 28);
            this.lastname.TabIndex = 14;
            this.lastname.Text = "Nom";
            // 
            // txt_update_landline
            // 
            this.txt_update_landline.Location = new System.Drawing.Point(195, 159);
            this.txt_update_landline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_update_landline.Name = "txt_update_landline";
            this.txt_update_landline.Size = new System.Drawing.Size(196, 27);
            this.txt_update_landline.TabIndex = 26;
            // 
            // txt_update_firstname
            // 
            this.txt_update_firstname.Location = new System.Drawing.Point(195, 46);
            this.txt_update_firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_update_firstname.Name = "txt_update_firstname";
            this.txt_update_firstname.Size = new System.Drawing.Size(196, 27);
            this.txt_update_firstname.TabIndex = 27;
            // 
            // txt_update_mobile
            // 
            this.txt_update_mobile.Location = new System.Drawing.Point(195, 215);
            this.txt_update_mobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_update_mobile.Name = "txt_update_mobile";
            this.txt_update_mobile.Size = new System.Drawing.Size(196, 27);
            this.txt_update_mobile.TabIndex = 28;
            // 
            // txt_update_email
            // 
            this.txt_update_email.Location = new System.Drawing.Point(195, 260);
            this.txt_update_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_update_email.Name = "txt_update_email";
            this.txt_update_email.Size = new System.Drawing.Size(196, 27);
            this.txt_update_email.TabIndex = 30;
            // 
            // txt_update_lastname
            // 
            this.txt_update_lastname.Location = new System.Drawing.Point(195, 108);
            this.txt_update_lastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_update_lastname.Name = "txt_update_lastname";
            this.txt_update_lastname.Size = new System.Drawing.Size(196, 27);
            this.txt_update_lastname.TabIndex = 32;
            // 
            // update_employee
            // 
            this.update_employee.BackColor = System.Drawing.Color.Navy;
            this.update_employee.ForeColor = System.Drawing.Color.White;
            this.update_employee.Location = new System.Drawing.Point(155, 512);
            this.update_employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_employee.Name = "update_employee";
            this.update_employee.Size = new System.Drawing.Size(131, 47);
            this.update_employee.TabIndex = 33;
            this.update_employee.Text = "Modifier";
            this.update_employee.UseVisualStyleBackColor = false;
            this.update_employee.Click += new System.EventHandler(this.update_employee_Click);
            // 
            // listBoxDepartmentUpdate
            // 
            this.listBoxDepartmentUpdate.FormattingEnabled = true;
            this.listBoxDepartmentUpdate.ItemHeight = 20;
            this.listBoxDepartmentUpdate.Location = new System.Drawing.Point(195, 387);
            this.listBoxDepartmentUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxDepartmentUpdate.Name = "listBoxDepartmentUpdate";
            this.listBoxDepartmentUpdate.Size = new System.Drawing.Size(196, 64);
            this.listBoxDepartmentUpdate.TabIndex = 36;
            // 
            // listBoxSiteUpdate
            // 
            this.listBoxSiteUpdate.FormattingEnabled = true;
            this.listBoxSiteUpdate.ItemHeight = 20;
            this.listBoxSiteUpdate.Items.AddRange(new object[] {
            "Test",
            "test1",
            "TEST2",
            "tet",
            "df",
            "po"});
            this.listBoxSiteUpdate.Location = new System.Drawing.Point(195, 305);
            this.listBoxSiteUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxSiteUpdate.Name = "listBoxSiteUpdate";
            this.listBoxSiteUpdate.Size = new System.Drawing.Size(196, 64);
            this.listBoxSiteUpdate.TabIndex = 35;
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 600);
            this.Controls.Add(this.listBoxDepartmentUpdate);
            this.Controls.Add(this.listBoxSiteUpdate);
            this.Controls.Add(this.update_employee);
            this.Controls.Add(this.txt_update_lastname);
            this.Controls.Add(this.txt_update_email);
            this.Controls.Add(this.txt_update_mobile);
            this.Controls.Add(this.txt_update_firstname);
            this.Controls.Add(this.txt_update_landline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateEmployee";
            this.Text = "Fiche modification employée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label firstname;
        private Label lastname;
        private TextBox txt_update_landline;
        private TextBox txt_update_firstname;
        private TextBox txt_update_mobile;
        private TextBox txt_update_email;
        private TextBox txt_update_lastname;
        private Button update_employee;
        private ListBox listBoxDepartmentUpdate;
        private ListBox listBoxSiteUpdate;
    }
}