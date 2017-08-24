using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class IBEvaluatorFixer
    {
        private IBEvaluator IBEvaluator;


        public IBEvaluatorFixer()
        {
            this.IBEvaluator = new IBEvaluator();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] response = this.IBEvaluator.getSummary(new[] { 1, 5, 7, 3 }, new[] { 3, 5, 4, 5 });
            int[] result = new int[] { 25, 0, 50, 25, 0, 0, 0 };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] response = this.IBEvaluator.getSummary(new[]
                {1, 1, 1}, new[] { 5, 6, 7 });
            int[] result = new[] { 0, 0, 0, 0, 33, 33, 33 };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] response = this.IBEvaluator.getSummary(new[] { 3 }, new[] { 3 });
            int[] result = new[] { 100, 0, 0, 0, 0, 0, 0 };

            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }


        [TestMethod]
        public void TestMethod4()
        {
            int[] response = this.IBEvaluator.getSummary(
                new[] { 1, 5, 3, 5, 6, 4, 2, 5, 7, 6, 5, 2, 3, 4, 1, 4, 6, 5, 4, 7, 6, 6, 1 },
                new[] { 5, 1, 3, 2, 6, 4, 1, 7, 5, 2, 7, 4, 2, 6, 5, 7, 3, 1, 4, 6, 3, 1, 7 });
            int[] result = new[]
                { 17,  13,  21,  17,  21,  4,  4 };

            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }


    }
}
