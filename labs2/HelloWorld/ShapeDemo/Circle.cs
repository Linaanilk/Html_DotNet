using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
     class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
