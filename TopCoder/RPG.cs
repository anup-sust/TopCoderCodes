using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class RPG
    {
        public int[] dieRolls(String[] dice)
        {
            int Min = 0, Max = 0, Avg = 0;

            for (int i = 0; i < dice.Length; i++)
            {
                int rollNumber = Int32.Parse(dice[i].Split('d')[0]);
                int size = Int32.Parse(dice[i].Split('d')[1]);
                Min += rollNumber;
                Max += size * rollNumber;
            }
            Avg = (Min + Max) / 2;

            return new[] { Min, Max, Avg };
            ;
        }
    }
}
