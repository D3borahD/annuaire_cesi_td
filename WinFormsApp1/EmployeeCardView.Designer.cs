namespace WinFormsApp1
{
    partial class EmployeeCardView
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
            this.lastname = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.landline = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.Label();
            this.Site = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(39, 50);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(48, 21);
            this.lastname.TabIndex = 0;
            this.lastname.Text = "Nom";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstname.Location = new System.Drawing.Point(163, 50);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(70, 21);
            this.firstname.TabIndex = 1;
            this.firstname.Text = "Prénom";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mobile.Location = new System.Drawing.Point(163, 149);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(44, 15);
            this.mobile.TabIndex = 3;
            this.mobile.Text = "Mobile";
            // 
            // landline
            // 
            this.landline.AutoSize = true;
            this.landline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.landline.Location = new System.Drawing.Point(163, 115);
            this.landline.Name = "landline";
            this.landline.Size = new System.Drawing.Size(85, 15);
            this.landline.TabIndex = 2;
            this.landline.Text = "Téléphone Fixe";
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Department.Location = new System.Drawing.Point(163, 217);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(44, 15);
            this.Department.TabIndex = 5;
            this.Department.Text = "Service";
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Site.Location = new System.Drawing.Point(163, 183);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(26, 15);
            this.Site.TabIndex = 4;
            this.Site.Text = "Site";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Site";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Téléphone Fixe";
            // 
            // EmployeeCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.Site);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.landline);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Name = "EmployeeCardView";
            this.Text = "Fiche employé(e)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lastname;
        private Label firstname;
        private Label mobile;
        private Label landline;
        private Label Department;
        private Label Site;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}