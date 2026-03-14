using CustomerOrder.Models.EntityModels;
using CustomerOrder.Models.ViewModels.Customers;
using CustomerOrder.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace CustomerOrder.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _customerService;


        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
           var customers = _customerService.GetAll().ToList();
            var model = new CustomerIndexViewModel();
            model.Customers = customers;
            return View(model);
        }


        public ViewResult Create()
        {
            var model = new CustomerCreateViewModel();
            model.Customers = _customerService.GetAll().ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CustomerCreateViewModel model) {

            bool success = false;
            if (ModelState.IsValid)
            {
                var customer = new Customer()
                {
                    Name = model.Name,
                    PhoneNo = model.PhoneNo,
                    Address = model.Address,
                    CategoryId = 1
                };

                success = _customerService.Add(customer);

                if (!success)
                {
                    ModelState.AddModelError("", "Couldnot save the record!");
                }

            }
            if (success)
            {
                return RedirectToAction("Create");
            }
            model.Customers = _customerService.GetAll().ToList();
            return View(model);

        }


        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return View("NotFound");
            }
            var customer = _customerService.Get((int)id);
            if(customer == null)
            {
                return View("NotFound");
            }

            var model = new CustomerEditViewModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                PhoneNo = customer.PhoneNo,
                Address = customer.Address
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(CustomerEditViewModel model)
        {
            var existingCustomer = _customerService.Get(model.Id);

            if (existingCustomer == null)
            {
                return View("Customer Not Found to Update!");
            }

            existingCustomer.Name = model.Name;
            existingCustomer.PhoneNo = model.PhoneNo;
            existingCustomer.Address = model.Address;

            bool isUpdated = _customerService.Update(existingCustomer);

            if (isUpdated) {
                return RedirectToAction("Index");
            }
            return View(model);
        }



        //Detail

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }
            var customer = _customerService.Get((int)id);
            if (customer == null)
            {
                return View("NotFound");
            }

            var model = new CustomerDetailViewModel()
            {
                
                Name = customer.Name,
                PhoneNo = customer.PhoneNo,
                Address = customer.Address
            };

            return View(model);
        }



        //Remove

        public IActionResult Remove(int? id)
        {
            if (id == null)
            {
                return View("NotFound");
            }
            var customer = _customerService.Get((int)id);
            if (customer == null)
            {
                return View("NotFound");
            }

            var model = new CustomerRemoveViewModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                PhoneNo = customer.PhoneNo,
                Address = customer.Address
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult RemoveConfirmation(int? id)
        {

            if (id == null)
            {
                return View("NotFound");
            }
            var customer = _customerService.Get((int)id);
            if (customer == null)
            {
                return View("NotFound");
            }

            _customerService.Remove(customer);

            return RedirectToAction("Index");
        }



    }
}
