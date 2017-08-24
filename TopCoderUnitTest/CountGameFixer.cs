using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class CountGameFixer
    {
        public CountGame CountGame; 
        public CountGameFixer()
        {
            this.CountGame = new CountGame();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.CountGame.howMany(3,20,10) == 3);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.CountGame.howMany(5, 20, 10) == 5);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.CountGame.howMany(5, 20, 9) == -1);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.CountGame.howMany(4, 50, 50) == 1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.CountGame.howMany(3, 20, 10) == 3);
        }
    }
}
