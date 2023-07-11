using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    internal class AreaMethod
    {
        public static double areaOfRectangle(double l, double b)
        {
            double result = double.NaN;


            result = l * b;


            return result;
        }

        public static double areaOfSquare(double s)
        {
            return s * s;
        }
        public static double areaOfCircle(double r)
        {
            return 3.14 * r * r;

        }

    }
}
