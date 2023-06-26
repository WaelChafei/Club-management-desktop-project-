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
    public partial class FormReservation : Form
    {
        string cs = "database=ClubprojBD;server=DESKTOP-KIMMDIF;User ID=sa;pwd=23110069";
        SqlConnection con;
        SqlDataAdapter adapter;
        DataTable dt;
        private DataTable dtreturn()
        {
            using (SqlConnection con = new SqlConnection("database=ClubprojBD;server=DESKTOP-KIMMDIF;User ID=sa;pwd=23110069"))
            {
                string query = "SELECT id, name FROM Club";

                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }


                return dt;
            }
        }
        private DataTable dtreturn2()
        {
            using (SqlConnection con = new SqlConnection("database=ClubprojBD;server=DESKTOP-KIMMDIF;User ID=sa;pwd=23110069"))
            {
                string query = "SELECT id, num FROM Salle";

                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }


                return dt;
            }
        }


    
   

  

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = this.dateTimePicker1.Value.ToString();
        }
     
        public FormReservation()
        {
            InitializeComponent();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void FormReservation_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
            comboBox1.DataSource = dtreturn();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

            comboBox2.DataSource = dtreturn2();
            comboBox2.DisplayMember = "num";
            comboBox2.ValueMember = "id";
        }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReservationADO reservationADO = new ReservationADO();
            bool success = reservationADO.ajouter_reservation(int.Parse(lblClub.Text), int.Parse(lblSalle.Text), DateTime.Parse(lblDate.Text), Convert.ToInt32(nbHeurs.Value));

            if (success)
            {
                MessageBox.Show("Vous aver ajouter une demande de reservation !");
            }
            else
            {
                MessageBox.Show("Reservation échouee !");
            }
        }

        private void nbHeurs_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            string selectedValue = comboBox1.SelectedValue.ToString();

            lblClub.Text = selectedValue;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "num";
            comboBox2.ValueMember = "id";
            string selectedValue = comboBox2.SelectedValue.ToString();

            lblSalle.Text = selectedValue;
        }
    }
}
