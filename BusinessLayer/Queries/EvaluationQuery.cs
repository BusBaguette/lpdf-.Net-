using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class EvaluationQuery
    {
        private readonly Context _context;

        public EvaluationQuery(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Récupère toutes les évaluations en BD
        /// </summary>
        public IQueryable<Evaluation> GetAll()
        {
            return _context.Evaluations;
        }

        /// <summary>
        /// Récupère une évaluation par son id
        /// </summary>
        public IQueryable<Evaluation> GetByID(int id)
        {
            return _context.Evaluations.Where(e => e.Id == id);
        }

        /// <summary>
        /// Récupère toutes les évalutions par un id de jeu
        /// </summary>
        public IQueryable<Evaluation> GetByIdJeu(int idJeu)
        {
            return _context.Evaluations.Where(e => e.IdJeu == idJeu);
        }

        /// <summary>
        /// Récupère les 5 dernières évaluations enregistrées
        /// </summary>
        public IQueryable<Evaluation> GetLastEval()
        {
            return _context.Evaluations.OrderByDescending(e => e.Date).Take(5);
        }
    }
}
