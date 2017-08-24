using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class ThreeIncreasingFixture
    {
        private ThreeIncreasing ThreeIncreasing;

        public ThreeIncreasingFixture()
        {
            this.ThreeIncreasing = new ThreeIncreasing();
        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.ThreeIncreasing.minEaten(15, 40 , 22) == 19);
        }


        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.ThreeIncreasing.minEaten(5, 6, 6) == 2);
        }


        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.ThreeIncreasing.minEaten(6, 1, 3000) == -1);
        }


        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.ThreeIncreasing.minEaten(6, 4, 2) == -1);
        }


        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.ThreeIncreasing.minEaten(4, 2, 6) == 3);
        }


        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(this.ThreeIncreasing.minEaten(1, 1234, 3000) == 0);
        }


        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(this.ThreeIncreasing.minEaten(2789, 2400, 1693) == 1806);
        }


    }
}
