using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Logic.Interfaces;
using Store.WebUI.Models;
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

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpPost("api/customer/registration")]
        public void AddCustomer(WebCustomer customer)
        {
            // Get data from signin.html table
            // Call method AddCustomer from CustomerRepository
            // Save form data in database
        }
    }
}
