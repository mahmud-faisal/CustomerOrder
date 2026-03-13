using CustomerOrder.Models.EntityModels;
using CustomerOrder.Repositories.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Repositories
{
    public class CustomerCategoryRepository : Repository<CustomerCategory>
    {
        CustomerOrderDbContext _db;
        public CustomerCategoryRepository(CustomerOrderDbContext db) : base(db)
        {
            _db = db;
        }

        public override ICollection<CustomerCategory> GetAll()
        {
            //There may have conflict
            return _db.CustomerCategories.Include(c => c.Customers).ToList();
        }

    }
}
