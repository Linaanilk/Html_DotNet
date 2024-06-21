using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdonetIllustrations.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        public int Price {  get; set; }
        public int StockQuantity {  get; set; }

    }
}
