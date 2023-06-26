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
    public partial class FormReservationAdmin : Form
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
                adapter = new SqlDataAdapter("Select * From Reservation ", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        public FormReservationAdmin()
        {
            InitializeComponent();
            ShowDataOnGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSID.Text = this.dataGridView1.CurrentRow.Cells["id"].Value.ToString();

        }

        private void FormReservationAdmin_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
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
    }
}
