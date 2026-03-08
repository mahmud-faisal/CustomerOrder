using CustomerOrder.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Services.Abstractions
{
    public interface IService<T> where T : class,IEntity
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
        ICollection<T> GetAll();
        T Get(int id);
    }
}
