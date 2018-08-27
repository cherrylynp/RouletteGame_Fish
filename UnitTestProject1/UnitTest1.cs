using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRandom()
        {
            var test = new Fish();
            Random Random = new Random();
            test.rnd = Random.Next(1, 7);
            Assert.IsTrue(test.rnd >= 1 & test.rnd < 7);
        }

        public void FishtWin()
        {
            var test = new Fish();
            test.count = 2;
            int expectedCount = 2;
            Assert.AreEqual(expectedCount, test.count);

        }
    }

    internal class Fish
    {
        public Fish()
        {


        }

        public int rnd { get; internal set; }
        public int count { get; internal set; }
    }
}
