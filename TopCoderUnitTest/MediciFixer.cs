using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class MediciFixer
    {
        private Medici Medici;
        public MediciFixer()
        {
            this.Medici = new Medici();
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.Medici.winner(new[] { 20, 30, 50 }, new[] { 60, 80, 40 }, new[] { 40, 30, 50 }) == 2);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.Medici.winner(new[] { 0, 100, 100, 100 }, new[] { 100, 0, 100, 50 }, new[] { 50, 50, 50, 100 }) == -1);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.Medici.winner(new[] { 1, 0 }, new[] { 1, 99 }, new[] { 1, 99 }) == 0);

        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.Medici.winner(new[]
                              { 39, 42, 57 }, new[] { 42, 39, 57 }, new[] { 57, 39, 42 }) == 2);

        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.Medici.winner(new[] 
            { 3, 98, 0, 71, 81, 85, 99, 58, 93, 79, 100, 98, 73, 83, 52, 100, 37, 93, 39, 27 }, new[] 
            { 96, 34, 45, 20, 72, 71, 7, 18, 47, 35, 54, 51, 52, 21, 49, 20, 44, 72, 90, 93 }, new[] 
            { 15, 72, 50, 84, 41, 49, 35, 71, 20, 29, 73, 18, 35, 61, 70, 34, 59, 68, 90, 18 }) == 17);

        }
    }
}
