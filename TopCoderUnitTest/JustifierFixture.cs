using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class JustifierFixture
    {
        private Justifier Justifier;
        public JustifierFixture()
        {
            this.Justifier = new Justifier();
        }

        [TestMethod]
        public void TestMethod1()
        {
            string[] array = { "BOB", "TOMMY", "JIM" };
            var response = this.Justifier.justify(array);
            string[] result = { "  BOB", "TOMMY", "  JIM" };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());

        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] array = { "JOHN", "JAKE", "ALAN", "BLUE" };
            var response = this.Justifier.justify(array);
            string[] result = { "JOHN", "JAKE", "ALAN", "BLUE" };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());

        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] array = { "LONGEST", "A", "LONGER", "SHORT" };
            var response = this.Justifier.justify(array);
            string[] result = { "LONGEST", "      A", " LONGER", "  SHORT" };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());

        }
    }
}
