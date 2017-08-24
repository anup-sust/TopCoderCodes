using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class StairsFixer
    {
        private Stairs Stairs;

        public StairsFixer()
        {
            this.Stairs = new Stairs();
        }



        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.Stairs.designs(22, 25, 100, 100) == 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.Stairs.designs(25, 25, 60, 100) == 2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.Stairs.designs(1000, 1, 600, 600) == 6);
        }


    }
}
