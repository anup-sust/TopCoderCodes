using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class OnLineRank
    {
        public int calcRanks(int k, int[] scores)
        {
            var rank = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                rank++;
                int limit = 0;
                if (i - k > 0) limit = i - k;

                for (int j = limit; j < i; j++)
                {
                    if (scores[i] < scores[j]) rank++;
                    
                }

            }

            return rank;
        }
    }
}
