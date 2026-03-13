using CustomerOrder.Models.EntityModels;
using System.ComponentModel.DataAnnotations;

namespace CustomerOrder.Models.ViewModels.Customers
{
    public class CustomerCreateViewModel
    {
        [Required(ErrorMessage = "Please provide Name!")]
        public string Name { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        [Required]
        public string? Address { get; set; }

        public List<Customer>? Customers { get; set; }


    }
}
