using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal static class Functions
    {
        public static double Function(double x,double a, double b, double c)
        {
            if (a < 0 & x != 0)
                return a * Math.Pow(x, 2) + Math.Pow(b,2);
            else if (a > 0 & x != 0)
                return x-a/(x-c);
            else return 1+x/c;
        }
    }
}
