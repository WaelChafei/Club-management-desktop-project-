using Controllers;
using Models;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Configuration;
using View.Forms;

namespace View
{
    public partial class Form1 : Form
    {
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
    }
        private void PanelButton1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void ClubBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClub(), sender);
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClub(), sender);
        }
        private void ResBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReservation(), sender);
        }
        private void SalleBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSalle(), sender);
        }
        private void MyResBtn_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMyReservations(), sender);
        }
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Forms.FormLogin formLogin = new Forms.FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
 
    }

 
}