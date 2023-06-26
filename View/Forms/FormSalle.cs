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
    public partial class FormSalle : Form
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
                adapter = new SqlDataAdapter("Select * From Salle ", con);
                dt = new DataTable();
                adapter.Fill(dt);
                dgViewSalle.DataSource = dt;
            }
     
        }

        public FormSalle()
        {
            InitializeComponent();
            ShowDataOnGridView();
        }

        private void FormSalle_Load(object sender, EventArgs e)
        {
            Connexion cn = new Connexion();
            cn.OpenConection();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            SalleADO salleADO = new SalleADO();
            bool success = salleADO.ajouter_salle(int.Parse(txtNum.Text), txtBlock.Text);

            if (success)
            {
                MessageBox.Show("Salle added successfully");
                ShowDataOnGridView(); // refresh grid view
            }
            else
            {
                MessageBox.Show("Salle could not be added");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            // Instantiate ClubADO class
            SalleADO salleADO = new SalleADO();
            // Call ajouter_club method
            bool success = false;
            if (lblSID.Text != "")
            {
                success = salleADO.update_salle(int.Parse(txtNum.Text), txtBlock.Text, int.Parse(lblSID.Text));
            }
            else
            {
                MessageBox.Show("Select the Salle that you want to update !!");

            }
            if (success)
            {
                MessageBox.Show("Salle updated successfully");
                ShowDataOnGridView(); // refresh grid view
            }
            else
            {
                MessageBox.Show("Salle could not be updated");
            }
        }

        private void dgViewSalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSID.Text = this.dgViewSalle.CurrentRow.Cells["id"].Value.ToString();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SalleADO salleADO = new SalleADO();
            bool success = false;
            if (lblSID.Text != "")
            {
                success = salleADO.delete_salle(int.Parse(lblSID.Text));
            }
            else
            {
                MessageBox.Show("Select the salle that you want to delete !!");

            }
            if (success)
            {
                MessageBox.Show("Salle deleted successfully");
                ShowDataOnGridView(); // refresh grid view
            }
            else
            {
                MessageBox.Show("Salle could not be deleted ");
            }
        
    }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
