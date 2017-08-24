using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class DinkyFishFixer
    {
        private DinkyFish DinkyFish;
        public DinkyFishFixer()
        {
            this.DinkyFish = new DinkyFish();
        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.DinkyFish.monthsUntilCrowded(10, 4 ,6) == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.DinkyFish.monthsUntilCrowded(100, 4, 6) == 5);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.DinkyFish.monthsUntilCrowded(5, 6, 4) == 1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.DinkyFish.monthsUntilCrowded(4, 6, 4) == 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.DinkyFish.monthsUntilCrowded(1000000, 3, 2) == 19);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(this.DinkyFish.monthsUntilCrowded(431131, 764, 249) == 11);
        }
    }
}
