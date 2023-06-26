namespace View.Forms
{
    partial class FormClub
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
            this.dgViewClub = new System.Windows.Forms.DataGridView();
            this.txtPres = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPres = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewClub)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewClub
            // 
            this.dgViewClub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewClub.Location = new System.Drawing.Point(101, 300);
            this.dgViewClub.Name = "dgViewClub";
            this.dgViewClub.RowTemplate.Height = 25;
            this.dgViewClub.Size = new System.Drawing.Size(713, 108);
            this.dgViewClub.TabIndex = 35;
            this.dgViewClub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewClub_CellContentClick);
            // 
            // txtPres
            // 
            this.txtPres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPres.Location = new System.Drawing.Point(635, 11);
            this.txtPres.Name = "txtPres";
            this.txtPres.ReadOnly = true;
            this.txtPres.Size = new System.Drawing.Size(178, 22);
            this.txtPres.TabIndex = 31;
            this.txtPres.Visible = false;
            // 
            // txtDes
            // 
            this.txtDes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDes.Location = new System.Drawing.Point(205, 147);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(575, 22);
            this.txtDes.TabIndex = 32;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMail.Location = new System.Drawing.Point(205, 115);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(575, 22);
            this.txtMail.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(205, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(575, 22);
            this.txtName.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(101, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(101, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("Lato", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(101, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSID
            // 
            this.lblSID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(512, 91);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(0, 14);
            this.lblSID.TabIndex = 29;
            this.lblSID.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTitle.Location = new System.Drawing.Point(364, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 29);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Club manager";
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button5.Location = new System.Drawing.Point(204, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(576, 33);
            this.button5.TabIndex = 21;
            this.button5.Text = "Annuler";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button4.Location = new System.Drawing.Point(653, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 36);
            this.button4.TabIndex = 22;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Location = new System.Drawing.Point(412, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 36);
            this.button3.TabIndex = 23;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAdd.Location = new System.Drawing.Point(205, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 36);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPres
            // 
            this.lblPres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPres.AutoSize = true;
            this.lblPres.Location = new System.Drawing.Point(101, 183);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(0, 14);
            this.lblPres.TabIndex = 36;
            this.lblPres.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 73);
            this.panel1.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::View.Properties.Resources.Vie_associative;
            this.pictureBox1.Location = new System.Drawing.Point(248, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(101, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Liste des clubs";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(346, 22);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPres);
            this.Controls.Add(this.dgViewClub);
            this.Controls.Add(this.txtPres);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormClub";
            this.Load += new System.EventHandler(this.FormClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewClub)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgViewClub;
        private TextBox txtPres;
        private TextBox txtDes;
        private TextBox txtMail;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label lblSID;
        private Label lblTitle;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button6;
        private Button button7;
        private Label lblPres;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}