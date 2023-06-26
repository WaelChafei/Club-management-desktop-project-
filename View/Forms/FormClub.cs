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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View.Forms
{
    public partial class FormClub : Form
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
                String query = "Select * From Club WHERE idPresident = '" + Forms.FormLogin.UserID.ToString() + "'";
                adapter = new SqlDataAdapter(query, con);
                 dt = new DataTable();
                adapter.Fill(dt);
                dgViewClub.DataSource = dt;
            }
        }
        private DataTable dtreturn()
        {
            using (SqlConnection con = new SqlConnection("database=ClubprojBD;server=DESKTOP-KIMMDIF;User ID=sa;pwd=23110069"))
            {
                string query = "SELECT id,name FROM Club";

                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }


                return dt;
            }
        }

        public FormClub()
        {
            InitializeComponent();
            ShowDataOnGridView();
        }

        private void FormClub_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
            lblPres.Text = Forms.FormLogin.UserID.ToString();
            comboBox1.DataSource = dtreturn();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClubADO clubADO = new ClubADO();
            bool success = clubADO.ajouter_club(txtName.Text, txtMail.Text, txtDes.Text, int.Parse(lblPres.Text));

            if (success)
            {
                MessageBox.Show("Club added successfully");
                ShowDataOnGridView(); // refresh grid view
            }
            else
            {
                MessageBox.Show("Club could not be added");
            }
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Instantiate ClubADO class
            ClubADO clubADO = new ClubADO();
            // Call ajouter_club method
            bool success = false;
            if (lblSID.Text != "")
            {
                success = clubADO.update_club(txtName.Text, txtMail.Text, txtDes.Text, int.Parse(lblPres.Text), int.Parse(lblSID.Text));
            }
            else
            {
                MessageBox.Show("Select the club that you want to update !!");

            }
            if (success)
            {
                MessageBox.Show("Club updated successfully");
                ShowDataOnGridView(); // refresh grid view
            }
            else
            {
                MessageBox.Show("Club could not be updated");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Instantiate ClubADO class
            ClubADO clubADO = new ClubADO();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            string selectedValue = comboBox1.SelectedValue.ToString();

            lblSID.Text = selectedValue;
        }
    }
}
 