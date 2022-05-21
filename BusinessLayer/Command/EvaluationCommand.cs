using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Command
{
    public class EvaluationCommand
    {
        private readonly Context _context;

        public EvaluationCommand(Context context)
        {
            this._context = context;
        }

        public int Ajouter(Evaluation e)
        {
            _context.Evaluations.Add(e);
            return _context.SaveChanges();
        }

        public void Modifier(Evaluation e)
        {
            Evaluation upEval = _context.Evaluations.Where(eval => eval.Id == e.Id).FirstOrDefault();
            if (upEval != null)
            {
                upEval.NomEvaluateur = e.NomEvaluateur;
                upEval.Date = e.Date;
                upEval.Note = e.Note;
                upEval.IdJeu = e.IdJeu;


            }
            _context.SaveChanges();
        }

        public void Supprimer(int evaluationID)
        {
            Evaluation delEval = _context.Evaluations.Where(eval => eval.Id == evaluationID).FirstOrDefault();
            if (delEval  != null)
            {
                _context.Evaluations.Remove(delEval);
            }
            _context.SaveChanges();
        }
    }
}
