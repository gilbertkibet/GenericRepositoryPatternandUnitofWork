using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationContext _context;
        public GenericRepository(ApplicationContext context)
        {
            _context = context; 
        }
        public void Add(T entity)
        {
           _context.Set<T>().Add(entity);
        }

        public void AddAsync(T entity)
        {
            _context.Set<T>().AddAsync(entity);
        }

        public void AddRange(List<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public List<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }

        public List<T> GetAll()
        {
          return _context.Set<T>().ToList();    
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync(); 
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }


        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(List<T> entities)
        {

            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
