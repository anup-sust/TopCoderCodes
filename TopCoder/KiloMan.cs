using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class KiloMan
    {
        public int hitsTaken(int[] pattern, String jumps)
        {
            int numberOfHit = 0;
            char[] jumpChar = jumps.ToCharArray();

            for (int i = 0; i < jumpChar.Length; i++)
            {
                if ((jumpChar[i] == 'S' && pattern[i] < 3)
                    || (jumpChar[i] == 'J' && pattern[i] > 2))
                    numberOfHit++;
            }

            return numberOfHit;
        }
    }
}
