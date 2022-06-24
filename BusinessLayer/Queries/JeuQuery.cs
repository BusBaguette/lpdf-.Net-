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

        public IQueryable<Jeu> GetAll()
        {
            return _context.Jeux.OrderBy(j => j.Nom);
        }

        public IQueryable<Jeu> GetAllByGenre(int genreId)
        {
            return _context.Jeux.Where(j => j.IdGenre == genreId);
        }

        public IQueryable<Jeu> GetAllByEditeur(int editeurId)
        {
            return _context.Jeux.Where(j => j.IdEditeur == editeurId);
        }

        public IQueryable<Jeu> GetByID(int id)
        {
            return _context.Jeux.Where(j => j.Id == id);
        }

        //Get last 5 Jeu sorted by date
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
