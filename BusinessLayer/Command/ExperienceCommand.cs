﻿using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Command
{
    public class ExperienceCommand
    {
        private readonly Context _context;

        public ExperienceCommand(Context context)
        {
            this._context = context;
        }

        public int Ajouter(Experience e)
        {
            _context.Experiences.Add(e);
            return _context.SaveChanges();
        }

        public void Modifier(Experience e)
        {
            Experience upExp = _context.Experiences.Where(exp => exp.Id == e.Id).FirstOrDefault();
            if (upExp != null)
            {

                upExp.XpJoueur = e.XpJoueur;
                upExp.TempsJeu = e.TempsJeu;
                upExp.Pourcentage = e.Pourcentage;
                upExp.IdJeu = e.IdJeu;


            }
            _context.SaveChanges();
        }

        public void Supprimer(int experienceID)
        {
            Experience delExp = _context.Experiences.Where(exp => exp.Id == experienceID).FirstOrDefault();
            if (delExp != null)
            {
                _context.Experiences.Remove(delExp);
            }
            _context.SaveChanges();
        }
    }
}
