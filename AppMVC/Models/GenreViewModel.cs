using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMVC.Models
{
    public class GenreViewModel
    {
        public int Id { get; set; }
        public String Nom { get; set; }

        public GenreViewModel(Genre g)
        {
            Id = g.Id;
            Nom = g.Nom;
        }
    }
}