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

        private Manager()
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
            try {
                EditeurQuery editeurQuery = new EditeurQuery(context);
                return editeurQuery.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Editeur GetEditeurById(int id)
        {
            try {
                EditeurQuery editeurQuery = new EditeurQuery(context);
                return editeurQuery.GetByID(id).First();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int AjouterEditeur(Editeur e) 
        {
            try
            {
                EditeurCommand ec = new EditeurCommand(context);
                return ec.Ajouter(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public void ModifierEditeur(Editeur e)
        {
            try
            {
                EditeurCommand ec = new EditeurCommand(context);
                ec.Modifier(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SupprimerEditeur(int editeurID)
        {
            try
            {
                EditeurCommand ec = new EditeurCommand(context);
                ec.Supprimer(editeurID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Jeu

        public List<Jeu> GetAllJeu()
        {
            try {
                JeuQuery jeuQuery = new JeuQuery(context);
                return jeuQuery.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Jeu GetJeuById(int id)
        {
            try {
                JeuQuery jeuQuery = new JeuQuery(context);
                return jeuQuery.GetByID(id).ToList().First();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Jeu> GetAllJeuByGenre(int genreId)
        {
            try {
                JeuQuery jeuQuery = new JeuQuery(context);
                return jeuQuery.GetAllByGenre(genreId).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Jeu> GetAllJeuByEditeur(int editeurId)
        {
            try {
                JeuQuery jeuQuery = new JeuQuery(context);
                return jeuQuery.GetAllByEditeur(editeurId).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Jeu> GetLastBestJeu()
        {
            try {
                JeuQuery jeuQuery = new JeuQuery(context);
                return jeuQuery.GetLastBestJeu().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int AjouterJeu(Jeu j)
        {
            try
            {
                JeuCommand jc = new JeuCommand(context);
                return jc.Ajouter(j);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
        }

        public void ModifierJeu(Jeu j)
        {
            try
            {
                JeuCommand jc = new JeuCommand(context);
                jc.Modifier(j);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SupprimerJeu(int jeuID)
        {
            try
            {
                JeuCommand jc = new JeuCommand(context);
                jc.Supprimer(jeuID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Genre

        public List<Genre> GetAllGenre()
        {
            try {
                GenreQuery genreQuery = new GenreQuery(context);
                return genreQuery.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Genre GetGenreById(int id)
        {
            try {
                GenreQuery genreQuery = new GenreQuery(context);
                return genreQuery.GetByID(id).ToList().First();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int AjouterGenre(Genre g)
        {
            try
            {
                GenreCommand gc = new GenreCommand(context);
                return gc.Ajouter(g);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModifierGenre(Genre g)
        {
            try
            {
                GenreCommand gc = new GenreCommand(context);
                gc.Modifier(g);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void SupprimerGenre(int genreID)
        {
            try
            {
                GenreCommand gc = new GenreCommand(context);
                gc.Supprimer(genreID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Evaluation

        public List<Evaluation> GetAllEvaluation()
        {
            try {
                EvaluationQuery evaluationQuery = new EvaluationQuery(context);
                return evaluationQuery.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Evaluation> GetEvaluationByIdJeu(int idJeu)
        {
            try {
                EvaluationQuery evaluationQuery = new EvaluationQuery(context);
                return evaluationQuery.GetByIdJeu(idJeu).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Evaluation> GetLastEval()
        {
            try {
                EvaluationQuery evaluationQuery = new EvaluationQuery(context);
                return evaluationQuery.GetLastEval().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int AjouterEvaluation(Evaluation e)
        {
            try
            {
                EvaluationCommand ec = new EvaluationCommand(context);
                return ec.Ajouter(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
        }

        public void ModifierEvaluation(Evaluation e)
        {
            try
            {
                EvaluationCommand ec = new EvaluationCommand(context);
                ec.Modifier(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
        }

        public void SupprimerEvaluation(int evaluationID)
        {
            try
            {
                EvaluationCommand ec = new EvaluationCommand(context);
                ec.Supprimer(evaluationID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Experience

        public List<Experience> GetAllExperience()
        {
            try {
                ExperienceQuery experienceQuery = new ExperienceQuery(context);
                return experienceQuery.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int AjouterExperience(Experience e)
        {
            try
            {
                ExperienceCommand ec = new ExperienceCommand(context);
                return ec.Ajouter(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
        }

        public void ModifierExperience(Experience e)
        {
            try
            {
                ExperienceCommand ec = new ExperienceCommand(context);
                ec.Modifier(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
        }

        public void SupprimerExperience(int experienceID)
        {
            try
            {
                ExperienceCommand ec = new ExperienceCommand(context);
                ec.Supprimer(experienceID);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion
    }
}
