using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class OnLineRankFixer
    {
        private OnLineRank OnLineRank;

        public OnLineRankFixer()
        {
            this.OnLineRank = new OnLineRank();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.OnLineRank.calcRanks(3, new[] { 6, 9, 8, 15, 7, 12 }) == 11);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.OnLineRank.calcRanks(80, new[] { 3, 3, 3, 3, 3, 3, 3 }) == 7);
        }
    }
}
