using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
 
    public class Salle
    {
        int idSalle;
        int num;
        string block;
    
        public Salle() { }
    public Salle(int idSalle, int num, string block)
        {
            this.idSalle = idSalle;
            this.num = num;
            this.block = block;
        }

        public int IdSalle { get => idSalle; set => idSalle = value; }
        public int Num { get => num; set => num = value; }
        public string Block { get => block; set => block = value; }
    }
}
