namespace View.Forms
{
    partial class FormSalle
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
            this.dgViewSalle = new System.Windows.Forms.DataGridView();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.lblSID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgViewSalle
            // 
            this.dgViewSalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgViewSalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgViewSalle.Location = new System.Drawing.Point(512, 117);
            this.dgViewSalle.Name = "dgViewSalle";
            this.dgViewSalle.RowTemplate.Height = 25;
            this.dgViewSalle.Size = new System.Drawing.Size(339, 258);
            this.dgViewSalle.TabIndex = 0;
            this.dgViewSalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgViewSalle_CellContentClick);
            // 
            // txtNum
            // 
            this.txtNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNum.Location = new System.Drawing.Point(358, 127);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(129, 23);
            this.txtNum.TabIndex = 1;
            // 
            // txtBlock
            // 
            this.txtBlock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBlock.Location = new System.Drawing.Point(358, 182);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(129, 23);
            this.txtBlock.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(198, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero du Salle";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(198, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Block du salle";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddBtn.FlatAppearance.BorderSize = 0;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.AddBtn.Location = new System.Drawing.Point(198, 248);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 36);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Ajouter";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.UpdateBtn.Location = new System.Drawing.Point(305, 248);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 36);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Modifier";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(26)))), ((int)(((byte)(42)))));
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.DeleteBtn.Location = new System.Drawing.Point(412, 248);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 36);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.BackColor = System.Drawing.Color.DimGray;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CancelBtn.Location = new System.Drawing.Point(198, 309);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(289, 35);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // lblSID
            // 
            this.lblSID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(534, 68);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(0, 15);
            this.lblSID.TabIndex = 4;
            this.lblSID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.Vie_associative;
            this.pictureBox1.Location = new System.Drawing.Point(280, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 73);
            this.panel1.TabIndex = 38;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTitle.Location = new System.Drawing.Point(402, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 29);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Salle manager";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(512, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liste des salles";
            // 
            // FormSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlock);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.dgViewSalle);
            this.Name = "FormSalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSalle";
            this.Load += new System.EventHandler(this.FormSalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgViewSalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgViewSalle;
        private TextBox txtNum;
        private TextBox txtBlock;
        private Label label1;
        private Label label2;
        private Button AddBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button CancelBtn;
        private Label lblSID;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTitle;
        private Label label3;
    }
}