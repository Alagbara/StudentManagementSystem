using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StudentManagementSystem.Repository.Repositories
{
    public class Repository<T> : IRepositoryBase<T> where T : class
    {
        protected DbSet<T> DbSet;

        public Repository(DbContext dataContext)
        {
            this.DbSet = dataContext.Set<T>();
        }

        public void Create(T entity)
        {
            this.DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            this.DbSet.Remove(entity);
        }

        public bool Exists(Expression<Func<T, bool>> expression)
        {
            return this.DbSet.Count(expression) > 0;
        }

        public IEnumerable<T> FindAll()
        {
            return this.DbSet.AsNoTracking();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.DbSet.Where(expression).AsNoTracking();
        }

        public T FindById(int id)
        {
            return this.DbSet.Find(id);
        }

        public void Update(T entity)
        {
            this.DbSet.Update(entity);
        }
    }
}
