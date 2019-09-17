using System;
using System.Linq;
using System.Linq.Expressions;

namespace StudentmanagementSystem.Models
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func <T, bool>> Expression);
        void Create(T StudentmanagementSystem);
        void Update(T StudentmanagementSystem);
        void Delete(T StudentmanagementSystem);
    }
}
