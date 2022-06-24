using Jalon1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    public class EditeurQuery
    {
        private readonly Context _context;


        public EditeurQuery(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Récupère tous les éditeurs de la BD
        /// </summary>
        /// <returns></returns>
        public IQueryable<Editeur> GetAll()
        {
            return _context.Editeurs;
        }

        /// <summary>
        /// Récupère un éditeur par son id en BD
        /// </summary>
        public IQueryable<Editeur> GetByID(int id)
        {
            return _context.Editeurs.Where(p => p.Id == id);
        }
    }
}
