using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopCoder
{
    public class AverageAverage
    {
        public double average(int[] numList)
        {
            List<int[]> subsets = getSubset(numList);
            double[] avgs = getAvgs(subsets);
            return avgs.Sum() / avgs.Length;
        }

        private List<int[]> getSubset(int[] numList)
        {
            List<int[]> subsets = new List<int[]>();

            for (int i = 0; i < Math.Pow(2, numList.Length); i++)
            {
                List<int> combination = new List<int>();
                for (int j = 0; j < numList.Length; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        combination.Add(numList[j]);
                    }
                }
                if (combination.Count > 0)
                    subsets.Add(combination.ToArray());
            }
            return subsets;
        }

        private double[] getAvgs(List<int[]> sets)
        {
            return sets.Select(x => (double)x.Sum()/x.Length).ToArray();
        }

    }
}
