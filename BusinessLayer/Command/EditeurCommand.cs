using Jalon1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Command
{
    public class EditeurCommand
    {
        private readonly Context _context;

        public EditeurCommand(Context context)
        {
            this._context = context;
        }

        public int Ajouter(Editeur p)
        {
            _context.Editeurs.Add(p);
            return _context.SaveChanges();
        }

        public void Modifier(Editeur p)
        {
            Editeur upPrd = _context.Editeurs.Where(prd => prd.Id == p.Id).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.Nom = p.Nom;
            }
            _context.SaveChanges();
        }

        public void Supprimer(int editeurID)
        {
            Editeur delPrd = _context.Editeurs.Where(prd => prd.Id == editeurID).FirstOrDefault();
            if (delPrd != null)
            {
                _context.Editeurs.Remove(delPrd);
            }
            _context.SaveChanges();
        }
    }
}
