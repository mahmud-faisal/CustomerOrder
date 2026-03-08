using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Models.EntityModels
{
    public class CustomerCategory:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Customer> Customers { get; set; }
    }
}
