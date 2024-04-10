using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class NODCl
    {
        public int NOD { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }


        public static NODCl NODSearch(int m, int n)
        {
            int a = 1, b = 0, x = 0, y = 1;
            while (n != 0)
            {
                int q = m / n;
                int r = m % n;
                m = n;
                n = r;
                int tempX = x;
                int tempY = y;
                x = a - q * x;
                y = b - q * y;
                a = tempX;
                b = tempY;
            }
            return new NODCl { NOD = m, a = a, b = b };
        }
        public static NODCl NODSearch(int m, int n, int p)
        {
            NODCl nod1 = NODSearch(m, n);
            NODCl nod2 = NODSearch(nod1.NOD, p);

            return new NODCl { NOD = nod2.NOD, a = nod1.a, b = nod1.b, c = nod2.a };
        }
    }
}
