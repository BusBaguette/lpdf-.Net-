using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppWpf.ViewModels
{
    public class EvaluationViewModel : BaseViewModel
    {
        #region Variables

        private string _nomEvaluateur;
        private DateTime _date;
        private int _note;
        #endregion

        #region Constructeurs


        public EvaluationViewModel(Evaluation e)
        {
            _nomEvaluateur = e.NomEvaluateur;
            _date = e.Date;
            _note = e.Note;
        }

        #endregion

        #region Data Bindings
        public string NomEvaluateur
        {
            get { return _nomEvaluateur; }
            set { _nomEvaluateur = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int Note
        {
            get { return _note; }
            set { _note = value; }
        }

        #endregion
    }
}
