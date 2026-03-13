using CustomerOrder.Models.EntityModels;
using CustomerOrder.Repositories.Abstractions;
using CustomerOrder.Repositories.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Repositories
{
    public class CustomerRepository:Repository<Customer>,ICustomerRepository
    {
        CustomerOrderDbContext _db;
        public CustomerRepository(CustomerOrderDbContext db):base(db)
        {
            _db = db;
        }

        public override ICollection<Customer> GetAll()
        {
            return _db.Customers.Include(c => c.Category).ToList();
        }

        //public override IQueryable<Customer> GetQueryable()
        //{
        //    return _db.Customers.Include(c => c.Category).AsQueryable();
        //}


    }
}
