using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class AverageAverageFixture
    {
        private AverageAverage AverageAverage;
        public AverageAverageFixture()
        {
            this.AverageAverage = new AverageAverage();
        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.AverageAverage.average(new []{1,2,3})== 2.0d);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.AverageAverage.average(new[] { 42 }) == 42.0d);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.AverageAverage.average(new[] { 3, 1, 4, 15, 9 }) == 6.4d);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.AverageAverage.average(new[] { 3, 1, 4, 15, 9 }) == 6.4d);
        }
    }
}
