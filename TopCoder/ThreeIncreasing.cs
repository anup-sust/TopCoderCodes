using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class ThreeIncreasing
    {
        public int minEaten(int a, int b, int c)
        {
            int needToEat = 0;
            if (c <= b)
            {
                needToEat = b - c + 1;
                b = b - needToEat;
                if (b < 1)
                {
                    return -1;
                }
            }
            if (b <= a)
            {
                needToEat += a - b + 1;
                a = a - (a - b + 1);
                if (a < 1)
                {
                    return -1;
                }
            }
            return needToEat;
        }
    }
}
