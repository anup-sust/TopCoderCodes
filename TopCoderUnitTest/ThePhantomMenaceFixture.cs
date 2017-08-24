using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class ThePhantomMenaceFixture
    {
        private ThePhantomMenace PhantomMenace;

        public ThePhantomMenaceFixture()
        {
            this.PhantomMenace = new ThePhantomMenace();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.PhantomMenace.find(new [] { 1, 2, 3, 4 }, new [] { 5, 6, 7, 8 }) == 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.PhantomMenace.find(new[] { 1 }, new[] { 10 }) == 9);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.PhantomMenace.find(new[] { 2, 3, 5, 7, 11 }, new[] { 1, 8, 13 }) == 3);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.PhantomMenace.find(new[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }, new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }) == 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.PhantomMenace.find(new[] { 2, 1 }, new[] { 4, 3 }) == 2);
        }
    }
}
