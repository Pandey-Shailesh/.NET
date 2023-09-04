using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Rectangle:IShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public double CalculateArea()
        {
            return Length * Breadth;
        }
    }
}
