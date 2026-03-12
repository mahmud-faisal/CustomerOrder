using CustomerOrder.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CustomerOrder.Repositories.Abstractions
{
    public interface IRepository<T> where T : class,IEntity
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        ICollection<T> GetAll();
        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);
        ICollection<T> GetMany(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetQueryable();
    }
}
