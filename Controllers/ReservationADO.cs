using Models;
using System.Data.SqlClient;

namespace Controllers
{
    public class ReservationADO
    {
        public bool ajouter_reservation(int idClub, int idSalle, DateTime date_reservation, int nb_heurs)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");

            string query = "INSERT INTO Reservation (idClub, idSalle, date_reservation,nb_heurs) VALUES (@idClub, @idSalle, @date_reservation,@nb_heurs)";
            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();

            command.Parameters.AddWithValue("@idClub", idClub);
            command.Parameters.AddWithValue("@idSalle", idSalle);
            command.Parameters.AddWithValue("@date_reservation", date_reservation);
            command.Parameters.AddWithValue("@nb_heurs", nb_heurs);
            // Execute request
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
                return true;
            else
                return false;

        }
        public bool delete_reservation(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "Delete from Reservation where id = @id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@id", id);
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
                return true;
            else
                return false;
        }
        public bool update_reservation(int idClub, int idSalle, DateTime date_reservation, int nb_heurs,int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "Update Reservation SET idClub = @idClub ,idSalle = @idSalle,date_reservation = @date_reservation," +
                "nb_heurs = @nb_heurs Where id=@id";
            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@idClub", idClub);
            command.Parameters.AddWithValue("@idSalle", idSalle);
            command.Parameters.AddWithValue("@date_reservation", date_reservation);
            command.Parameters.AddWithValue("@nb_heurs", nb_heurs);
            command.Parameters.AddWithValue("@id", id);

            // command.Parameters.AddWithValue("@id", etudiant.);

            int rowAffected = command.ExecuteNonQuery();
            conn.Close();
            if (rowAffected > 0)
                return true;
            else
                return false;

        }
        public List<Reservation> allReservation()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-KIMMDIF;Initial Catalog=ClubprojBD;Integrated Security=True");
            conn.Open();
            string query = "select * from Reservation";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            // read data from the reader and insert it in datasource 
            List<Reservation> reservations = new List<Reservation>();
            while (reader.Read())
            {
                int id = int.Parse(reader["id"].ToString());
                int idClub = int.Parse(reader["idClub"].ToString());
                int idSalle = int.Parse(reader["idSalle"].ToString());
                DateTime date_reservation = DateTime.Parse(reader["date_reservation"].ToString());
                int nb_heurs = int.Parse(reader["nb_heurs"].ToString());



                Reservation ReservationObject = new Reservation(id, idClub, idSalle, date_reservation, nb_heurs);
                reservations.Add(ReservationObject);

            }
            reader.Close();
            conn.Close();
            return reservations;

        }


    }
}