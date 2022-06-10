using AppWpf.ViewModels.Common;
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
    public class ListJeuViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailJeuViewModel> _jeux = null;
        private DetailJeuViewModel _selectedJeu;
        private ObservableCollection<EditeurViewModel> _editeurs = null;
        private EditeurViewModel _selectedEditeur;
        private ObservableCollection<GenreViewModel> _genres = null;
        private GenreViewModel _selectedGenre;
        private RelayCommand _resetList;

        #endregion

        #region Constructeurs
        public ListJeuViewModel()
        {
            _jeux = new ObservableCollection<DetailJeuViewModel>();
            foreach (Jeu j in Manager.Instance.GetAllJeu())
            {
                _jeux.Add(new DetailJeuViewModel(j));
            }

            _genres = new ObservableCollection<GenreViewModel>();
            foreach (Genre g in Manager.Instance.GetAllGenre())
            {
                _genres.Add(new GenreViewModel(g));
            }

            _editeurs = new ObservableCollection<EditeurViewModel>();
            foreach (Editeur e in Manager.Instance.GetAllEditeur())
            {
                _editeurs.Add(new EditeurViewModel(e));
            }

            if (_jeux != null && _jeux.Count > 0)
                _selectedJeu = _jeux.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        public ObservableCollection<DetailJeuViewModel> Jeu
        {
            get { return _jeux; }
            set
            {
                _jeux = value;
                OnPropertyChanged("Jeu");
            }
        }

        public DetailJeuViewModel SelectedJeu
        {
            get { return _selectedJeu; }
            set
            {
                _selectedJeu = value;
                OnPropertyChanged("SelectedJeu");
            }
        }

        public ObservableCollection<GenreViewModel> Genres
        {
            get { return _genres; }
            set
            {
                _genres = value;
                OnPropertyChanged("Genres");
            }
        }

        public GenreViewModel SelectedGenre
        {
            get { return _selectedGenre; }
            set
            {
                _selectedGenre = value;
                _jeux.Clear();
                foreach (Jeu j in Manager.Instance.GetAllJeuByGenre(_selectedGenre.IdGenre))
                {
                    _jeux.Add(new DetailJeuViewModel(j));
                }
                if (_jeux != null && _jeux.Count > 0)
                    _selectedJeu = _jeux.ElementAt(0);
            }
        }

        public ObservableCollection<EditeurViewModel> Editeurs
        {
            get { return _editeurs; }
            set
            {
                _editeurs = value;
                OnPropertyChanged("Editeurs");
            }
        }

        public EditeurViewModel SelectedEditeur
        {
            get { return _selectedEditeur; }
            set
            {
                _selectedEditeur = value;
                _jeux.Clear();
                foreach (Jeu j in Manager.Instance.GetAllJeuByEditeur(_selectedEditeur.IdEditeur))
                {
                    _jeux.Add(new DetailJeuViewModel(j));
                }
                if (_jeux != null && _jeux.Count > 0)
                    _selectedJeu = _jeux.ElementAt(0);
            }
        }

        #endregion


        #region Commandes
        public ICommand ResetOperation
        {
            get
            {
                if (_resetList == null)
                    _resetList = new RelayCommand(() => this.ResetList());
                return _resetList;
            }
        }

        private void ResetList()
        {
            _jeux.Clear();
            foreach (Jeu j in Manager.Instance.GetAllJeu())
            {
                _jeux.Add(new DetailJeuViewModel(j));
            }
            if (_jeux != null && _jeux.Count > 0)
                _selectedJeu = _jeux.ElementAt(0);
        }

        #endregion
    }
}
