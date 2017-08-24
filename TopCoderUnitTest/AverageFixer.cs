using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class AverageFixer
    {
        private Average average;
        public AverageFixer()
        {
            this.average = new Average();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.average.belowAvg(new[] { 200, 250, 700, 700 },
                new int[] { 400, 400, 400, 400 }) == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.average.belowAvg(new[] { 500, 400 },
                              new int[] { 300, 400 }) == 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.average.belowAvg(new[] { 293 },
                              new int[] { 799 }) == 0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.average.belowAvg(new[] { 400, 400, 400, 400, 400, 400, 401 },
                              new int[] { 400, 400, 400, 400, 400, 400, 400 }) == 6);
        }
    }
}
