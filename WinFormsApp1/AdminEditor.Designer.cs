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
            this.Site = new System.Windows.Forms.Label();
            this.add_employee = new System.Windows.Forms.Button();
            this.txt_employee_email = new System.Windows.Forms.TextBox();
            this.txt_employee_mobile = new System.Windows.Forms.TextBox();
            this.txt_employee_landline = new System.Windows.Forms.TextBox();
            this.txt_employee_service = new System.Windows.Forms.TextBox();
            this.txt_employee_site = new System.Windows.Forms.TextBox();
            this.txt_employee_firstname = new System.Windows.Forms.TextBox();
            this.txt_employee_lastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.addDepartment = new System.Windows.Forms.GroupBox();
            this.updateDepartment = new System.Windows.Forms.Button();
            this.deleteDepartment = new System.Windows.Forms.Button();
            this.dataGridViewDepartmentEdit = new System.Windows.Forms.DataGridView();
            this.addService = new System.Windows.Forms.Button();
            this.txt_department_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updateSite = new System.Windows.Forms.Button();
            this.dataGridViewSiteEdit = new System.Windows.Forms.DataGridView();
            this.deleteSite = new System.Windows.Forms.Button();
            this.addSite = new System.Windows.Forms.Button();
            this.txt_site_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewEmployeeEdit = new System.Windows.Forms.DataGridView();
            this.updateEmployee = new System.Windows.Forms.Button();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.addEmployee.SuspendLayout();
            this.addDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addEmployee.Controls.Add(this.Site);
            this.addEmployee.Controls.Add(this.add_employee);
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
            this.addEmployee.Location = new System.Drawing.Point(24, 36);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(301, 348);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.TabStop = false;
            this.addEmployee.Text = "Ajouter un employé";
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Location = new System.Drawing.Point(16, 285);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(0, 15);
            this.Site.TabIndex = 15;
            this.Site.Click += new System.EventHandler(this.label10_Click);
            // 
            // add_employee
            // 
            this.add_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.add_employee.Location = new System.Drawing.Point(198, 297);
            this.add_employee.Name = "add_employee";
            this.add_employee.Size = new System.Drawing.Size(75, 23);
            this.add_employee.TabIndex = 14;
            this.add_employee.Text = "Ajouter";
            this.add_employee.UseVisualStyleBackColor = false;
            this.add_employee.Click += new System.EventHandler(this.add_employee_Click);
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
            // txt_employee_firstname
            // 
            this.txt_employee_firstname.Location = new System.Drawing.Point(134, 68);
            this.txt_employee_firstname.Name = "txt_employee_firstname";
            this.txt_employee_firstname.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_firstname.TabIndex = 8;
            // 
            // txt_employee_lastname
            // 
            this.txt_employee_lastname.Location = new System.Drawing.Point(134, 33);
            this.txt_employee_lastname.Name = "txt_employee_lastname";
            this.txt_employee_lastname.Size = new System.Drawing.Size(139, 23);
            this.txt_employee_lastname.TabIndex = 7;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
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
            // addDepartment
            // 
            this.addDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addDepartment.Controls.Add(this.updateDepartment);
            this.addDepartment.Controls.Add(this.deleteDepartment);
            this.addDepartment.Controls.Add(this.dataGridViewDepartmentEdit);
            this.addDepartment.Controls.Add(this.addService);
            this.addDepartment.Controls.Add(this.txt_department_name);
            this.addDepartment.Controls.Add(this.label8);
            this.addDepartment.Location = new System.Drawing.Point(346, 36);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(240, 348);
            this.addDepartment.TabIndex = 2;
            this.addDepartment.TabStop = false;
            this.addDepartment.Text = "Ajouter un service";
            // 
            // updateDepartment
            // 
            this.updateDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateDepartment.Location = new System.Drawing.Point(14, 297);
            this.updateDepartment.Name = "updateDepartment";
            this.updateDepartment.Size = new System.Drawing.Size(73, 27);
            this.updateDepartment.TabIndex = 5;
            this.updateDepartment.Text = "Modifier";
            this.updateDepartment.UseVisualStyleBackColor = false;
            // 
            // deleteDepartment
            // 
            this.deleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteDepartment.Location = new System.Drawing.Point(139, 297);
            this.deleteDepartment.Name = "deleteDepartment";
            this.deleteDepartment.Size = new System.Drawing.Size(75, 27);
            this.deleteDepartment.TabIndex = 4;
            this.deleteDepartment.Text = "Supprimer";
            this.deleteDepartment.UseVisualStyleBackColor = false;
            // 
            // dataGridViewDepartmentEdit
            // 
            this.dataGridViewDepartmentEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentEdit.Location = new System.Drawing.Point(14, 106);
            this.dataGridViewDepartmentEdit.Name = "dataGridViewDepartmentEdit";
            this.dataGridViewDepartmentEdit.RowTemplate.Height = 25;
            this.dataGridViewDepartmentEdit.Size = new System.Drawing.Size(200, 177);
            this.dataGridViewDepartmentEdit.TabIndex = 3;
            // 
            // addService
            // 
            this.addService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addService.Location = new System.Drawing.Point(141, 68);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(73, 26);
            this.addService.TabIndex = 2;
            this.addService.Text = "Ajouter";
            this.addService.UseVisualStyleBackColor = false;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // txt_department_name
            // 
            this.txt_department_name.Location = new System.Drawing.Point(14, 68);
            this.txt_department_name.Name = "txt_department_name";
            this.txt_department_name.Size = new System.Drawing.Size(121, 23);
            this.txt_department_name.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nom du service";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.updateSite);
            this.groupBox1.Controls.Add(this.dataGridViewSiteEdit);
            this.groupBox1.Controls.Add(this.deleteSite);
            this.groupBox1.Controls.Add(this.addSite);
            this.groupBox1.Controls.Add(this.txt_site_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(601, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 348);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un site";
            // 
            // updateSite
            // 
            this.updateSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateSite.Location = new System.Drawing.Point(16, 297);
            this.updateSite.Name = "updateSite";
            this.updateSite.Size = new System.Drawing.Size(73, 27);
            this.updateSite.TabIndex = 7;
            this.updateSite.Text = "Modifier";
            this.updateSite.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSiteEdit
            // 
            this.dataGridViewSiteEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiteEdit.Location = new System.Drawing.Point(19, 106);
            this.dataGridViewSiteEdit.Name = "dataGridViewSiteEdit";
            this.dataGridViewSiteEdit.RowTemplate.Height = 25;
            this.dataGridViewSiteEdit.Size = new System.Drawing.Size(206, 177);
            this.dataGridViewSiteEdit.TabIndex = 4;
            // 
            // deleteSite
            // 
            this.deleteSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteSite.Location = new System.Drawing.Point(141, 297);
            this.deleteSite.Name = "deleteSite";
            this.deleteSite.Size = new System.Drawing.Size(75, 27);
            this.deleteSite.TabIndex = 6;
            this.deleteSite.Text = "Supprimer";
            this.deleteSite.UseVisualStyleBackColor = false;
            // 
            // addSite
            // 
            this.addSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addSite.Location = new System.Drawing.Point(152, 68);
            this.addSite.Name = "addSite";
            this.addSite.Size = new System.Drawing.Size(73, 26);
            this.addSite.TabIndex = 3;
            this.addSite.Text = "Ajouter";
            this.addSite.UseVisualStyleBackColor = false;
            this.addSite.Click += new System.EventHandler(this.addSite_Click);
            // 
            // txt_site_name
            // 
            this.txt_site_name.Location = new System.Drawing.Point(19, 68);
            this.txt_site_name.Name = "txt_site_name";
            this.txt_site_name.Size = new System.Drawing.Size(121, 23);
            this.txt_site_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nom du site";
            // 
            // dataGridViewEmployeeEdit
            // 
            this.dataGridViewEmployeeEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeEdit.Location = new System.Drawing.Point(24, 408);
            this.dataGridViewEmployeeEdit.Name = "dataGridViewEmployeeEdit";
            this.dataGridViewEmployeeEdit.RowTemplate.Height = 25;
            this.dataGridViewEmployeeEdit.Size = new System.Drawing.Size(823, 256);
            this.dataGridViewEmployeeEdit.TabIndex = 4;
            // 
            // updateEmployee
            // 
            this.updateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateEmployee.Location = new System.Drawing.Point(647, 692);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(73, 27);
            this.updateEmployee.TabIndex = 7;
            this.updateEmployee.Text = "Modifier";
            this.updateEmployee.UseVisualStyleBackColor = false;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteEmployee.Location = new System.Drawing.Point(772, 692);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(75, 27);
            this.deleteEmployee.TabIndex = 6;
            this.deleteEmployee.Text = "Supprimer";
            this.deleteEmployee.UseVisualStyleBackColor = false;
            // 
            // AdminEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 741);
            this.Controls.Add(this.updateEmployee);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.dataGridViewEmployeeEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addDepartment);
            this.Controls.Add(this.addEmployee);
            this.Name = "AdminEditor";
            this.Text = "Administrateur Edition";
            this.Load += new System.EventHandler(this.AdminEditor_Load_1);
            this.addEmployee.ResumeLayout(false);
            this.addEmployee.PerformLayout();
            this.addDepartment.ResumeLayout(false);
            this.addDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentEdit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Label label1;
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
        private Button add_employee;
        private GroupBox addDepartment;
        private Button addService;
        private Label label8;
        private GroupBox groupBox1;
        private Button addSite;
        private TextBox txt_site_name;
        private Label label9;
        private DataGridView dataGridViewEmployeeEdit;
        private TextBox txt_department_name;
        private DataGridView dataGridViewSiteEdit;
        private DataGridView dataGridViewDepartmentEdit;
        private Label Site;
        private Button deleteDepartment;
        private Button updateDepartment;
        private Button updateSite;
        private Button deleteSite;
        private Button updateEmployee;
        private Button deleteEmployee;
    }
}