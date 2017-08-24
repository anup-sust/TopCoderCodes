using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class RepeatNumberCompareFixture
    {
        private RepeatNumberCompare RepeatNumberCompare;

        public RepeatNumberCompareFixture()
        {
            this.RepeatNumberCompare = new RepeatNumberCompare();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.RepeatNumberCompare.compare(1234, 3, 70, 4) == "Greater");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.RepeatNumberCompare.compare(1010, 3, 101010, 2) == "Equal");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.RepeatNumberCompare.compare(1234, 10, 456, 20) == "Less");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.RepeatNumberCompare.compare(5, 9, 555555555, 1) == "Equal");
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.RepeatNumberCompare.compare(5, 9, 555555554, 1) == "Greater");
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(this.RepeatNumberCompare.compare(5, 9, 555555556, 1) == "Less");
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(this.RepeatNumberCompare.compare(1000000000, 50, 1000000000, 50) == "Equal");
        }
    }
}
