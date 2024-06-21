using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    internal class ClassA
    {
        int[] numbers;
        public ClassA(int size)
        {
            numbers = new int[size];
        }
        public int this[int index] 
        {
        get
            {
                return numbers[index];
            }
            set {
                numbers[index] = value;
            }
        }
    }
}
