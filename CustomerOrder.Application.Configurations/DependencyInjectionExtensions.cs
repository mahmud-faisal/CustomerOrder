using CustomerOrder.Repositories;
using CustomerOrder.Repositories.Abstractions;
using CustomerOrder.Repositories.Database;
using CustomerOrder.Services;
using CustomerOrder.Services.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CustomerOrder.Application.Configurations
{
    public static class DependencyInjectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<CustomerOrderDbContext>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            
        }
        
    }
}
