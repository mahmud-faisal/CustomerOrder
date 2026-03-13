using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrder.Models.EntityModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
    }
}
