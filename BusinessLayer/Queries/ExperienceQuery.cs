using Jalon1;
using Jalon1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Queries
{
    class ExperienceQuery
    {
        private readonly Context _context;

        public ExperienceQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Experience> GetAll()
        {
            return _context.Experiences;
        }

        public IQueryable<Experience> GetByID(int id)
        {
            return _context.Experiences.Where(e => e.Id == id);
        }
    }
}
