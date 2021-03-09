using Microsoft.EntityFrameworkCore;
using Store.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public class LocationRepository : Store.Logic.Interfaces.ILocationRepository
    {
        private readonly project1rincongamezonestoreContext _dbContext;

        public LocationRepository(project1rincongamezonestoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Store.Logic.Models.Product> GetInventory(int id)
        {
            List<Inventory> storeInventory = _dbContext.Inventories.Where(sinv => sinv.StoreId == id).ToList();
            List<Product> inventoryProducts = _dbContext.Inventories.Include(p => p.Product).Where(pinv => pinv.StoreId == id).Select(p => p.Product).ToList();

            List<Store.Logic.Models.Product> inventory = new List<Store.Logic.Models.Product>();

            foreach(Product p in inventoryProducts)
            {
                inventory.Add(new Logic.Models.Product { Id = p.ProductId, Type = p.Type, Name = p.Name, Price = p.Price});
                System.Diagnostics.Debug.WriteLine("Product: " + p.ProductId + " Type: " + p.Type + " Name: " + p.Name + " Price: " + p.Price);
            }

            return inventory;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
