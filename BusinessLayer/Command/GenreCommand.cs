using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Command
{
    public class GenreCommand
    {
        private readonly Context _context;

        public GenreCommand(Context context)
        {
            this._context = context;
        }

        /// <summary>
        /// Ajoute un genre dans la base de données
        /// </summary>
        public int Ajouter(Genre g)
        {
            _context.Genres.Add(g);
            return _context.SaveChanges();
        }

        /// <summary>
        /// Modifie un genre de la base de données
        /// </summary>
        public void Modifier(Genre g)
        {
            Genre upGenre = _context.Genres.Where(gre => gre.Id == g.Id).FirstOrDefault();
            if (upGenre != null)
            {
                upGenre.Nom = g.Nom;
            }
            _context.SaveChanges();
        }

        /// <summary>
        /// Supprime un genre de la base de données grace à son id
        /// </summary>
        public void Supprimer(int genreID)
        {
            Genre delGenre = _context.Genres.Where(prd => prd.Id == genreID).FirstOrDefault();
            if (delGenre != null)
            {
                _context.Genres.Remove(delGenre);
            }
            _context.SaveChanges();
        }
    }
}
