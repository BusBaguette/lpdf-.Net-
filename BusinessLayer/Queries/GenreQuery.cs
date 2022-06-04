using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class GenreQuery
    {
        private readonly Context _context;

        public GenreQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Genre> GetAll()
        {
            return _context.Genres;
        }

        public IQueryable<Genre> GetByID(int id)
        {
            return _context.Genres.Where(g => g.Id == id);
        }
    }
}
