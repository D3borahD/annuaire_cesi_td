﻿namespace WinFormsApp1
{
    partial class Annuaire
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.edition = new System.Windows.Forms.Button();
            this.dataGridViewSiteDisplay = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartmentDisplay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(697, 154);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(351, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "rechercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 23);
            this.textBox1.TabIndex = 3;
            // 
            // edition
            // 
            this.edition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edition.Location = new System.Drawing.Point(12, 19);
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(128, 43);
            this.edition.TabIndex = 4;
            this.edition.Text = "edition";
            this.edition.UseVisualStyleBackColor = false;
            this.edition.Click += new System.EventHandler(this.edition_Click);
            // 
            // dataGridViewSiteDisplay
            // 
            this.dataGridViewSiteDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiteDisplay.Location = new System.Drawing.Point(23, 104);
            this.dataGridViewSiteDisplay.Name = "dataGridViewSiteDisplay";
            this.dataGridViewSiteDisplay.RowTemplate.Height = 25;
            this.dataGridViewSiteDisplay.Size = new System.Drawing.Size(148, 158);
            this.dataGridViewSiteDisplay.TabIndex = 5;
            this.dataGridViewSiteDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiteDisplay_CellContentClick);
            // 
            // dataGridViewDepartmentDisplay
            // 
            this.dataGridViewDepartmentDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentDisplay.Location = new System.Drawing.Point(197, 104);
            this.dataGridViewDepartmentDisplay.Name = "dataGridViewDepartmentDisplay";
            this.dataGridViewDepartmentDisplay.RowTemplate.Height = 25;
            this.dataGridViewDepartmentDisplay.Size = new System.Drawing.Size(148, 158);
            this.dataGridViewDepartmentDisplay.TabIndex = 6;
            this.dataGridViewDepartmentDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiteDisplay_CellContentClick);
            // 
            // Annuaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 627);
            this.Controls.Add(this.dataGridViewDepartmentDisplay);
            this.Controls.Add(this.dataGridViewSiteDisplay);
            this.Controls.Add(this.edition);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Annuaire";
            this.Text = "Annuaire";
            this.Load += new System.EventHandler(this.Annuaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private Button edition;
        private DataGridView dataGridViewSiteDisplay;
        private DataGridView dataGridViewDepartmentDisplay;
    }
}