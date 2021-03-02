using Store.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Logic.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Get all Products from Database.
        /// </summary> 
        public IEnumerable<Product> GetProducts();

        ///<summary>
        /// Add Product to db.
        /// </summary> 
        //public void AddProduct(Product item);

        /// <summary>
        /// Remove Product from db.
        /// </summary>
        //public void RemoveProduct(Product item);

        /// <summary>
        /// Save changes to database.
        /// </summary>
        public void Save();
    }
}
