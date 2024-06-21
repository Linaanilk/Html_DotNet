using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class OrderEventArgs:EventArgs
    {
        public string Email { get; set; }
        public long Phone { get; set; }
    }
}
