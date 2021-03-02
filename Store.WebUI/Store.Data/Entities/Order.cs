﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Store.DataAccess.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotal { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Store Store { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
