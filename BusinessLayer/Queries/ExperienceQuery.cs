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

        /// <summary>
        /// Récupère toutes les expériences en BD
        /// </summary>
        public IQueryable<Experience> GetAll()
        {
            return _context.Experiences;
        }

        /// <summary>
        /// Récupère une expérience par son id
        /// </summary>
        public IQueryable<Experience> GetByID(int id)
        {
            return _context.Experiences.Where(e => e.Id == id);
        }
    }
}
