using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class ObjectPacking
    {
        public int smallBox(int objWidth, int objLength, int[] boxWidth, int[] boxLength)
        {
            long min = 0;
            for (int i = 0; i < boxWidth.Length; i++)
            {
                if ((boxWidth[i] >= objWidth && boxLength[i] >= objLength) ||
                    (boxWidth[i] >= objLength && boxLength[i] >= objWidth))
                {
                    if (min == 0 || boxWidth[i] * boxLength[i] < min) min = boxWidth[i] * boxLength[i];
                }
            }
            if (min == 0) min = -1;
            return (int)min;
        }
    }
}
