using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3Features
{
    internal static class Extensions
    {
        public static int ToNumber(this string number)
        {
            return Convert.ToInt32(number);
        }
    }
}
