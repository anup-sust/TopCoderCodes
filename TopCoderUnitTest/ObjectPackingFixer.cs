using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class ObjectPackingFixer
    {
        private ObjectPacking ObjectPacking;

        public ObjectPackingFixer()
        {
            this.ObjectPacking = new ObjectPacking();;
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.ObjectPacking.smallBox(7, 3, new []{3}, new []{7}) == 21);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.ObjectPacking.smallBox(5, 8, new[] { 6, 9, 3 }, new[] { 7, 4, 5 }) == -1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.ObjectPacking.smallBox(17, 5, new[] { 19, 10, 12, 40 }, new[] { 12, 20, 15, 5 }) == 200);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.ObjectPacking.smallBox(20, 44, new[] { 36, 42, 18, 37, 33, 5, 30, 10, 29, 9, 11, 16, 48, 50, 34, 44, 33, 12, 31, 41 }, new[] { 42, 45, 46, 24, 23, 21, 21, 8, 26, 25, 48, 12, 10, 45, 18, 6, 12, 22, 42, 45 }) == 1845);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.ObjectPacking.smallBox(1, 10, new[] { 9, 1, 10 }, new[] { 10, 6, 4 }) == 40);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(this.ObjectPacking.smallBox(5, 4, new[] { 2, 3, 3, 3, 3 }, new[] { 2, 7, 7, 4, 2 }) == -1);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.IsTrue(this.ObjectPacking.smallBox(3, 3, new[] { 2, 3, 3, 3, 2 }, new[] { 3, 1, 3, 3, 2 }) == 9);
        }
    }
}
