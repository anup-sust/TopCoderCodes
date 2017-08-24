using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class ClockWalkFixer
    {
        private ClockWalk ClockWalk;
        public ClockWalkFixer()
        {
            this.ClockWalk = new ClockWalk();
        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.ClockWalk.finalPosition("hhthh")==9);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.ClockWalk.finalPosition("hhtht") == 11);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.ClockWalk.finalPosition("hthth") == 3);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.ClockWalk.finalPosition("hthhhhh") == 12);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.ClockWalk.finalPosition("hthhthtththhtttthttthhhthtttthh") == 6);
        }
    }
}
