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

        public int AjouterJeu(Jeu j)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            JeuCommand jc = new JeuCommand(context);
            return jc.Ajouter(j);
        }

        public void ModifierJeu(Jeu j)
        {
            // TODO : ajouter des contrôles sur le produit (exemple : vérification de champ, etc.)
            JeuCommand jc = new JeuCommand(context);
            jc.Modifier(j);
        }

        public void SupprimerJeu(int jeuID)
        {
            JeuCommand jc = new JeuCommand(context);
            jc.Supprimer(jeuID);
        }

        #endregion
    }
}
