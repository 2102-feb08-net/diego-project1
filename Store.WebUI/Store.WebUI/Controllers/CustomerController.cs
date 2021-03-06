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
            // Store WebCustomer data into Logic Customer Model
            Store.Logic.Models.Customer newCustomer = new Logic.Models.Customer(customer.FirstName, customer.LastName, customer.Email, customer.Password, customer.Admin);

            // Call method AddCustomer from CustomerRepository
            _customerRepository.AddCustomer(newCustomer);

            //// Save form data in database
            _customerRepository.Save();
        }

        // Get customer for login
        [HttpGet("api/customer/login")]
        public Logic.Models.Customer GetCustomer(string email, string password)
        {
            var customer = _customerRepository.GetCustomerByEmail(email, password);

            return new Logic.Models.Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email
            };
        }
    }
}
