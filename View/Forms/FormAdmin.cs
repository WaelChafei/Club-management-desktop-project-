using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class FormAdmin : Form
    {
        private Form activeForm;

        public FormAdmin()
        {
            InitializeComponent();
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
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSalle(), sender);

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
        }

        private void ClubBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormClubAdmin(), sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormReservationAdmin(), sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.FormLogin formLogin = new Forms.FormLogin();
            formLogin.Show();
            this.Hide();
        }
    }
}
