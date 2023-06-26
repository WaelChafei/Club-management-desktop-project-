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
using System.Xml.Linq;

namespace View.Forms
{
    public partial class FormMyReservations : Form
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
                adapter = new SqlDataAdapter(@"SELECT R.id, C.name AS ClubName, S.num AS SalleNum, R.date_reservation, R.nb_heurs 
                                       FROM Reservation R
                                       INNER JOIN Club C ON R.idClub = C.id
                                       INNER JOIN Salle S ON R.idSalle = S.id", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private DataTable dtreturn()
        {
            using (SqlConnection con = new SqlConnection("database=ClubprojBD;server=DESKTOP-KIMMDIF;User ID=sa;pwd=23110069"))
            {
                string query = "SELECT id FROM Reservation";

                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }


                return dt;
            }
        }

        public FormMyReservations()
        {
            InitializeComponent();
            ShowDataOnGridView();
        }

 

        private void FormMyReservations_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
            comboBox1.DataSource = dtreturn();
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";
        }

   
        private void button4_Click(object sender, EventArgs e)
        {
            // Instantiate ClubADO class
            ReservationADO clubADO = new ReservationADO();
            // Call ajouter_club method
            bool success = false;
            if (lblSID.Text != "")
            {
                success = clubADO.delete_reservation(int.Parse(lblSID.Text));
            }
            else
            {
                MessageBox.Show("Select the resrvation that you want to delete !!");

            }
            if (success)
            {
                MessageBox.Show("Resrvation deleted successfully");
                ShowDataOnGridView(); // refresh grid view
            }
            else
            {
                MessageBox.Show("Resrvation could not be deleted ");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "id";
            comboBox1.ValueMember = "id";
            string selectedValue = comboBox1.SelectedValue.ToString();

            lblSID.Text = selectedValue;
        }

        private void reservationBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
