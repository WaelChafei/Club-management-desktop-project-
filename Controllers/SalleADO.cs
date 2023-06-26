using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class SalleADO
    {

        public bool ajouter_salle(int num, String block)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");

            string query = "INSERT INTO Salle (num, block) VALUES (@num, @block)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            command.Parameters.AddWithValue("@num", num);
            command.Parameters.AddWithValue("@block", block);
     
            // Execute request
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                return true;
            else
                return false;

        }
        public bool delete_salle(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "Delete from Salle where id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
                return true;
            else
                return false;
        }
        public bool update_salle(int num, String block,int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "Update Salle SET num = @num ,block = @block Where id=@id";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@num", num);
            command.Parameters.AddWithValue("@block", block);
            command.Parameters.AddWithValue("@id", id);

            // command.Parameters.AddWithValue("@id", etudiant.);

            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
                return true;
            else
                return false;

        }
        public List<Salle> allSalle()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "select * from Salle";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            // read data from the reader and insert it in datasource 
            List<Salle> salles = new List<Salle>();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                int num = int.Parse(reader["num"].ToString());
                string block= reader["block"].ToString();



                Salle salleObject = new Salle(id, num, block);
                salles.Add(salleObject);

            }
            reader.Close();
            conn.Close();
            return salles;

        }

    }
}
