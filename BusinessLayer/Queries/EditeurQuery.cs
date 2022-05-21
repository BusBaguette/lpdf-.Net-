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

        public IQueryable<Editeur> GetAll()
        {
            return _context.Editeurs;
        }

        public IQueryable<Editeur> GetByID(int id)
        {
            return _context.Editeurs.Where(p => p.Id == id);
        }
    }
}
