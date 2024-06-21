using System;
using System.Collections.Generic;

namespace EFCoreDbFirstTutorial.Models-force
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Price { get; set; }
        public int StockQuantity { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
