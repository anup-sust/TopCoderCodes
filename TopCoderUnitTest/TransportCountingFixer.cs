using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class TransportCountingFixer
    {
        private TransportCounting TransportCounting;
        public TransportCountingFixer()
        {
            this.TransportCounting = new TransportCounting();
        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.TransportCounting.countBuses(100, new[] { 0 }, new int[] { 0 }, 0) == 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.TransportCounting.countBuses(5, new[] { 10, 10 }, new int[] { 0, 1 }, 2) == 1);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.TransportCounting.countBuses(5, new[] { 10, 10 }, new int[] { 0, 1 }, 3) == 2);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.TransportCounting.countBuses(777,
                new[] {10,20,30,40,50,60,70,80,90,100,
                                  110,120,130,140,150,160,170,180,190,200,
                                  210,220,230,240,250,260,270,280,290,300,
                                  310,320,330,340,350,360,370,380,390,400,
                                  410,420,430,440,450,460,470,480,490,500},
                new[] {10,20,30,40,50,60,70,80,90,100,
                                  110,120,130,140,150,160,170,180,190,200,
                                  210,220,230,240,250,260,270,280,290,300,
                                  310,320,330,340,350,360,370,380,390,400,
                                  410,420,430,440,450,460,470,480,490,500},
                333) == 50);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.TransportCounting.countBuses(5, new[] { 0, 0, 0 }, new int[] { 4, 5, 6 }, 10) == 3);
        }
    }
}
