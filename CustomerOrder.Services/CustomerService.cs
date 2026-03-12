using CustomerOrder.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using CustomerOrder.Services.Base;
using CustomerOrder.Services.Abstractions;
using CustomerOrder.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore.Query.Internal;


namespace CustomerOrder.Services
{
    public class CustomerService : Service<Customer>,ICustomerService
    {
        ICustomerRepository _customerRepository;
        public Guid CustomerGuid {  get; set; }

        public CustomerService(ICustomerRepository customerRepository):base(customerRepository) 
        {
            _customerRepository = customerRepository;
            CustomerGuid = Guid.NewGuid();

        //There is a debug statement
        }

    }
}
