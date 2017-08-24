using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class Medici
    {
        public int winner(int[] fame, int[] fortune, int[] secrets)
        {
            int curremMax = getMin(fame[0], fortune[0], secrets[0]);
            int response = 0;
            for (int i = 1; i < fame.Length; i++)
            {
                var min = getMin(fame[i], fortune[i], secrets[i]);
                if (min > curremMax)
                {
                    curremMax = min;
                    response = i;
                }
                else if (min == curremMax) response = -1;
            }

            return response;

        }

        private int getMin(int first, int second, int third)
        {
            int min = 0;
            if (first < second) min = first;
            else min = second;

            if (min < third) return min;
            return third;

        }
    }
}
