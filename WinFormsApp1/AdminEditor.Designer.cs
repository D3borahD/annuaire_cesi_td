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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEditor));
            this.addEmployee = new System.Windows.Forms.GroupBox();
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.listBoxSite = new System.Windows.Forms.ListBox();
            this.add_employee = new System.Windows.Forms.Button();
            this.txt_employee_mobile = new System.Windows.Forms.TextBox();
            this.txt_employee_landline = new System.Windows.Forms.TextBox();
            this.txt_employee_firstname = new System.Windows.Forms.TextBox();
            this.txt_employee_lastname = new System.Windows.Forms.TextBox();
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
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchEmployee = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addEmployee.SuspendLayout();
            this.addDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentEdit)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEmployee
            // 
            this.addEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addEmployee.Controls.Add(this.listBoxDepartment);
            this.addEmployee.Controls.Add(this.listBoxSite);
            this.addEmployee.Controls.Add(this.add_employee);
            this.addEmployee.Controls.Add(this.txt_employee_mobile);
            this.addEmployee.Controls.Add(this.txt_employee_landline);
            this.addEmployee.Controls.Add(this.txt_employee_firstname);
            this.addEmployee.Controls.Add(this.txt_employee_lastname);
            this.addEmployee.Controls.Add(this.label6);
            this.addEmployee.Controls.Add(this.label5);
            this.addEmployee.Controls.Add(this.label4);
            this.addEmployee.Controls.Add(this.label3);
            this.addEmployee.Controls.Add(this.label2);
            this.addEmployee.Controls.Add(this.name);
            this.addEmployee.Location = new System.Drawing.Point(31, 193);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(319, 348);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.TabStop = false;
            this.addEmployee.Text = "Ajouter un employé";
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.ItemHeight = 20;
            this.listBoxDepartment.Location = new System.Drawing.Point(134, 155);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(162, 44);
            this.listBoxDepartment.TabIndex = 17;
            // 
            // listBoxSite
            // 
            this.listBoxSite.FormattingEnabled = true;
            this.listBoxSite.ItemHeight = 20;
            this.listBoxSite.Items.AddRange(new object[] {
            "Test",
            "test1",
            "TEST2",
            "tet",
            "df",
            "po"});
            this.listBoxSite.Location = new System.Drawing.Point(134, 97);
            this.listBoxSite.Name = "listBoxSite";
            this.listBoxSite.Size = new System.Drawing.Size(162, 44);
            this.listBoxSite.TabIndex = 16;
            // 
            // add_employee
            // 
            this.add_employee.BackColor = System.Drawing.Color.Navy;
            this.add_employee.ForeColor = System.Drawing.Color.White;
            this.add_employee.Location = new System.Drawing.Point(212, 292);
            this.add_employee.Name = "add_employee";
            this.add_employee.Size = new System.Drawing.Size(84, 32);
            this.add_employee.TabIndex = 14;
            this.add_employee.Text = "Ajouter";
            this.add_employee.UseVisualStyleBackColor = false;
            this.add_employee.Click += new System.EventHandler(this.add_employee_Click);
            // 
            // txt_employee_mobile
            // 
            this.txt_employee_mobile.Location = new System.Drawing.Point(134, 245);
            this.txt_employee_mobile.Name = "txt_employee_mobile";
            this.txt_employee_mobile.Size = new System.Drawing.Size(162, 27);
            this.txt_employee_mobile.TabIndex = 12;
            // 
            // txt_employee_landline
            // 
            this.txt_employee_landline.Location = new System.Drawing.Point(134, 213);
            this.txt_employee_landline.Name = "txt_employee_landline";
            this.txt_employee_landline.Size = new System.Drawing.Size(162, 27);
            this.txt_employee_landline.TabIndex = 11;
            // 
            // txt_employee_firstname
            // 
            this.txt_employee_firstname.Location = new System.Drawing.Point(134, 65);
            this.txt_employee_firstname.Name = "txt_employee_firstname";
            this.txt_employee_firstname.Size = new System.Drawing.Size(162, 27);
            this.txt_employee_firstname.TabIndex = 8;
            // 
            // txt_employee_lastname
            // 
            this.txt_employee_lastname.Location = new System.Drawing.Point(134, 33);
            this.txt_employee_lastname.Name = "txt_employee_lastname";
            this.txt_employee_lastname.Size = new System.Drawing.Size(162, 27);
            this.txt_employee_lastname.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(16, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(16, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Téléphone Fixe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(16, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Site";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.Navy;
            this.name.Location = new System.Drawing.Point(16, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(44, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Nom";
            // 
            // addDepartment
            // 
            this.addDepartment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addDepartment.Controls.Add(this.updateDepartment);
            this.addDepartment.Controls.Add(this.deleteDepartment);
            this.addDepartment.Controls.Add(this.dataGridViewDepartmentEdit);
            this.addDepartment.Controls.Add(this.addService);
            this.addDepartment.Controls.Add(this.txt_department_name);
            this.addDepartment.Controls.Add(this.label8);
            this.addDepartment.Location = new System.Drawing.Point(700, 193);
            this.addDepartment.Name = "addDepartment";
            this.addDepartment.Size = new System.Drawing.Size(287, 348);
            this.addDepartment.TabIndex = 2;
            this.addDepartment.TabStop = false;
            this.addDepartment.Text = "Ajouter un service";
            // 
            // updateDepartment
            // 
            this.updateDepartment.BackColor = System.Drawing.Color.Navy;
            this.updateDepartment.ForeColor = System.Drawing.Color.White;
            this.updateDepartment.Location = new System.Drawing.Point(41, 292);
            this.updateDepartment.Name = "updateDepartment";
            this.updateDepartment.Size = new System.Drawing.Size(79, 32);
            this.updateDepartment.TabIndex = 5;
            this.updateDepartment.Text = "Modifier";
            this.updateDepartment.UseVisualStyleBackColor = false;
            this.updateDepartment.Click += new System.EventHandler(this.updateDepartment_Click);
            // 
            // deleteDepartment
            // 
            this.deleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteDepartment.Location = new System.Drawing.Point(141, 292);
            this.deleteDepartment.Name = "deleteDepartment";
            this.deleteDepartment.Size = new System.Drawing.Size(92, 32);
            this.deleteDepartment.TabIndex = 4;
            this.deleteDepartment.Text = "Supprimer";
            this.deleteDepartment.UseVisualStyleBackColor = false;
            this.deleteDepartment.Click += new System.EventHandler(this.deleteDepartment_Click);
            // 
            // dataGridViewDepartmentEdit
            // 
            this.dataGridViewDepartmentEdit.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewDepartmentEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDepartmentEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentEdit.Location = new System.Drawing.Point(27, 106);
            this.dataGridViewDepartmentEdit.Name = "dataGridViewDepartmentEdit";
            this.dataGridViewDepartmentEdit.ReadOnly = true;
            this.dataGridViewDepartmentEdit.RowHeadersWidth = 51;
            this.dataGridViewDepartmentEdit.RowTemplate.Height = 25;
            this.dataGridViewDepartmentEdit.Size = new System.Drawing.Size(230, 177);
            this.dataGridViewDepartmentEdit.TabIndex = 3;
            // 
            // addService
            // 
            this.addService.BackColor = System.Drawing.Color.Navy;
            this.addService.ForeColor = System.Drawing.Color.White;
            this.addService.Location = new System.Drawing.Point(141, 65);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(82, 29);
            this.addService.TabIndex = 2;
            this.addService.Text = "Ajouter";
            this.addService.UseVisualStyleBackColor = false;
            this.addService.Click += new System.EventHandler(this.addService_Click);
            // 
            // txt_department_name
            // 
            this.txt_department_name.Location = new System.Drawing.Point(14, 68);
            this.txt_department_name.Name = "txt_department_name";
            this.txt_department_name.Size = new System.Drawing.Size(121, 27);
            this.txt_department_name.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(14, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nom du service";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.updateSite);
            this.groupBox1.Controls.Add(this.dataGridViewSiteEdit);
            this.groupBox1.Controls.Add(this.deleteSite);
            this.groupBox1.Controls.Add(this.addSite);
            this.groupBox1.Controls.Add(this.txt_site_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(375, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 348);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un site";
            // 
            // updateSite
            // 
            this.updateSite.BackColor = System.Drawing.Color.Navy;
            this.updateSite.ForeColor = System.Drawing.Color.White;
            this.updateSite.Location = new System.Drawing.Point(44, 292);
            this.updateSite.Name = "updateSite";
            this.updateSite.Size = new System.Drawing.Size(80, 32);
            this.updateSite.TabIndex = 6;
            this.updateSite.Text = "Modifier";
            this.updateSite.UseVisualStyleBackColor = false;
            this.updateSite.Click += new System.EventHandler(this.updateSite_Click);
            // 
            // dataGridViewSiteEdit
            // 
            this.dataGridViewSiteEdit.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewSiteEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSiteEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiteEdit.Location = new System.Drawing.Point(29, 106);
            this.dataGridViewSiteEdit.Name = "dataGridViewSiteEdit";
            this.dataGridViewSiteEdit.ReadOnly = true;
            this.dataGridViewSiteEdit.RowHeadersWidth = 51;
            this.dataGridViewSiteEdit.RowTemplate.Height = 25;
            this.dataGridViewSiteEdit.Size = new System.Drawing.Size(243, 177);
            this.dataGridViewSiteEdit.TabIndex = 4;
            this.dataGridViewSiteEdit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiteEdit_CellContentClick);
            // 
            // deleteSite
            // 
            this.deleteSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteSite.Location = new System.Drawing.Point(152, 292);
            this.deleteSite.Name = "deleteSite";
            this.deleteSite.Size = new System.Drawing.Size(95, 32);
            this.deleteSite.TabIndex = 6;
            this.deleteSite.Text = "Supprimer";
            this.deleteSite.UseVisualStyleBackColor = false;
            this.deleteSite.Click += new System.EventHandler(this.deleteSite_Click);
            // 
            // addSite
            // 
            this.addSite.BackColor = System.Drawing.Color.Navy;
            this.addSite.ForeColor = System.Drawing.Color.White;
            this.addSite.Location = new System.Drawing.Point(152, 65);
            this.addSite.Name = "addSite";
            this.addSite.Size = new System.Drawing.Size(84, 29);
            this.addSite.TabIndex = 3;
            this.addSite.Text = "Ajouter";
            this.addSite.UseVisualStyleBackColor = false;
            this.addSite.Click += new System.EventHandler(this.addSite_Click);
            // 
            // txt_site_name
            // 
            this.txt_site_name.Location = new System.Drawing.Point(19, 68);
            this.txt_site_name.Name = "txt_site_name";
            this.txt_site_name.Size = new System.Drawing.Size(121, 27);
            this.txt_site_name.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(19, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nom du site";
            // 
            // dataGridViewEmployeeEdit
            // 
            this.dataGridViewEmployeeEdit.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEmployeeEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployeeEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeEdit.Location = new System.Drawing.Point(16, 86);
            this.dataGridViewEmployeeEdit.Name = "dataGridViewEmployeeEdit";
            this.dataGridViewEmployeeEdit.ReadOnly = true;
            this.dataGridViewEmployeeEdit.RowHeadersWidth = 51;
            this.dataGridViewEmployeeEdit.RowTemplate.Height = 25;
            this.dataGridViewEmployeeEdit.Size = new System.Drawing.Size(923, 256);
            this.dataGridViewEmployeeEdit.TabIndex = 4;
            // 
            // updateEmployee
            // 
            this.updateEmployee.BackColor = System.Drawing.Color.Navy;
            this.updateEmployee.ForeColor = System.Drawing.Color.White;
            this.updateEmployee.Location = new System.Drawing.Point(644, 35);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(78, 31);
            this.updateEmployee.TabIndex = 7;
            this.updateEmployee.Text = "Modifier";
            this.updateEmployee.UseVisualStyleBackColor = false;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteEmployee.Location = new System.Drawing.Point(825, 35);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(101, 31);
            this.deleteEmployee.TabIndex = 6;
            this.deleteEmployee.Text = "Supprimer";
            this.deleteEmployee.UseVisualStyleBackColor = false;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Navy;
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Location = new System.Drawing.Point(895, 138);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(92, 36);
            this.refresh.TabIndex = 8;
            this.refresh.Text = "Actualiser";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(290, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "NATURAL PRODUCT - Annuaire";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(375, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 41);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fenêtre d\'édition";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(14, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nom";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.White;
            this.textBoxSearch.Location = new System.Drawing.Point(78, 38);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(186, 27);
            this.textBoxSearch.TabIndex = 13;
            // 
            // searchEmployee
            // 
            this.searchEmployee.BackColor = System.Drawing.Color.Navy;
            this.searchEmployee.ForeColor = System.Drawing.Color.White;
            this.searchEmployee.Location = new System.Drawing.Point(270, 32);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(85, 34);
            this.searchEmployee.TabIndex = 12;
            this.searchEmployee.Text = "Rechercher";
            this.searchEmployee.UseVisualStyleBackColor = false;
            this.searchEmployee.Click += new System.EventHandler(this.searchEmployee_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.searchEmployee);
            this.groupBox2.Controls.Add(this.updateEmployee);
            this.groupBox2.Controls.Add(this.deleteEmployee);
            this.groupBox2.Controls.Add(this.dataGridViewEmployeeEdit);
            this.groupBox2.Location = new System.Drawing.Point(31, 572);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 370);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // AdminEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 978);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addDepartment);
            this.Controls.Add(this.addEmployee);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private Label label1;
        private GroupBox addEmployee;
        private TextBox txt_employee_mobile;
        private TextBox txt_employee_landline;
        private TextBox txt_employee_firstname;
        private TextBox txt_employee_lastname;
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
        private Button deleteDepartment;
        private Button updateDepartment;
        private Button deleteSite;
        private Button updateEmployee;
        private Button deleteEmployee;
        private ListBox listBoxSite;
        private ListBox listBoxDepartment;
        private Button refresh;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label10;
        private TextBox textBoxSearch;
        private Button searchEmployee;
        private GroupBox groupBox2;
        private Button updateSite;
    }
}