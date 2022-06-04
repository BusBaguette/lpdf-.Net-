using BusinessLayer.Command;
using BusinessLayer.Queries;
using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Manager
    {
        private readonly Context context;
        private static Manager _manager = null;

        public Manager()
        {
            context = new Context();
        }

        public static Manager Instance
        {
            get
            {
                if (_manager == null)
                    _manager = new Manager();
                return _manager;
            }
        }

        #region Editeur

        public List<Editeur> GetAllEditeur()
        {
            EditeurQuery pq = new EditeurQuery(context);
            return pq.GetAll().ToList();
        }

        public Editeur GetEditeurById(int id)
        {
            EditeurQuery pq = new EditeurQuery(context);
            return pq.GetByID(id).ToList().First();
        }

        public int AjouterEditeur(Editeur e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            EditeurCommand ec = new EditeurCommand(context);
            return ec.Ajouter(e);
        }

        public void ModifierEditeur(Editeur e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            EditeurCommand ec = new EditeurCommand(context);
            ec.Modifier(e);
        }

        public void SupprimerEditeur(int editeurID)
        {
            EditeurCommand ec = new EditeurCommand(context);
            ec.Supprimer(editeurID);
        }

        #endregion

        #region Jeu

        public List<Jeu> GetAllJeu()
        {
            JeuQuery jq = new JeuQuery(context);
            return jq.GetAll().ToList();
        }

        public Jeu GetJeuById(int id)
        {
            JeuQuery pq = new JeuQuery(context);
            return pq.GetByID(id).ToList().First();
        }

        public List<Jeu> GetAllJeuByGenre(int genreId)
        {
            JeuQuery jq = new JeuQuery(context);
            return jq.GetAllByGenre(genreId).ToList();
        }

        public List<Jeu> GetAllJeuByEditeur(int editeurId)
        {
            JeuQuery jq = new JeuQuery(context);
            return jq.GetAllByEditeur(editeurId).ToList();
        }

        public int AjouterJeu(Jeu j)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            JeuCommand jc = new JeuCommand(context);
            return jc.Ajouter(j);
        }

        public void ModifierJeu(Jeu j)
        {
            JeuCommand jc = new JeuCommand(context);
            jc.Modifier(j);
        }

        public void SupprimerJeu(int jeuID)
        {
            JeuCommand jc = new JeuCommand(context);
            jc.Supprimer(jeuID);
        }

        #endregion

        #region Genre

        public List<Genre> GetAllGenre()
        {
            GenreQuery gq = new GenreQuery(context);
            return gq.GetAll().ToList();
        }

        public Genre GetGenreById(int id)
        {
            GenreQuery pq = new GenreQuery(context);
            return pq.GetByID(id).ToList().First();
        }

        public int AjouterGenre(Genre g)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            GenreCommand gc = new GenreCommand(context);
            return gc.Ajouter(g);
        }

        public void ModifierGenre(Genre g)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            GenreCommand gc = new GenreCommand(context);
            gc.Modifier(g);
        }

        public void SupprimerGenre(int genreID)
        {
            GenreCommand gc = new GenreCommand(context);
            gc.Supprimer(genreID);
        }

        #endregion

        #region Evaluation

        public List<Evaluation> GetAllEvaluation()
        {
            EvaluationQuery eq = new EvaluationQuery(context);
            return eq.GetAll().ToList();
        }

        public int AjouterEvaluation(Evaluation e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            EvaluationCommand ec = new EvaluationCommand(context);
            return ec.Ajouter(e);
        }

        public void ModifierEvaluation(Evaluation e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            EvaluationCommand ec = new EvaluationCommand(context);
            ec.Modifier(e);
        }

        public void SupprimerEvaluation(int evaluationID)
        {
            EvaluationCommand ec = new EvaluationCommand(context);
            ec.Supprimer(evaluationID);
        }

        #endregion

        #region Experience

        public List<Experience> GetAllExperience()
        {
            ExperienceQuery eq = new ExperienceQuery(context);
            return eq.GetAll().ToList();
        }

        public int AjouterExperience(Experience e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ExperienceCommand ec = new ExperienceCommand(context);
            return ec.Ajouter(e);
        }

        public void ModifierExperience(Experience e)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            ExperienceCommand ec = new ExperienceCommand(context);
            ec.Modifier(e);
        }

        public void SupprimerExperience(int experienceID)
        {
            ExperienceCommand ec = new ExperienceCommand(context);
            ec.Supprimer(experienceID);
        }

        #endregion
    }
}
