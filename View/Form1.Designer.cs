namespace View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.MyResBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ResBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ClubBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.SidebarPanel.Controls.Add(this.MyResBtn);
            this.SidebarPanel.Controls.Add(this.LogOutBtn);
            this.SidebarPanel.Controls.Add(this.ResBtn);
            this.SidebarPanel.Controls.Add(this.HomeBtn);
            this.SidebarPanel.Controls.Add(this.ClubBtn);
            this.SidebarPanel.Controls.Add(this.label6);
            this.SidebarPanel.Controls.Add(this.pictureBox1);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(163, 450);
            this.SidebarPanel.TabIndex = 5;
            // 
            // MyResBtn
            // 
            this.MyResBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyResBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.MyResBtn.FlatAppearance.BorderSize = 0;
            this.MyResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyResBtn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MyResBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MyResBtn.Location = new System.Drawing.Point(3, 288);
            this.MyResBtn.Name = "MyResBtn";
            this.MyResBtn.Padding = new System.Windows.Forms.Padding(5);
            this.MyResBtn.Size = new System.Drawing.Size(159, 47);
            this.MyResBtn.TabIndex = 2;
            this.MyResBtn.Text = "Mes Reservations";
            this.MyResBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyResBtn.UseVisualStyleBackColor = false;
            this.MyResBtn.Click += new System.EventHandler(this.MyResBtn_Click_1);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.LogOutBtn.FlatAppearance.BorderSize = 0;
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogOutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutBtn.Location = new System.Drawing.Point(1, 408);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Padding = new System.Windows.Forms.Padding(5);
            this.LogOutBtn.Size = new System.Drawing.Size(162, 41);
            this.LogOutBtn.TabIndex = 1;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ResBtn
            // 
            this.ResBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ResBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.ResBtn.FlatAppearance.BorderSize = 0;
            this.ResBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResBtn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResBtn.Location = new System.Drawing.Point(0, 241);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Padding = new System.Windows.Forms.Padding(5);
            this.ResBtn.Size = new System.Drawing.Size(162, 41);
            this.ResBtn.TabIndex = 1;
            this.ResBtn.Text = "Reserver une salle";
            this.ResBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResBtn.UseVisualStyleBackColor = false;
            this.ResBtn.Click += new System.EventHandler(this.ResBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HomeBtn.Location = new System.Drawing.Point(1, 147);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(5);
            this.HomeBtn.Size = new System.Drawing.Size(162, 41);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "Accueil";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ClubBtn
            // 
            this.ClubBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClubBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.ClubBtn.FlatAppearance.BorderSize = 0;
            this.ClubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClubBtn.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClubBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClubBtn.Location = new System.Drawing.Point(1, 194);
            this.ClubBtn.Name = "ClubBtn";
            this.ClubBtn.Padding = new System.Windows.Forms.Padding(5);
            this.ClubBtn.Size = new System.Drawing.Size(162, 41);
            this.ClubBtn.TabIndex = 1;
            this.ClubBtn.Text = "Clubs";
            this.ClubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClubBtn.UseVisualStyleBackColor = false;
            this.ClubBtn.Click += new System.EventHandler(this.ClubBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(21, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Club Management project";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDesktopPane.BackColor = System.Drawing.Color.Lavender;
            this.panelDesktopPane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktopPane.BackgroundImage")));
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDesktopPane.Controls.Add(this.lblTitle);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(163, 0);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(637, 450);
            this.panelDesktopPane.TabIndex = 6;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Lato", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTitle.Location = new System.Drawing.Point(5, 177);
            this.lblTitle.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(459, 90);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bienvenue dans le logiciel de gestion de club";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImage = global::View.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.SidebarPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidebarPanel.ResumeLayout(false);
            this.SidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel SidebarPanel;
        private Label label6;
        private PictureBox pictureBox1;
        private Panel panelDesktopPane;
        private Label lblTitle;
        private Button ClubBtn;
        private Button LogOutBtn;
        private Button ResBtn;
        private Button HomeBtn;
        private Button MyResBtn;
    }
}