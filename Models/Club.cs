using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Club
    {
        int idClub;
        string name;
        string mail;
        string description;
        int idPresident;
        public Club()
        {

        }
        public Club(int idClub, string name, string mail, string description, int idPresident)
        {
            this.idClub = idClub;
            this.name = name;
            this.mail = mail;
            this.description = description;
            this.idPresident = idPresident;
        }

        public int Id_club { get => idClub; set => idClub = value; }
        public string Name { get => name; set => name = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Description { get => description; set => description = value; }
        public int IdPresident { get => idPresident; set => idPresident = value; }
    }
}
