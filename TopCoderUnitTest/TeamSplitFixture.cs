using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class TeamSplitFixture
    {
        private TeamSplit TeamSplit;
        public TeamSplitFixture()
        {
            this.TeamSplit = new TeamSplit();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.TeamSplit.difference(new[] { 5, 7, 8, 4, 2 }) == 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.TeamSplit.difference(new[] { 100 }) == 100);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.TeamSplit.difference(new[]
                              {1000,1000}) == 0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.TeamSplit.difference(new[] { 9, 8, 7, 6 }) == 2);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.TeamSplit.difference(new[] { 1, 5, 10, 1, 5, 10 }) == 0);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.IsTrue(this.TeamSplit.difference(new[]
            {824, 581,   9, 776, 149, 493, 531, 558, 995, 637,
                394, 526, 986, 548, 344, 509, 319,  37, 790, 491,
                479,  34, 776, 321, 258, 851, 711, 365, 763, 355,
                386, 877, 596,  96, 151, 166, 558, 109, 874, 959,
                845, 181, 976, 335, 930,  22,  78, 120, 907, 584}) == 478);
        }
    }
}
