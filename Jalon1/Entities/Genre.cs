using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public String Nom { get; set; }

        public Genre(string nom)
        {
            this.Nom = nom;
        }
        public Genre()
        {
        }
    }
}
