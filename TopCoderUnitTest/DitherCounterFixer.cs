using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class DitherCounterFixer
    {
        private DitherCounter DitherCounter;
        public DitherCounterFixer()
        {
            this.DitherCounter = new DitherCounter();
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.DitherCounter.count("BW", new[] {"AAAAAAAA",
                              "ABWBWBWA",
                              "AWBWBWBA",
                              "ABWBWBWA",
                              "AWBWBWBA",
                              "AAAAAAAA"}
                          ) == 24);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.DitherCounter.count("BW", new[] {"BBBBBBBB",
                              "BBWBWBWB",
                              "BWBWBWBB",
                              "BBWBWBWB",
                              "BWBWBWBB",
                              "BBBBBBBB"}

                          ) == 48);

        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.DitherCounter.count("ACEGIKMOQSUWY", new[] {"ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                              "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                              "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                              "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                              "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX",
                              "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWX"}

                          ) == 150);

        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.DitherCounter.count("CA", new[] {"BBBBBBB",
                              "BBBBBBB",
                              "BBBBBBB"}
                          ) == 0);

        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.DitherCounter.count("DCBA", new[] { "ACBD" }

                          ) == 4);

        }
    }
}
