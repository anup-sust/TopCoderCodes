using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class RepeatNumberCompare
    {
        public String compare(int x1, int k1, int x2, int k2)
        {
            string first = "";
            string second = "";
            for (int i = 0; i < k1; i++)
            {
                first += x1.ToString();
            }
            for (int i = 0; i < k2; i++)
            {
                second += x2.ToString();
            }

            if (first.Length > second.Length) return "Greater";
            if (first.Length < second.Length) return "Less";
            if (first == second) return "Equal";
            return CompareStr(first, second);

        }

        private string CompareStr(string s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] > s2[i]) return "Greater";
                if (s2[i] > s1[i]) return "Less";
            }

            return "Equal";
        }
    }
}
