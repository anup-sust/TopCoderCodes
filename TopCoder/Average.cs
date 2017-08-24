using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class Average
    {
        public int belowAvg(int[] math, int[] verbal)
        {
            int[] compositAvg = new int[math.Length];
            float totalAvg = 0;
            for (long i = 0; i < math.Length; i++)
            {
                compositAvg[i] = math[i] + verbal[i];
                totalAvg += compositAvg[i];
            }
            totalAvg = totalAvg / math.Length;

            int bellowAvg = 0;

            for (long i = 0; i < compositAvg.Length; i++)
            {
                if (compositAvg[i] < totalAvg)
                {
                    bellowAvg++;
                }
            }
            return bellowAvg;
        }
    }
}
