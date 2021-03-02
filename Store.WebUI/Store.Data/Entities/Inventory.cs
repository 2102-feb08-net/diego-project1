﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Store.DataAccess.Entities
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }
    }
}
