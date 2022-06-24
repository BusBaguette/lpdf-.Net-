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
    }
}
