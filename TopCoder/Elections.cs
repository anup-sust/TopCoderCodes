using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class Elections
    {
        public int visit(String[] likelihoods)
        {
            float currentPercent = (float)getChar(likelihoods[0], '1', '2')[0] / likelihoods[0].Length;
            int currentPos = 0;

            for (int i = 1; i < likelihoods.Length; i++)
            {
                float currentPer = (float)getChar(likelihoods[i], '1', '2')[0] / likelihoods[i].Length;
                if (currentPer < currentPercent)
                {
                    currentPercent = currentPer;
                    currentPos = i;
                }
            }

            return currentPos;

        }

        private int[] getChar(string str, char chr1, char chr2)
        {
            int[] count = { 0, 0 };
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr1) count[0]++;
                else if (str[i] == chr2) count[1]++;
            }
            return count;
        }

    }
}
