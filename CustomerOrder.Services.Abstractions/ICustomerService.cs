using CustomerOrder.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Services.Abstractions
{
   
        public interface ICustomerService : IService<Customer>
        {
            Guid CustomerGuid { get; set; }
            ICollection<Customer> GetByCategoryId(int id);
            
            //ICollection<Customer> ----- There is something API
        }
    
}
