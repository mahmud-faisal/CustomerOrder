using CustomerOrder.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Repositories.Abstractions
{
    public interface ICustomerRepository : IRepository<Customer>
    {
    }
}
