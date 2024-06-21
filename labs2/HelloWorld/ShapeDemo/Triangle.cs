using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Triangle : Shape
    {
        double breadth, height;

        public Triangle(double breadth, double height)
        {
            this.breadth = breadth;
            this.height = height;
        }
        public override double Area()
        {
            return 0.5 * breadth * height;
        }
    }
}
