using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Jeu
    {
         /// <summary>
        /// Identifiant du jeu
        /// Il est unique et est auto-incrémenté
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom du jeu
        /// </summary>
        public String Nom { get; set; }

        /// <summary>
        /// Description du jeu
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Date de sortie du jeu
        /// </summary>
        public String Datedesortie { get; set; }

        /// <summary>
        /// Identifiant de l'éditeur du jeu
        /// Il est unique et est auto-incrémenté
        /// </summary>
        public int IdEditeur { get; set; }

        /// <summary>
        /// Editeur du jeu
        /// Le framework va automatiquement charger cet objet
        /// </summary>
        public Editeur Editeur { get; set; }

        /// <summary>
        /// Identifiant du genre du jeu
        /// Il est unique et est auto-incrémenté
        /// </summary>
        public int IdGenre { get; set; }

        /// <summary>
        /// Genre du jeu
        /// Le framework va automatiquement charger cet objet
        public Genre Genre { get; set; }

        public Jeu(string nom, string description, String datedesortie, Editeur editeur, Genre genre)
        {
            Nom = nom;
            Description = description;
            Datedesortie = datedesortie;
            Editeur = editeur;
            Genre = genre;
        }

        public Jeu(string nom, string description, string datedesortie, int idEditeur, int idGenre)
        {
            Nom = nom;
            Description = description;
            Datedesortie = datedesortie;
            IdEditeur = idEditeur;
            IdGenre = idGenre;
        }

        public Jeu(int id, string nom, string description, string datedesortie, int idEditeur, int idGenre)
        {
            Id = id;
            Nom = nom;
            Description = description;
            Datedesortie = datedesortie;
            IdEditeur = idEditeur;
            IdGenre = idGenre;
        }

        public Jeu()
        {
        }
    }
}
