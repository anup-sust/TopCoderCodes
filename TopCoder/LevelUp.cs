using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class LevelUp
    {
        public int toNextLevel(int[] expNeeded, int received)
        {
            int i = 0;
            while (i < expNeeded.Length - 1 && received >= expNeeded[i])
            {
                i++;
            }
            if (received >= expNeeded[i]) return 0;
            return expNeeded[i] - received;
        }
    }
}
