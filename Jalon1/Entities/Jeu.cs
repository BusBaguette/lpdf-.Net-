using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Jeu
    {
        public int Id { get; set; }
        public String Nom { get; set; }
        public String Description { get; set; }
        public String Datedesortie { get; set; }

        public int IdEditeur { get; set; }
        public Editeur Editeur { get; set; }
        public int IdGenre { get; set; }
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
