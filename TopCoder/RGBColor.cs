using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class RGBColor
    {
        public int[] getComplement(int[] rgb)
        {
            bool differ = true;
            int[] complement = new int[rgb.Length];

            for (int i = 0; i < rgb.Length; i++)
            {
                complement[i] = 255 - rgb[i];
                if (Math.Abs(rgb[i] - complement[i]) > 32)
                    differ = false;
            }

            if (differ)
            {
                for (int i = 0; i < rgb.Length; i++)
                {
                    if (rgb[i] + 128 > 255) complement[i] = rgb[i] - 128;
                    else
                    {
                        complement[i] = rgb[i] + 128;
                    }
                }
            }

            return complement;
        }
    }
}
