using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class User
    {
        int idUser;
        string name;
        string role;
        string mail;
        string password;
        int tel;
       public User() { }
        public User(int idUser, string name, string role, string mail, string password, int tel)
        {
            this.idUser = idUser;
            this.name = name;
            this.role = role;
            this.mail = mail;
            this.password = password;
            this.tel = tel;
        }

        public int Id_user { get => idUser; set => idUser = value; }
        public string Name { get => name; set => name = value; }
        public string Role { get => role; set => role = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public int Tel { get => tel; set => tel = value; }
    }
}
