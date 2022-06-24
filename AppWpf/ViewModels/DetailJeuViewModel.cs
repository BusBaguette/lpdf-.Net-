using BusinessLayer;
using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppWpf.ViewModels
{
    public class DetailJeuViewModel : BaseViewModel
    {
        #region Variables

        private string _datesortie;
        private string _description;
        private int _idEditeur;
        private int _idGenre;
        private string _nom;
        private Jeu _jeu;

        private string _nomEditeur;

        private string _nomGenre;

        private ObservableCollection<EvaluationViewModel> _evaluations = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// <param name="p">Produit à transformer en DetailProduitViewModel</param>
        /// </summary>
        public DetailJeuViewModel(Jeu p)
        {
            _jeu = p;
            _datesortie = p.Datedesortie;
            _description = p.Description;
            _idEditeur = p.IdEditeur;
            _idGenre = p.IdGenre;
            _nom = p.Nom;

            Editeur e = Manager.Instance.GetEditeurById(p.IdEditeur);
            _nomEditeur = e.Nom;

            Genre g = Manager.Instance.GetGenreById(p.IdGenre);
            _nomGenre = g.Nom;

            _evaluations = new ObservableCollection<EvaluationViewModel>();
            foreach (Evaluation eval in Manager.Instance.GetEvaluationByIdJeu(p.Id))
            {
                _evaluations.Add(new EvaluationViewModel(eval));
            }
        }

        #endregion

        #region Data Bindings
        public string Nom
        {
            get { return _nom; }
            set 
            {
                _nom = value;
                _jeu.Nom = _nom;
                Manager.Instance.ModifierJeu(_jeu);
                OnPropertyChanged("Jeu");
            }
        }
        public string Description
        {
            get { return _description; }
            set 
            { 
                _description = value;
                _jeu.Description = _description;
                Manager.Instance.ModifierJeu(_jeu);
            }
        }
        public int IdEditeur
        {
            get { return _idEditeur; }
            set 
            { 
                _idEditeur = value; 
            }
        }
        public int IdGenre
        {
            get { return _idGenre; }
            set 
            {
                _idGenre = value; 
            }
        }
        public string Datedesortie
        {
            get { return _datesortie; }
            set 
            { 
                _datesortie = value;
                _jeu.Datedesortie = _datesortie;
                Manager.Instance.ModifierJeu(_jeu);
                OnPropertyChanged("Jeux");
            }
        }

        public string NomEditeur
        {
            get { return _nomEditeur; }
            set 
            { 
                _nomEditeur = value; 
            }
        }

        public string NomGenre
        {
            get { return _nomGenre; }
            set 
            { 
                _nomGenre = value; 
            }
        }

        public ObservableCollection<EvaluationViewModel> Evaluations
        {
            get { return _evaluations; }
            set
            {
                _evaluations = value;
                OnPropertyChanged("Evals");
            }
        }

        #endregion
    }
}
