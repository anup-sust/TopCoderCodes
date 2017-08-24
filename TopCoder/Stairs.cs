using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class Stairs
    {
        public int designs(int maxHeight, int minWidth, int totalHeight, int totalWidth)
        {
            int minRaiser = 0;
            int possibility = 0;
            if (totalHeight % maxHeight == 0)
            {
                minRaiser = totalHeight / maxHeight;
            }
            else
            {
                minRaiser = (totalHeight / maxHeight) + 1;
            }
            if (minRaiser == 1) minRaiser++;

            for (int i = minRaiser; (i - 1) * minWidth <= totalWidth; i++)
            {
                if (totalHeight % i == 0 && (totalWidth % (i - 1)) == 0)
                {
                    possibility++;
                }
            }

            return possibility;
        }
    }
}
