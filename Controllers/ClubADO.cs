using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Controllers
{
    public class ClubADO
    {
        public bool ajouter_club(String name, String mail, String description, int idPresident) {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
                
            string query = "INSERT INTO Club (name, mail, description,idPresident) VALUES (@name, @mail, @description,@idPresident)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@idPresident", idPresident);
            // Execute request
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                return true;
            else
                return false;

        }
        public bool delete_club(int id) {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "Delete from Club where id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
                return true;
            else
                return false;
        }
        public bool update_club(String name, String mail, String description, int idPresident,int id) {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "Update Club SET name = @name ,mail = @mail,description = @description," +
                "idPresident = @idPresident Where id=@id";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@idPresident", idPresident);
            command.Parameters.AddWithValue("@id", id);

            // command.Parameters.AddWithValue("@id", etudiant.);

            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
                return true;
            else
                return false;

        }
        public List<Club> allClub() {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "select * from Club";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            // read data from the reader and insert it in datasource 
            List<Club> clubs = new List<Club>();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string mail = reader["mail"].ToString();
                string description = reader["description"].ToString();
                int idPresident = int.Parse(reader["idPresident"].ToString());



                Club clubObject = new Club(id, name, mail, description, idPresident);
                clubs.Add(clubObject);

            }
            reader.Close();
            conn.Close();
            return clubs;

        }

    }
}
