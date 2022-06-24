using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class JeuViewModel
    {
        #region Variables

        public int Id { get; set; }
        public String Nom { get; set; }
        public String Description { get; set; }
        public String Datedesortie { get; set; }

        public int IdEditeur { get; set; }
        public int IdGenre { get; set; }

        public EditeurViewModel Editeur { get; set; }
        public GenreViewModel Genre { get; set; }
        public List<EvaluationViewModel> Evaluations { get; set; }




        #endregion

        #region Constructeurs
        public JeuViewModel(Jeu j)
        {
            Datedesortie = j.Datedesortie;
            Description = j.Description;
            IdEditeur = j.IdEditeur;
            IdGenre = j.IdGenre;
            Nom = j.Nom;
            Id = j.Id;
        }

        public JeuViewModel()
        {
        }



        #endregion


    }
}