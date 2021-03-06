using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWpf.ViewModels
{
    public class GenreViewModel
    {
        #region Variables

        private int _idGenre;
        private string _nom;

        #endregion

        #region Constructeurs


        public GenreViewModel(Genre g)
        {
            _nom = g.Nom;
            _idGenre = g.Id;
        }

        #endregion

        #region Data Bindings
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public int IdGenre
        {
            get { return _idGenre; }
        }

        #endregion
    }
}
