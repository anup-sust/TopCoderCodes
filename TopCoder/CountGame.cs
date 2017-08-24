using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class CountGame
    {
        public int howMany(int maxAdd, int goal, int next)
        {

            if (goal == next)
            {
                return 1;
            }
            int div = (goal - next +1) % (maxAdd + 1);
            if (div == 0) return -1;
            else
            {
                return div;
            }

        }
    }
}
