using System;
using System.Collections.Generic;

namespace EFCoreDbFirstTutorial.Models-force
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Address { get; set; } = null!;
        public long Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
