using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Logic.Models
{
    class Location
    {
        /// <summary>
        /// Location inventory of products, where the id serves as the key and the product is the value.
        /// </summary>
        private Dictionary<int, Product> _inventory = new Dictionary<int, Product>();
        public Dictionary<int, Product> Inventory { get; }
        /// <summary>
        /// Location address.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Location id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// List of location inventory ids.
        /// </summary> 
        private List<int> _inventoryId = new List<int>();
        public List<int> InventoryId { get; }
        
        /// <summary>
        /// Retrieve location inventory from a given supplier.
        /// </summary>
        public void RetrieveInventory(List<Product> supplier)
        {
            foreach (Product supplierItem in supplier)
            {
                _inventory.Add(supplierItem.Id, supplierItem);
            }
        }

        /// <summary>
        /// Update inventory.
        /// Remove items in inventory as orders are processed and approved.
        /// </summary>
        public bool UpdateInventory(Dictionary<Product, int> order)
        {

            // Remove quantity of a specific product in inventory based on order
            foreach (var item in _inventory)
            {
                foreach (var customerItem in order)
                {
                    if (item.Value.Id == customerItem.Key.Id && ((item.Value.Quantity - customerItem.Key.Quantity) > 0))
                    {
                        item.Value.Quantity -= customerItem.Key.Quantity;
                    }
                    else
                    {
                        RejectOrder(customerItem.Key.Name, order);
                        return false;
                    }
                }
            }

            return true;

        }

        /// <summary>
        /// Reject Order.
        /// Cancel an order due to shortage of specific item in inventory.
        /// </summary>
        public void RejectOrder(string item, Dictionary<Product, int> order)
        {
            Console.WriteLine("Order has been rejected due to the following out of stock item: " + item);
            order.Clear();
        }
    }
}
