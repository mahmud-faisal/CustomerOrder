using CustomerOrder.Models.EntityModels;
using CustomerOrder.Repositories.Abstractions;
using CustomerOrder.Services.Abstractions;
using CustomerOrder.Services.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace CustomerOrder.Services
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        ICustomerRepository _customerRepository;
        public Guid CustomerGuid { get; set; }
        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
            CustomerGuid = Guid.NewGuid();

            Debug.WriteLine($"Customer Service is initited... Guid:{CustomerGuid.ToString()}");
        }

        public override bool Add(Customer entity)
        {
            //There is SoapSchemaMember
            bool isSuccess = _customerRepository.Add(entity);

            if (isSuccess)
            {
                return true;
            }
            return false;
        }

        public ICollection<Customer> GetByCategoryId(int id)
        {
            return _customerRepository.GetMany(c => c.CategoryId == id);
        }

        //Pagination




    }
}
