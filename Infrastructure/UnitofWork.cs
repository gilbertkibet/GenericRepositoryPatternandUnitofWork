using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    
    public class UnitofWork:IUnitOfWork 
    {
        private readonly ApplicationContext _context;
        public UnitofWork(ApplicationContext context)
        {

            _context = context;

        }

        public IDeveloperRepository developers { get;private set; }

        public IProjectRepository projects { get;private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
