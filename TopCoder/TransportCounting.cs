using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class TransportCounting
    {
        public int countBuses(int speed, int[] positions, int[] velocities, int time)
        {
            int meet = 0;
            long distancePassed = speed * time;
            for (var i = 0; i < positions.Length; i++)
            {
                if (distancePassed >= (positions[i] + (velocities[i] * speed)))
                {
                    meet++;
                }
            }

            return meet;
        }
    }
}
