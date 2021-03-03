using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Store.DataAccess.Entities;
using Store.DataAccess.Repositories;
using Store.Logic.Interfaces;

namespace Store.WebUI
{
    public class Dependencies : IDesignTimeDbContextFactory<project1rincongamezonestoreContext>, IDisposable
    {
        private bool _disposed = false;
        private readonly List<IDisposable> _disposableInterfaces = new List<IDisposable>();

        // Create DBContext Options Builder
        public project1rincongamezonestoreContext CreateDbContext (string[] args = null)
        {
            var builder = new DbContextOptionsBuilder<project1rincongamezonestoreContext>();
            string connectionString = File.ReadAllText("C:/Users/Uno/Documents/Rev/ProjectSchemas/project1Connection.txt");

            builder.UseSqlServer(connectionString);

            return new project1rincongamezonestoreContext(builder.Options);
        }

        // Product Repository
        public IProductRepository CreateProductRepository()
        {
            var dbContext = CreateDbContext();
            _disposableInterfaces.Add(dbContext);
            return new ProductRepository(dbContext);
        }

        // Customer Repository
        public ICustomerRepository CreateCustomerRepository()
        {
            var dbContext = CreateDbContext();
            _disposableInterfaces.Add(dbContext);
            return new CustomerRepository(dbContext);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Release of managed resources
                    foreach (IDisposable disposable in _disposableInterfaces)
                    {
                        disposable.Dispose();
                    }
                }
                // Release of unmanaged resources
                _disposed = true;
            }
        }
    }
}
