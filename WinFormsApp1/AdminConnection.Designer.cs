namespace WinFormsApp1
{
    partial class AdminConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password_box = new System.Windows.Forms.TextBox();
            this.btn_check_password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de passe :";
            // 
            // txt_password_box
            // 
            this.txt_password_box.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_password_box.Location = new System.Drawing.Point(27, 81);
            this.txt_password_box.Name = "txt_password_box";
            this.txt_password_box.Size = new System.Drawing.Size(225, 23);
            this.txt_password_box.TabIndex = 1;
            // 
            // btn_check_password
            // 
            this.btn_check_password.BackColor = System.Drawing.Color.Navy;
            this.btn_check_password.ForeColor = System.Drawing.Color.White;
            this.btn_check_password.Location = new System.Drawing.Point(134, 136);
            this.btn_check_password.Name = "btn_check_password";
            this.btn_check_password.Size = new System.Drawing.Size(104, 26);
            this.btn_check_password.TabIndex = 2;
            this.btn_check_password.Text = "Se connecter";
            this.btn_check_password.UseVisualStyleBackColor = false;
            this.btn_check_password.Click += new System.EventHandler(this.btn_check_password_Click);
            // 
            // AdminConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 202);
            this.Controls.Add(this.btn_check_password);
            this.Controls.Add(this.txt_password_box);
            this.Controls.Add(this.label1);
            this.Name = "AdminConnection";
            this.Text = "Connexion Administrateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_password_box;
        private Button btn_check_password;
    }
}