namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Annuaire));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewSiteDisplay = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartmentDisplay = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(312, 271);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(640, 511);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayEmplyeeCard_CellClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(607, 176);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(387, 185);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 27);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridViewSiteDisplay
            // 
            this.dataGridViewSiteDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSiteDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSiteDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiteDisplay.Location = new System.Drawing.Point(58, 271);
            this.dataGridViewSiteDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSiteDisplay.Name = "dataGridViewSiteDisplay";
            this.dataGridViewSiteDisplay.ReadOnly = true;
            this.dataGridViewSiteDisplay.RowHeadersWidth = 51;
            this.dataGridViewSiteDisplay.RowTemplate.Height = 25;
            this.dataGridViewSiteDisplay.Size = new System.Drawing.Size(209, 239);
            this.dataGridViewSiteDisplay.TabIndex = 5;
            this.dataGridViewSiteDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSiteDisplay_CellContentClick);
            // 
            // dataGridViewDepartmentDisplay
            // 
            this.dataGridViewDepartmentDisplay.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDepartmentDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDepartmentDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmentDisplay.Location = new System.Drawing.Point(58, 548);
            this.dataGridViewDepartmentDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDepartmentDisplay.Name = "dataGridViewDepartmentDisplay";
            this.dataGridViewDepartmentDisplay.ReadOnly = true;
            this.dataGridViewDepartmentDisplay.RowHeadersWidth = 51;
            this.dataGridViewDepartmentDisplay.RowTemplate.Height = 25;
            this.dataGridViewDepartmentDisplay.Size = new System.Drawing.Size(209, 233);
            this.dataGridViewDepartmentDisplay.TabIndex = 6;
            this.dataGridViewDepartmentDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartmentDisplay_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 139);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(269, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "NATURAL PRODUCT - Annuaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(314, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nom";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(387, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(501, 116);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // Annuaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(959, 835);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewDepartmentDisplay);
            this.Controls.Add(this.dataGridViewSiteDisplay);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Annuaire";
            this.Text = "Annuaire";
            this.Load += new System.EventHandler(this.Annuaire_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdminAcces_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiteDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmentDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridViewSiteDisplay;
        private DataGridView dataGridViewDepartmentDisplay;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}