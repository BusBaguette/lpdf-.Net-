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
        [HttpGet]
        public ActionResult EvaluationsGame(int id)
        {
            List<EvaluationViewModel> evaluations = Manager.Instance.GetEvaluationByIdJeu(id).Select(eval => new EvaluationViewModel(eval)).ToList();
            JeuViewModel jeuViewModel = new JeuViewModel();
            jeuViewModel.Id = id;
            jeuViewModel.Evaluations = evaluations;
            return PartialView("Evaluation", jeuViewModel);
        }

        [HttpGet]
        public ActionResult AddEvaluationGame(int id)
        {
            EvaluationViewModel evaluation = new EvaluationViewModel();
            evaluation.IdJeu = id;
            return PartialView("AddEvaluation", evaluation);
        }

        [HttpPost]
        public ActionResult AddEvaluationGame(EvaluationViewModel evaluationViewModel)
        {
            Manager.Instance.AjouterEvaluation(new Evaluation(evaluationViewModel.NomEvaluateur, evaluationViewModel.Date, evaluationViewModel.Note, evaluationViewModel.IdJeu));
            return Redirect("Jeux");
        }
    }
}