using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class EvaluationViewModel
    {
        public int Id { get; set; }
        public String NomEvaluateur { get; set; }
        public DateTime Date { get; set; }
        public int Note { get; set; }
        public int IdJeu { get; set; }
        public Jeu Jeu { get; set; }


        public EvaluationViewModel(Evaluation evaluation)
        {
            Id = evaluation.Id;
            NomEvaluateur = evaluation.NomEvaluateur;
            Date = evaluation.Date;
            Note = evaluation.Note;
            IdJeu = evaluation.IdJeu;
        }

        public EvaluationViewModel()
        {
        }
    }
}