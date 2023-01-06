namespace WinFormsApp1
{
    partial class UpdateDepartment
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
            this.saveUpdateDepartment = new System.Windows.Forms.Button();
            this.txt_department_update = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveUpdateDepartment
            // 
            this.saveUpdateDepartment.BackColor = System.Drawing.Color.Navy;
            this.saveUpdateDepartment.ForeColor = System.Drawing.Color.White;
            this.saveUpdateDepartment.Location = new System.Drawing.Point(100, 138);
            this.saveUpdateDepartment.Name = "saveUpdateDepartment";
            this.saveUpdateDepartment.Size = new System.Drawing.Size(73, 27);
            this.saveUpdateDepartment.TabIndex = 8;
            this.saveUpdateDepartment.Text = "Modifier";
            this.saveUpdateDepartment.UseVisualStyleBackColor = false;
            this.saveUpdateDepartment.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_department_update
            // 
            this.txt_department_update.Location = new System.Drawing.Point(60, 82);
            this.txt_department_update.Name = "txt_department_update";
            this.txt_department_update.Size = new System.Drawing.Size(152, 23);
            this.txt_department_update.TabIndex = 7;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(91, 38);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(90, 15);
            this.labelDepartment.TabIndex = 6;
            this.labelDepartment.Text = "Nom du service";
            // 
            // UpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 194);
            this.Controls.Add(this.saveUpdateDepartment);
            this.Controls.Add(this.txt_department_update);
            this.Controls.Add(this.labelDepartment);
            this.Name = "UpdateDepartment";
            this.Text = "Modifer un service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveUpdateDepartment;
        private TextBox txt_department_update;
        private Label labelDepartment;
    }
}