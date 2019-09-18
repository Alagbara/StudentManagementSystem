using System;
using System.Linq;
using System.Linq.Expressions;

namespace StudentmanagementSystem.Models
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func <T, bool>> Expression);
        void Create(T components);
        void Update(T components);
        void Delete(T components);
    }
}
