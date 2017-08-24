using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class MovingAverages
    {
        public int[] calculate(String[] times, int n)
        {
            int[] result = new int[times.Length - n + 1];

            for (int i = 0; i <= times.Length - n; i++)
            {
                long avg = 0;
                for (int j = i; j < n+i; j++)
                {
                    avg += getSecond(times[j]);
                }
                result[i] = (int) avg / n;
            }
            return result;
        }

        private int getSecond(string secStr)
        {
            int hour = int.Parse(secStr.Split(':')[0]);
            int min = int.Parse(secStr.Split(':')[1]);
            int sec = int.Parse(secStr.Split(':')[2]);

            return hour * 60 * 60 + min * 60 + sec;
        }
    }
}
