using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Logic.Models
{
    class Product
    {
        /// <summary>
        /// Type of product.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Name of product.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Product Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Price of product. In the inidvidual context it represents the unit price. In the context
        /// of the customer it represents the total price given a specific quantity.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Quantity of product. Used by the customer.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Empty constructor for queries.
        /// </summary>
        public Product()
        {
        }
    }
}
