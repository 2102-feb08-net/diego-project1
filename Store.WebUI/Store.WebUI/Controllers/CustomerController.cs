using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.WebUI.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _customerRepository;

        public CustomerController()
        {
            using var dependency = new Dependencies();
            _customerRepository = dependency.CreateCustomerRepository();
        }

        [HttpPost("customer/registration")]
        public void AddCustomer(string jsonList)
        {
            // Get data from signin.html table
            // Call method AddCustomer from CustomerRepository
            // Save form data in database
        }
    }
}
