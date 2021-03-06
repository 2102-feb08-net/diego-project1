﻿using Store.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Logic.Interfaces
{
    public interface ILocationRepository
    {
        ///// <summary>
        ///// Add Location to database.
        ///// </summary>
        //public void AddLocation(Location localStore);

        ///// <summary>
        ///// Remove Location from database.
        ///// </summary>
        //public void RemoveLocation(Location localStore);

        ///// <summary>
        ///// Add Product to inventory.
        ///// </summary>
        //public void AddProductToInventory(Product item);

        ///// <summary>
        ///// Remove Product from inventory.
        ///// </summary>
        //public void RemoveProductFromInventory(Product item);

        /// <summary>
        /// Get products from inventory given the id of the store.
        /// </summary>
        public IEnumerable<Product> GetInventory(int id);

        /// <summary>
        /// Save changes to Database.
        /// </summary>
        public void Save();
    }
}
