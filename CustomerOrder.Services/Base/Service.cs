using CustomerOrder.Models.EntityModels;
using CustomerOrder.Repositories.Abstractions;
using CustomerOrder.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Services.Base
{
    public class Service<T> : IService<T> where T:class,IEntity 
    {
        IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual bool Add(T entity)
        {
            return _repository.Add(entity);
        }

        public virtual T Get(int id)
        {
            return _repository.Get(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual bool Remove(T entity)
        {
            return _repository.Remove(entity);
        }

        public virtual bool Update(T entity)
        {
            return _repository.Update(entity);
        }


    }
}
