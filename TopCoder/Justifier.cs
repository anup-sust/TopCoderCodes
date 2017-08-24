using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class Justifier
    {
        public String[] justify(String[] textIn)
        {
            var maxLength = textIn[0].Length;

            for (int i = 1; i < textIn.Length; i++)
            {
                if (textIn[i].Length > maxLength)
                    maxLength = textIn[i].Length;
            }
            for (int i = 0; i < textIn.Length; i++)
            {
                textIn[i] = textIn[i].PadLeft(maxLength, ' ');
            }

            return textIn;
        }
    }
}
