using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class MovingAveragesFixture
    {
        private MovingAverages MovingAverages;
        public MovingAveragesFixture()
        {
            this.MovingAverages = new MovingAverages();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] result = this.MovingAverages.calculate(new [] { "01:19:10", "01:17:40", "01:19:44", "01:17:23", "01:17:07" }, 3);
            int[] response = {4731, 4695, 4684};
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] result = this.MovingAverages.calculate(new[] { "01:19:10", "01:17:40", "01:19:44", "01:17:23", "01:17:07" }, 1);
            int[] response = { 4750, 4660, 4784, 4643, 4627 };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] result = this.MovingAverages.calculate(new[] { "01:19:10", "01:17:40", "01:19:44", "01:17:23", "01:17:07" }, 5);
            int[] response = { 4692 };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }

      
    }
}
