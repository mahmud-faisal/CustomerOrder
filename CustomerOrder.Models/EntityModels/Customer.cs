using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Models.EntityModels
{
    public class Customer:IEntity
    {
        public Customer()
        {
            
        }
        public Customer(string name,string phone,string address)
        {
            Name = name;
            PhoneNo = phone;
            Address = address;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; } 
        public int CategoryId {  get; set; }
        public virtual CustomerCategory Category { get; set; }
    }
}
