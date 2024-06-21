using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    abstract class BaseClass
    {
        public abstract void Method1();

        public virtual void Method2() 
        {
            Console.WriteLine("hi");

        }
        public void Method3() 
        {
            Console.WriteLine("hello");
        }
    }
}
