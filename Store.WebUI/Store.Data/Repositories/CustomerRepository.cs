﻿using System;
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
                Password = cust.Password
            };

            _dbContext.Add(entity);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
