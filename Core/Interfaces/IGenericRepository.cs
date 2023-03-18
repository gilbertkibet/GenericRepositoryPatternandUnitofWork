using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        

        List<T> GetAll();   

        List<T> Find(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAllAsync(); 

        void Add(T entity);

        void AddRange(List<T> entities);

        void Remove(T entity);  

        void RemoveRange(List<T> entities);

        void AddAsync(T entity);    

        void Update(T entity);


    }
}
