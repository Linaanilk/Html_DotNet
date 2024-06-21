using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3Features
{
    internal class Customer
    {
        public int CustomerId { get; private set; }
        public string Name { get; set; }
        public string City { get; set;}
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
    }

}
