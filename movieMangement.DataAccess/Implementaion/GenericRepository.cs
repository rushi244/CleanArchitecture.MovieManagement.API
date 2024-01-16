using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementaion
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly MovieManagementDBContext _dbContext;
        internal DbSet<T> dbSet; 

        public GenericRepository(MovieManagementDBContext dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = _dbContext.Set<T>();
        }
        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }

        public ICollection<T> GetAll()
        {
           return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }
    }
}
