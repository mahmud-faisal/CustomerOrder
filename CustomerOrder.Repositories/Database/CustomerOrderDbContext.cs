using CustomerOrder.Models.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Repositories.Database
{
    public class CustomerOrderDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerCategory> CustomerCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
    }
}
