using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1
{
    public class Editeur
    {
        /// <summary>
        /// Id de l'éditeur
        /// Il est unique et est auto-incrémenté
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'éditeur
        /// </summary>
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
