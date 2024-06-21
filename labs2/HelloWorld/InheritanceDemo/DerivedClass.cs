using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            throw new NotImplementedException();
        }
        public override void Method2()
        {
            base.Method2();
        }
    }
}
