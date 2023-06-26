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
    public partial class FormLogin : Form
    {
    
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
        public static int UserID;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txtUsername.Text;
            user_password=txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM Users WHERE mail = '" + txtUsername.Text + "'AND password='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    user_password = txtPassword.Text;
                    UserID = (int)dtable.Rows[0]["id"];
                    String querryUser = "SELECT * FROM Users WHERE role = 'user' and mail = '" + txtUsername.Text + "'";
                    String querryAdmin = "SELECT * FROM Users WHERE role = 'admin' and mail = '" + txtUsername.Text + "'";
                    SqlDataAdapter sdaUser = new SqlDataAdapter(querryUser, conn);
                    DataTable dtableUser = new DataTable();
                    sdaUser.Fill(dtableUser);

                    SqlDataAdapter sdaAdmin = new SqlDataAdapter(querryAdmin, conn);
                    DataTable dtableAdmin = new DataTable();
                    sdaAdmin.Fill(dtableAdmin);
                    //page that needed to be load next
                    if (dtableUser.Rows.Count > 0)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                        this.Hide();
                    }
                    else
                    {
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.Show();
                        this.Hide();
                    }
                  
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                conn.Close();
            }






        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

   
        private void FormLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
