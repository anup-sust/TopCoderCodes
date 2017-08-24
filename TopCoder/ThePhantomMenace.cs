using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class ThePhantomMenace
    {
        public int find(int[] doors, int[] droids)
        {
            int maxSafety = 0;
            for (int i = 0; i < doors.Length; i++)
            {
                int currentDoorSafety = Math.Abs(droids[0] - doors[i]);
                for (int j = 1; j < droids.Length; j++)
                {
                    if (Math.Abs(droids[j] - doors[i]) < currentDoorSafety)
                        currentDoorSafety = Math.Abs(droids[j] - doors[i]);
                }
                if (currentDoorSafety > maxSafety) maxSafety = currentDoorSafety;

            }

            return maxSafety;
        }
    }
}
