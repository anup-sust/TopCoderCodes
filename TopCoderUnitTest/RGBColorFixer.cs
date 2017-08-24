using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class RGBColorFixer
    {
        private RGBColor RgbColor;

        public RGBColorFixer()
        {
            this.RgbColor = new RGBColor();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int[] response = this.RgbColor.getComplement(new[] {255, 0, 0});
            int[] result = new int[] {0, 255, 255};
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }

        [TestMethod]
        public void TestMethod2()
        {

            int[] response = this.RgbColor.getComplement(new[] { 115, 115, 143 });
            int[] result = new int[] { 243, 243, 15 };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
           
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] response = this.RgbColor.getComplement(new[] { 115, 115, 144 });
            int[] result = new int[] { 140, 140, 111 };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
           
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] response = this.RgbColor.getComplement(new[] { 153, 12, 55 });
            int[] result = new int[] { 102, 243, 200 };
            Assert.IsTrue(!response.Except(result).Any() && !result.Except(response).Any());
        }
    }
}
