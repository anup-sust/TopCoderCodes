using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class TeamSplit
    {
        public int difference(int[] strengths)
        {
            int[] sorted = SortIntList(strengths);
            long first = 0, second = 0;
            for (int i = 0; i < strengths.Length; i++)
            {
                if (i % 2 == 0) first += sorted[i];
                else if (i % 2 == 1) second += sorted[i];
            }

            return (int)Math.Abs(first - second);
        }

        private int[] SortIntList(int[] strengths)
        {
            return strengths.OrderBy(x => x).ToArray();
        }
    }
}
