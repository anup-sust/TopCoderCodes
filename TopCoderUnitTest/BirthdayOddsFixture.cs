using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class BirthdayOddsFixture
    {
        private BirthdayOdds BirthdayOdds;
        public BirthdayOddsFixture()
        {
            this.BirthdayOdds = new BirthdayOdds();
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.BirthdayOdds.minPeople(75, 5) == 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.BirthdayOdds.minPeople(50, 365) == 23);
           
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.BirthdayOdds.minPeople(1, 365) == 4);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.BirthdayOdds.minPeople(84, 9227) == 184);
        }
    }
}
