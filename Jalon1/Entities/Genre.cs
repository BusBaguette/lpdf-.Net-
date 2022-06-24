using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Genre
    {
        /// <summary>
        /// Identifiant de l'expérience
        /// Il est unique et est auto-incrémenté
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom du genre
        /// </summary>
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
