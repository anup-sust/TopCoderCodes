using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class KiloManFixer
    {
        private KiloMan KiloMan;

        public KiloManFixer()
        {
            this.KiloMan = new KiloMan();
        }


        [TestMethod]
        public void TestMethod1()
        {
           Assert.IsTrue(this.KiloMan.hitsTaken(new [] { 1, 3, 2, 3, 3, 1, 2, 2, 1 }, "JJSSSJSSJ") == 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.KiloMan.hitsTaken(new[] {1,1,1,1,1,1,1,2,2,2,2,2,2,2,3,3,3,3,3,3,3,4,4,4,4,
                4,4,4,5,5,5,5,5,5,5,6,6,6,6,6,6,6,7,7,7,7,7,7,7}, "SSSSSSSSSSSSSSJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJJ") == 49);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.KiloMan.hitsTaken(new[] { 1, 2, 2, 1 }, "SJJS") == 2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.KiloMan.hitsTaken(new[] { 1 }, "J") == 0);
        }
    }
}
