using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class BirthdayOdds
    {
        public int minPeople(int minOdds, int daysInYear)
        {
            int minPpl = 1;
            float currentPoss = 1;
            while (100 - (currentPoss * 100) <= minOdds)
            {
                minPpl = minPpl + 1;
                currentPoss = (currentPoss * (daysInYear + 1 - minPpl)) / daysInYear;
            }
            return minPpl;

        }
    }
}
