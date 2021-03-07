using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Store.DataAccess.Entities;

namespace Store.DataAccess.Repositories
{
    public class CustomerRepository : Store.Logic.Interfaces.ICustomerRepository
    {
        private readonly project1rincongamezonestoreContext _dbContext;

        public CustomerRepository(project1rincongamezonestoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddCustomer(Store.Logic.Models.Customer cust)
        {
            var entity = new Customer
            {
                FirstName = cust.FirstName,
                LastName = cust.LastName,
                Email = cust.Email,
                Password = cust.Password,
                Admin = cust.Admin
            };

            _dbContext.Add(entity);
        }

        public Store.Logic.Models.Customer GetCustomerByEmail(string email, string password)
        {
            var customer = _dbContext.Customers.Where(c => c.Email == email && c.Password == password).First();

            return new Store.Logic.Models.Customer { 
                FirstName = customer.FirstName, 
                LastName = customer.LastName, 
                Email = customer.Email, 
                Password = customer.Password
            };
            
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
