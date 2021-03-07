using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            IQueryable<Customer> customer = _dbContext.Customers.Select(c => c).Where(c => c.Email == email && c.Password == password);
            List<Customer> customerQuery = customer.ToList<Customer>();
            Store.Logic.Models.Customer customerData = new Store.Logic.Models.Customer();

            foreach(Customer cu in customerQuery)
            {
                customerData.FirstName = cu.FirstName;
                customerData.LastName = cu.LastName;
                customerData.Email = cu.Email;
                customerData.Password = cu.Password;
            }

            return customerData;
            
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
