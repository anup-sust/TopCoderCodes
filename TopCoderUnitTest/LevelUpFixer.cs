using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class LevelUpFixer
    {
        private LevelUp LevelUp;
        public LevelUpFixer()
        {
            this.LevelUp = new LevelUp();
        }
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = { 150, 450, 900, 1800 };
            Assert.IsTrue(this.LevelUp.toNextLevel(array, 133) == 17);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] array = { 150, 450, 900, 1800 };
            Assert.IsTrue(this.LevelUp.toNextLevel(array, 312) == 138);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] array = { 150, 450, 900, 1800 };
            Assert.IsTrue(this.LevelUp.toNextLevel(array, 612) == 288);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] array = { 150, 450, 900, 1800 };
            Assert.IsTrue(this.LevelUp.toNextLevel(array, 450) == 450);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int[] array = { 150, 450, 900, 1800 };
            Assert.IsTrue(this.LevelUp.toNextLevel(array, 150) == 300);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int[] array = { 150, 450, 900, 1800 };
            Assert.IsTrue(this.LevelUp.toNextLevel(array, 1800) == 0);
        }
    }
}
