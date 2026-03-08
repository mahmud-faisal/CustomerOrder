using CustomerOrder.Models.EntityModels;
using CustomerOrder.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CustomerOrder.Repositories
{
    public class Repository<T> : IRepository<T> where T:class,IEntity
    {
        protected DbContext _db;
        public Repository(DbContext db)
        {
            _db = db;
        }

        private DbSet<T> Table
        {
            get { 
                return _db.Set<T>();
            }
        }

        public virtual bool Add(T entity)
        {
            _db.Add(entity);
            return _db.SaveChanges() > 0;
        }
        public virtual bool Update(T entity)
        {
            _db.Update(entity);
            return _db.SaveChanges() > 0;
        }
        public virtual bool Remove(T entity)
        {
            _db.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual ICollection<T> GetAll(){
            return Table.ToList();
        }

        public virtual T Get(int id)
        {
            return Table.FirstOrDefault(c => c.Id == id);
        }

        public virtual T Get(Expression<Func<T,bool>> predicate)
        {
            return Table.FirstOrDefault(predicate);
        }

        public virtual ICollection<T> GetMany(Expression<Func<T,bool>> predicate)
        {
            return Table.Where(predicate).ToArray();
        }
        
        //public virtual IQueryable<T> GetQueryable()
        //{
        //    return Table.AsQueryable();
        //}





    }
}
