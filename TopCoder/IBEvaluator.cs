using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class IBEvaluator
    {
        public int[] getSummary(int[] predictedGrades, int[] actualGrades)
        {
            int[] result = new int[7] { 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < actualGrades.Length; i++)
            {
                result[Math.Abs(actualGrades[i] - predictedGrades[i])]++;
            }

            for (int i = 0; i < result.Length; i++)
            {
              //  float val = 

                result[i] = (result[i] * 100) / predictedGrades.Length;
            }

            return result;

        }
    }
}
