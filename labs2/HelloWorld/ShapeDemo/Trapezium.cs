using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Trapezium : Shape
    {
        double height, length, breadth;

        public Trapezium(double height, double length, double breadth)
        {
            this.height = height;
            this.length = length;
            this.breadth = breadth;
        }
        public override double Area()
        {
           return 0.5*height*(length+breadth);
        }
    }
}
