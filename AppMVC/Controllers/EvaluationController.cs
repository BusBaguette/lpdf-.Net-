using AppMVC.Models;
using BusinessLayer;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC.Controllers
{
    public class EvaluationController : Controller
    {
        /// <summary>
        /// Affiche la page d'évaluation d'un jeu passé en paramètre
        /// </summary>
        [HttpGet]
        public ActionResult EvaluationsGame(int id)
        {
            List<EvaluationViewModel> evaluations = Manager.Instance.GetEvaluationByIdJeu(id).Select(eval => new EvaluationViewModel(eval)).ToList();
            JeuViewModel jeuViewModel = new JeuViewModel();
            jeuViewModel.Id = id;
            jeuViewModel.Evaluations = evaluations;
            return PartialView("Evaluation", jeuViewModel);
        }

        /// <summary>
        /// Affiche la page de création d'une évaluation pour un jeu passé en paramètre
        /// </summary>
        [HttpGet]
        public ActionResult AddEvaluationGame(int id)
        {
            EvaluationViewModel evaluation = new EvaluationViewModel();
            evaluation.IdJeu = id;
            return PartialView("AddEvaluation", evaluation);
        }

        /// <summary>
        /// Ajoute une évaluation passée en paramètre dans la base de données
        /// </summary>
        [HttpPost]
        public ActionResult AddEvaluationGame(EvaluationViewModel evaluationViewModel)
        {
            if (evaluationViewModel.Note > 20 ) {
                evaluationViewModel.Note = 20;
            }
            if (evaluationViewModel.Note < 0) {
                evaluationViewModel.Note = 0;
            }
            
            Manager.Instance.AjouterEvaluation(new Evaluation(evaluationViewModel.NomEvaluateur, DateTime.Now, evaluationViewModel.Note, evaluationViewModel.IdJeu));
            return Redirect("/Jeu/DetailJeu/" + evaluationViewModel.IdJeu);
        }
    }
}