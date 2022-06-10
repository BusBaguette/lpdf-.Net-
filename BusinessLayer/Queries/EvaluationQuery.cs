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

        public IQueryable<Evaluation> GetAll()
        {
            return _context.Evaluations;
        }

        public IQueryable<Evaluation> GetByID(int id)
        {
            return _context.Evaluations.Where(e => e.Id == id);
        }

        public IQueryable<Evaluation> GetByIdJeu(int idJeu)
        {
            return _context.Evaluations.Where(e => e.IdJeu == idJeu);
        }
    }
}
