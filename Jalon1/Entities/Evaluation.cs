using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }
        public String NomEvaluateur { get; set; }
        public DateTime Date { get; set; }
        public int Note { get; set; }
        public int IdJeu { get; set; }
        public Jeu Jeu { get; set; }

        public Evaluation(string nomEvaluateur, DateTime date, int note, Jeu jeu)
        {
            NomEvaluateur = nomEvaluateur;
            Date = date;
            Note = note;
            this.Jeu = jeu;
        }

        public Evaluation(string nomEvaluateur, DateTime date, int note, int idJeu)
        {
            NomEvaluateur = nomEvaluateur;
            Date = date;
            Note = note;
            IdJeu = idJeu;
        }

        public Evaluation()
        {
        }
    }
}
