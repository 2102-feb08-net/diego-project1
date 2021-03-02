using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.DataAccess.Entities;

namespace Store.DataAccess.Repositories
{
    public class ProductRepository : Store.Logic.Interfaces.IProductRepository
    {
        private readonly project1rincongamezonestoreContext _dbContext;

        public ProductRepository(project1rincongamezonestoreContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        // Make the list of products
        private List<Store.Logic.Models.Product> _products;

        // Return list of products
        public IEnumerable<Store.Logic.Models.Product> GetProducts() {
            IQueryable<Product> items = _dbContext.Products;
            _products = items.Select(p => new Store.Logic.Models.Product
            {
                Type = p.Type,
                Name = p.Name,
                Id = p.ProductId,
                Price = p.Price
            }).ToList();

            return _products;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
