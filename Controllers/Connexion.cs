using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace Controllers
{
    public class Connexion
    {
        SqlConnection con;
        public void OpenConection()
        {
            con = new SqlConnection("database=ClubprojBD;server=DESKTOP-KIMMDIF;User ID=sa;pwd=23110069");
            con.Open();
        }

        public Boolean ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            if (cmd.ExecuteNonQuery() >= 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

    }
}