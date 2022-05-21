using BusinessLayer;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWpf.ViewModels
{
    public class ListJeuViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailJeuViewModel> _jeux = null;
        private DetailJeuViewModel _selectedJeu;

        #endregion

        #region Constructeurs
        public ListJeuViewModel()
        {
            // on appelle le mock pour initialiser une liste de produits
            _jeux = new ObservableCollection<DetailJeuViewModel>();
            foreach (Jeu j in Manager.Instance.GetAllJeu())
            {
                _jeux.Add(new DetailJeuViewModel(j));
            }

            if (_jeux != null && _jeux.Count > 0)
                _selectedJeu = _jeux.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailJeuViewModel> Jeu
        {
            get { return _jeux; }
            set
            {
                _jeux = value;
                OnPropertyChanged("Jeux");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public DetailJeuViewModel SelectedJeu
        {
            get { return _selectedJeu; }
            set
            {
                _selectedJeu = value;
                OnPropertyChanged("SelectedJeu");
            }
        }


        #endregion
    }
}
