using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalon1.Entities
{
    public class Evaluation
    {
        /// <summary>
        /// Identifiant de l'évaluation
        /// Il est unique et est auto-incrémenté
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de l'évaluateur (ex: Jean Dupont)
        /// </summary>
        public String NomEvaluateur { get; set; }

        /// <summary>
        /// Date de l'évaluation
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Note de l'évaluation sur 20
        /// </summary>
        public int Note { get; set; }

        /// <summary>
        /// Identifiant du jeu associé à l'évaluation
        ///
        public int IdJeu { get; set; }

        /// <summary>
        /// Jeu associé à l'évaluation
        /// Le framework va automatiquement charger cet objet
        /// </summary>
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
