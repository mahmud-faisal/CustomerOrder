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
            string connectionString = "Server=localhost;Database=CustomerOrderDB;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.EnableSensitiveDataLogging(true);
        }
    }
}
