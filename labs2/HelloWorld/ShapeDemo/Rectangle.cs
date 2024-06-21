using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Rectangle : Shape
    {

        double length, breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double Area()
        {
            return length * breadth;
        }

    }
}

