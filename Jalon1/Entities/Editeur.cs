using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1
{
    public class Editeur
    {
        public int Id { get; set; }
        public String Nom { get; set; }

        public Editeur()
        {
        }

        public Editeur(string nom)
        {
            Nom = nom;
        }
    }
}
