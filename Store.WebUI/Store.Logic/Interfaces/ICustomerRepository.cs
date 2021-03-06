using Store.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Logic.Interfaces
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// Add Customer to Database.
        /// </summary>
        public void AddCustomer(Customer cust);

        /// <summary>
        /// Get customer from database given an email and password.
        /// </summary>
        public Customer GetCustomerByEmail(string email, string password);

        /// <summary>
        /// Get customer from database given an email.
        /// </summary>
        //public Customer GetCustomerByEmail(string mail);

        /// <summary>
        /// Get all customers from database.
        /// </summary>
        //public IEnumerable<Customer> GetCustomers();

        /// <summary>
        /// Save changes to Database.
        /// </summary>
        public void Save();
    }
}
