using AppMVC.Models;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<JeuViewModel> bestJeu = Manager.Instance.GetLastBestJeu().Select(jeu => new JeuViewModel(jeu)).ToList();

            List<EvaluationViewModel> bestEval = Manager.Instance.GetLastEval().Select(eval => new EvaluationViewModel(eval)).ToList();


            ViewBag.BestJeu = bestJeu;
            ViewBag.BestEval = bestEval;

            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}