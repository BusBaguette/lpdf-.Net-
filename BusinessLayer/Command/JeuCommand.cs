using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Command
{
    class JeuCommand
    {
        private readonly Context _context;

        public JeuCommand(Context context)
        {
            this._context = context;
        }

        public int Ajouter(Jeu j)
        {
            _context.Jeux.Add(j);
            return _context.SaveChanges();
        }

        public void Modifier(Jeu j)
        {
            Jeu upPrd = _context.Jeux.Where(prd => prd.Id == j.Id).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.IdEditeur = j.IdEditeur;
                upPrd.Datedesortie = j.Datedesortie;
                upPrd.Description = j.Description;
                upPrd.IdGenre = j.IdGenre;
                upPrd.Nom = j.Nom;
            }
            _context.SaveChanges();
        }

        public void Supprimer(int jeuID)
        {
            Jeu delPrd = _context.Jeux.Where(prd => prd.Id == jeuID).FirstOrDefault();
            if (delPrd != null)
            {
                _context.Jeux.Remove(delPrd);
            }
            _context.SaveChanges();
        }
    }
}
