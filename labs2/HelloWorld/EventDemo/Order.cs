using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    delegate void OrderEventHndler();
    internal class Order
    {
        //public event OrderEventHndler OnCreated;
       // public event EventHandler OnCreated;
       public event EventHandler<OrderEventArgs> OnCreated;
        public void Create(string email, long phone)
        {
            Console.WriteLine("Order Placed");
            //Email.Send();
            //Sms.Send();
            if(OnCreated != null)
            {
                OnCreated(this, new OrderEventArgs
                {
                    Email=email,
                    Phone=phone
                });
            }
        }
    }
}
