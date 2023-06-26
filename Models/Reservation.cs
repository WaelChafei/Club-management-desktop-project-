using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Reservation
    {
        int idReservation;
        DateTime date_reservation;
        int nb_heurs;
        int idClub;
        int idSalle;
        public Reservation()
        {

        }
        public Reservation(int idReservation, int idClub, int idSalle, DateTime date_reservation, int nb_heurs)
        {
            this.idReservation = idReservation;
            this.date_reservation = date_reservation;
            this.nb_heurs = nb_heurs;
            this.idClub = idClub;
            this.idSalle = idSalle;
        }

        public int Id_reservation { get => idReservation; set => idReservation = value; }
        public DateTime Date_reservation { get => date_reservation; set => date_reservation = value; }
        public int Nb_heurs { get => nb_heurs; set => nb_heurs = value; }
        public int IdClub { get => idClub; set => idClub = value; }
        public int IdSalle { get => idSalle; set => idSalle = value; }
    }

}
