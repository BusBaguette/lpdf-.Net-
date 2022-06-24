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
    public class JeuController : Controller
    {
        public ActionResult Index()
        {
            return View("Jeu");
        }

        /// <summary>
        /// Affiche la liste des jeux
        /// </summary>
        [HttpGet]
        public ActionResult Jeux()
        {
            List<JeuViewModel> list = Manager.Instance.GetAllJeu().Select(jeu => new JeuViewModel(jeu)).ToList();
            return View("Jeu", list);
        }

        /// <summary>
        /// Affiche les détails d'un jeu passé en paramètre
        /// </summary>
        [HttpGet]
        public ActionResult DetailJeu(int id)
        {
            JeuViewModel jeu = new JeuViewModel(Manager.Instance.GetJeuById(id));
            jeu.Editeur = new EditeurViewModel(Manager.Instance.GetEditeurById(jeu.IdEditeur));
            jeu.Genre = new GenreViewModel(Manager.Instance.GetGenreById(jeu.IdGenre));
            return View("DetailJeu", jeu);
        }

        /// <summary>
        /// Recherche un jeu par son nom passé en paramètre et l'affiche la liste des résultats
        /// </summary>
        [HttpGet]
        public ActionResult FindJeu(string nom)
        {
            List<JeuViewModel> list = Manager.Instance.GetAllJeu().Where(jeu => jeu.Nom.ToLower().Contains(nom.ToLower())).Select(jeu => new JeuViewModel(jeu)).ToList();
        
            return View("RechercheJeu", list);
        }

        /// <summary>
        /// Affiche le formulaire de création d'un jeu
        /// </summary>
        [HttpGet]
        public ActionResult AddJeu()
        {
            JeuViewModel jeu = new JeuViewModel();

            #region ViewBag
            List<EditeurViewModel> listEditeurs = Manager.Instance.GetAllEditeur().Select(e => new EditeurViewModel(e)).ToList();
            List<SelectListItem> editeursSelectedItems = new List<SelectListItem>();
            foreach (var e in listEditeurs)
            {
                editeursSelectedItems.Add(new SelectListItem
                {
                    Text = e.Nom,
                    Value = e.Id.ToString()
                });
            }

            ViewBag.Editeurs = editeursSelectedItems;

            List<GenreViewModel> listGenres = Manager.Instance.GetAllGenre().Select(e => new GenreViewModel(e)).ToList();
            List<SelectListItem> genresSelectedItems = new List<SelectListItem>();
            foreach (var g in listGenres)
            {
                genresSelectedItems.Add(new SelectListItem
                {
                    Text = g.Nom,
                    Value = g.Id.ToString()
                });
            }

            ViewBag.Genres = genresSelectedItems;
            #endregion

            return PartialView("AddJeu", jeu);
        }

        /// <summary>
        /// Enregistre un jeu dans la base de données
        /// </summary>
        [HttpPost]
        public ActionResult AddJeu(JeuViewModel jeuViewModel)
        {
            Manager.Instance.AjouterJeu(new Jeu(jeuViewModel.Nom, jeuViewModel.Description, jeuViewModel.Datedesortie, jeuViewModel.IdEditeur, jeuViewModel.IdGenre));
            return Redirect("/Jeu/Jeux/");
        }

        /// <summary>
        /// Affiche le formulaire de modification d'un jeu
        /// </summary>
        [HttpGet]
        public ActionResult EditJeu(int id)
        {
            #region ViewBag
            List<EditeurViewModel> listEditeurs = Manager.Instance.GetAllEditeur().Select(e => new EditeurViewModel(e)).ToList();
            List<SelectListItem> editeursSelectedItems = new List<SelectListItem>();
            foreach (var e in listEditeurs)
            {
                editeursSelectedItems.Add(new SelectListItem
                {
                    Text = e.Nom,
                    Value = e.Id.ToString()
                });
            }

            ViewBag.Editeurs = editeursSelectedItems;

            List<GenreViewModel> listGenres = Manager.Instance.GetAllGenre().Select(e => new GenreViewModel(e)).ToList();
            List<SelectListItem> genresSelectedItems = new List<SelectListItem>();
            foreach (var g in listGenres)
            {
                genresSelectedItems.Add(new SelectListItem
                {
                    Text = g.Nom,
                    Value = g.Id.ToString()
                });
            }

            ViewBag.Genres = genresSelectedItems;
            #endregion

            JeuViewModel jeu = new JeuViewModel(Manager.Instance.GetJeuById(id));
            jeu.Editeur = new EditeurViewModel(Manager.Instance.GetEditeurById(jeu.IdEditeur));
            jeu.Genre = new GenreViewModel(Manager.Instance.GetGenreById(jeu.IdGenre));
            return PartialView("EditJeu", jeu);
        }

        /// <summary>
        /// Enregistre les modifications d'un jeu dans la base de données
        /// </summary>
        [HttpPost]
        public ActionResult EditJeu(JeuViewModel jeuViewModel)
        {
            Manager.Instance.ModifierJeu(new Jeu(jeuViewModel.Id, jeuViewModel.Nom, jeuViewModel.Description, jeuViewModel.Datedesortie, jeuViewModel.IdEditeur, jeuViewModel.IdGenre));
            return Redirect("/Jeu/Jeux/");
        }


    }
}