namespace View.Forms
{
    partial class FormClubAdmin
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
            this.lblSID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblPres = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewClub)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgViewClub
            // 
            this.dgViewClub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgViewClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewClub.Location = new System.Drawing.Point(176, 126);
            this.dgViewClub.Name = "dgViewClub";
            this.dgViewClub.RowTemplate.Height = 25;
            this.dgViewClub.Size = new System.Drawing.Size(622, 159);
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
            this.button4.Location = new System.Drawing.Point(671, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 36);
            this.button4.TabIndex = 22;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = false;
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
            this.label1.Location = new System.Drawing.Point(176, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Liste des clubs";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormClubAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPres);
            this.Controls.Add(this.dgViewClub);
            this.Controls.Add(this.txtPres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormClubAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormClub";
            this.Load += new System.EventHandler(this.FormClubAdmin_Load);
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
        private Label lblSID;
        private Label lblTitle;
        private Button button4;
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
    }
}