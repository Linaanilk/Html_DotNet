using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Sms
    {
        public static void Send(object sender, OrderEventArgs e)
        {
            Console.WriteLine($"SMS sent to {e.Phone}");
        }
    }
}
