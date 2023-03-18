using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ProjectRepository:GenericRepository<Project>,IProjectRepository
    {
        private readonly ApplicationContext _context;
        public ProjectRepository(ApplicationContext context):base(context) 
        {
            _context = context;
        }
    }
}
