using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class ElectionsFixture
    {
        private Elections Elections;
        public ElectionsFixture()
        {
            this.Elections = new Elections();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.Elections.visit(new[] { "1222", "1122", "1222" }) == 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.Elections.visit(new[] { "1222111122", "2222222111", "11111222221222222222" }) == 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.Elections.visit(new[] { "111", "112", "121", "122", "211", "212", "221", "222" }) == 7);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.Elections.visit(new[]
                              {"1122","1221","1212","2112","2121","2211"}) == 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.Elections.visit(new[] { "11112222111121", "1211221212121", "112111222", "11122222222111", "112121222", "1212122211112" }) == 3);
        }

    }
}
