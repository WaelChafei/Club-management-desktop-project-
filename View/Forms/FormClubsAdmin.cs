using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class FormClubAdmin : Form
    {

        string cs = "database=ClubprojBD;server=DESKTOP-KIMMDIF;User ID=sa;pwd=23110069";
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        public void ShowDataOnGridView()
        {

            using (con = new SqlConnection(cs))
            {
                String query = "Select * From Club ";
                adapter = new SqlDataAdapter(query, con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgViewClub.DataSource = dt;
            }
        }

        public FormClubAdmin()
        {
            InitializeComponent();
            ShowDataOnGridView();
        }

        private void FormClubAdmin_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
            lblPres.Text = Forms.FormLogin.UserID.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

  

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgViewClub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSID.Text = this.dgViewClub.CurrentRow.Cells["id"].Value.ToString();

        }
        private void dgViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // txtPres.Text = this.dgViewUser.CurrentRow.Cells["id"].Value.ToString();
        }

   
        private void button4_Click(object sender, EventArgs e)
        {
            // Instantiate ClubADO class
            ClubADO clubADO = new ClubADO();
            // Call ajouter_club method
            bool success = false;
            if (lblSID.Text != "")
            {
                success = clubADO.delete_club(int.Parse(lblSID.Text));
            }
            else
            {
                MessageBox.Show("Select the club that you want to delete !!");

            }
            if (success)
            {
                MessageBox.Show("Club deleted successfully");
                ShowDataOnGridView(); // refresh grid view
            }
            else
            {
                MessageBox.Show("Club could not be deleted ");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgViewClub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSID.Text = this.dgViewClub.CurrentRow.Cells["id"].Value.ToString();
        }
    }
}
