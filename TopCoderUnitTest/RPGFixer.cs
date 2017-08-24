using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class RPGFixer
    {
        private RPG Rpg;
        public RPGFixer()
        {
            this.Rpg = new RPG();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string[] array = { "3d6" };
            var x = this.Rpg.dieRolls(array);
            Assert.IsTrue(this.Rpg.dieRolls(array)[0] == 3);
            Assert.IsTrue(this.Rpg.dieRolls(array)[1] == 18);
            Assert.IsTrue(this.Rpg.dieRolls(array)[2] == 10);
        }


        [TestMethod]
        public void TestMethod2()
        {
            string[] array = { "3d4", "1d6" };
            var x = this.Rpg.dieRolls(array);
            Assert.IsTrue(this.Rpg.dieRolls(array)[0] == 4);
            Assert.IsTrue(this.Rpg.dieRolls(array)[1] == 18);
            Assert.IsTrue(this.Rpg.dieRolls(array)[2] == 11);
        }


        [TestMethod]
        public void TestMethod3()
        {
            string[] array = { "6d5", "10d10", "10d20" };
            var x = this.Rpg.dieRolls(array);
            Assert.IsTrue(this.Rpg.dieRolls(array)[0] == 26);
            Assert.IsTrue(this.Rpg.dieRolls(array)[1] == 330);
            Assert.IsTrue(this.Rpg.dieRolls(array)[2] == 178);
        }


        [TestMethod]
        public void TestMethod4()
        {
            string[] array = { "1d2", "2d2", "4d2", "6d2", "8d2" };
            var x = this.Rpg.dieRolls(array);
            Assert.IsTrue(this.Rpg.dieRolls(array)[0] == 21);
            Assert.IsTrue(this.Rpg.dieRolls(array)[1] == 42);
            Assert.IsTrue(this.Rpg.dieRolls(array)[2] == 31);
        }

    }
}
