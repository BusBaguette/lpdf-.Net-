using Jalon1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class EditeurViewModel
    {
        public int Id { get; set; }
        public String Nom { get; set; }

        public EditeurViewModel(Editeur e)
        {
            Id = e.Id;
            Nom = e.Nom;
        }
    }
}