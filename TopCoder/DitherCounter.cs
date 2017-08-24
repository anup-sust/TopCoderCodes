using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class DitherCounter
    {
        public int count(String dithered, String[] screen)
        {
            var dictionary = dithered.ToCharArray().ToList().ToDictionary(x => x, x => 0);

            for (int i = 0; i < screen.Length; i++)
            {
                foreach (var c in screen[i].ToCharArray())
                {
                    if (dictionary.ContainsKey(c)) dictionary[c]++;
                }
            }

            return dictionary.Values.Sum(x => x);
        }


    }
}
