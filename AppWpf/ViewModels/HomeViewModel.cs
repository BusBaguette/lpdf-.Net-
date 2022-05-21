using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWpf.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Variables

        private ListJeuViewModel _listeJeuViewModel = null;

        #endregion

        #region Constructeurs

        public HomeViewModel()
        {
            _listeJeuViewModel = new ListJeuViewModel();
        }

        #endregion

        #region Data Bindings

        public ListJeuViewModel ListJeuViewModel
        {
            get { return _listeJeuViewModel; }
            set { _listeJeuViewModel = value; }
        }

        #endregion
    }
}
