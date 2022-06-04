using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppWpf.ViewModels
{
    public class EditeurViewModel : BaseViewModel
    {
        #region Variables

        private string _nom;
        private int _idEditeur;
        //private RelayCommand _addOperation;

        #endregion

        #region Constructeurs

        public EditeurViewModel(Editeur e)
        {
            _nom = e.Nom;
            _idEditeur = e.Id;
        }

        #endregion

        #region Data Bindings
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public int IdEditeur
        {
            get { return _idEditeur; }
        }

        #endregion

        #region Commandes

        ///// <summary>
        ///// Commande pour ouvrir la fenêtre pour ajouter une opération
        ///// </summary>
        //public ICommand AddOperation
        //{
        //    get
        //    {
        //        if (_addOperation == null)
        //            _addOperation = new RelayCommand(() => this.ShowWindowOperation());
        //        return _addOperation;
        //    }
        //}

        ///// <summary>
        ///// Permet l'ouverture de la fenêtre
        ///// </summary>
        //private void ShowWindowOperation()
        //{
        //    Views.Operation operationWindow = new Views.Operation();
        //    operationWindow.DataContext = this;
        //    operationWindow.ShowDialog();
        //}

        #endregion
    }
}
