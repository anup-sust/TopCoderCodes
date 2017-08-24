using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TopCoder;

namespace TopCoderUnitTest
{
    [TestClass]
    public class CrossWordFixer
    {
        private CrossWord CrossWord;
        public CrossWordFixer()
        {
            this.CrossWord = new CrossWord();
        }


        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(this.CrossWord.countWords(new[]{"X....X",
                "X.XX.X",
                "...X..",
                "X.XX.X",
                "..X..."}, 3) == 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue(this.CrossWord.countWords(new[]{"...X...",
                ".X...X.",
                "..X.X..",
                "X..X..X",
                "..X.X..",
                ".X...X.",
                "...X..."}, 3) == 6);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.IsTrue(this.CrossWord.countWords(new[]{".....X....X....",
                ".....X....X....",
                "..........X....",
                "....X....X.....",
                "...X....X....XX",
                "XXX...X....X...",
                ".....X....X....",
                ".......X.......",
                "....X....X.....",
                "...X....X...XXX",
                "XX....X....X...",
                ".....X....X....",
                "....X..........",
                "....X....X.....",
                "....X....X....."}, 5) == 8);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.IsTrue(this.CrossWord.countWords(new[]{"...",
                "...",
                "..."}, 50) == 0);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.IsTrue(this.CrossWord.countWords(new[]
            {"....",
                "....",
                "...."}, 3) == 0);
        }
    }
}
