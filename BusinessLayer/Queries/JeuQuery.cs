using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class JeuQuery
    {
        private readonly Context _context;

        public JeuQuery(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Récupère tous les jeux en BD triés par leur nom par ordre alphabétique
        /// </summary>
        public IQueryable<Jeu> GetAll()
        {
            return _context.Jeux.OrderBy(j => j.Nom);
        }

        /// <summary>
        /// Récupère tous les jeux par un id de genre en BD
        /// </summary>
        public IQueryable<Jeu> GetAllByGenre(int genreId)
        {
            return _context.Jeux.Where(j => j.IdGenre == genreId);
        }

        /// <summary>
        /// Récupère tous les jeux par un id d'éditeur en BD
        /// </summary>
        public IQueryable<Jeu> GetAllByEditeur(int editeurId)
        {
            return _context.Jeux.Where(j => j.IdEditeur == editeurId);
        }

        /// <summary>
        /// Récupère un jeu par son id en BD
        /// </summary>
        public IQueryable<Jeu> GetByID(int id)
        {
            return _context.Jeux.Where(j => j.Id == id);
        }

        /// <summary>
        /// Récupère les 5 jeux qui ont la plus haute moyenne de note de commentaire
        /// </summary>
        public IQueryable<Jeu> GetLastBestJeu()
        {
            var top5jeux = _context.Evaluations.GroupBy(e => e.IdJeu)
            .Select(g => new
                {
                    IdJeu = g.Key,
                    Moyenne = g.Average(e => e.Note)
                })
            .OrderByDescending(g => g.Moyenne)
            .Take(5);


            var jeux = _context.Jeux
            .Where(j => top5jeux.Any(t => t.IdJeu == j.Id))
            .Select(j => new {
                Moyenne = top5jeux.Where(t => t.IdJeu == j.Id).FirstOrDefault().Moyenne,
                Jeu = j
            })
            .OrderByDescending(j => j.Moyenne)
            .Select(j => j.Jeu);

            return jeux;
        }
    }
}
