using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class ClockWalk
    {
        public int finalPosition(String flips)
        {
            int finalHour = 0;

            for (int i = 1; i <= flips.Length; i++)
            {
                if (flips[i - 1] == 'h')
                {
                    finalHour += i;
                }
                else if (flips[i - 1] == 't')
                {
                    finalHour -= i;
                }
            }
            if (finalHour < 0) finalHour = 12 - (Math.Abs(finalHour) % 12);
            else
            {
                finalHour = finalHour % 12;
            }
            if (finalHour == 0) return 12;
            return finalHour;
        }
    }
}
