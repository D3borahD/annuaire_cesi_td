namespace WinFormsApp1
{
    partial class UpdateSite
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
            this.saveUpdateSite = new System.Windows.Forms.Button();
            this.txt_site_update = new System.Windows.Forms.TextBox();
            this.labelSite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveUpdateSite
            // 
            this.saveUpdateSite.BackColor = System.Drawing.Color.Navy;
            this.saveUpdateSite.ForeColor = System.Drawing.Color.White;
            this.saveUpdateSite.Location = new System.Drawing.Point(81, 168);
            this.saveUpdateSite.Name = "saveUpdateSite";
            this.saveUpdateSite.Size = new System.Drawing.Size(100, 31);
            this.saveUpdateSite.TabIndex = 11;
            this.saveUpdateSite.Text = "Modifier";
            this.saveUpdateSite.UseVisualStyleBackColor = false;
            this.saveUpdateSite.Click += new System.EventHandler(this.saveUpdateSite_Click);
            // 
            // txt_site_update
            // 
            this.txt_site_update.Location = new System.Drawing.Point(42, 107);
            this.txt_site_update.Name = "txt_site_update";
            this.txt_site_update.Size = new System.Drawing.Size(176, 23);
            this.txt_site_update.TabIndex = 10;
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSite.ForeColor = System.Drawing.Color.Navy;
            this.labelSite.Location = new System.Drawing.Point(93, 60);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(74, 15);
            this.labelSite.TabIndex = 9;
            this.labelSite.Text = "Nom du site";
            // 
            // UpdateSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 252);
            this.Controls.Add(this.saveUpdateSite);
            this.Controls.Add(this.txt_site_update);
            this.Controls.Add(this.labelSite);
            this.Name = "UpdateSite";
            this.Text = "Modifier un site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveUpdateSite;
        private TextBox txt_site_update;
        private Label labelSite;
    }
}