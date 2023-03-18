using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DeveloperRepository:GenericRepository<Developer>, IDeveloperRepository
    {
        private readonly ApplicationContext _context;
        public DeveloperRepository(ApplicationContext context):base(context)
        {
            _context = context;
        }

        public List<Developer> GetPopularDevelopers(int count)
        {
            return _context.tblDevelopers.OrderByDescending(d=>d.Followers).Take(count).ToList();
        }
    }
}
