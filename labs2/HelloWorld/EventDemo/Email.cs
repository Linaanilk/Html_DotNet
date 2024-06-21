using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Email
    {
        public static void Send(object sender,OrderEventArgs e)
        { 
            Console.WriteLine($"Email sent to {e.Email}");
        }
    }
}
