﻿using System;
using System.Collections.Generic;

namespace EFCoreDbFirstTutorial.Models-force
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Quantity { get; set; }

        public virtual Product? Product { get; set; }
        public virtual User? User { get; set; }
    }
}
