using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LearningCSharp
{
    [TestClass]
    public class KarateChopTests
    {
        [TestMethod]
        public void ChopChop()
        {
            // Based on Code Kata #2 by Prag Dave at http://codekata.pragprog.com/2007/01/kata_two_karate.html
            Assert.AreEqual(-1, new KarateChop().Chop(3, new int[] {}));
            Assert.AreEqual(-1, new KarateChop().Chop(3, new int[] {1}));
            Assert.AreEqual(0, new KarateChop().Chop(1, new int[] {1}));
            Assert.AreEqual(0,  new KarateChop().Chop(1, new int[] {1, 3, 5}));
            Assert.AreEqual(1,  new KarateChop().Chop(3, new int[] {1, 3, 5}));
            Assert.AreEqual(2,  new KarateChop().Chop(5, new int[] {1, 3, 5}));
            Assert.AreEqual(-1, new KarateChop().Chop(0, new int[] {1, 3, 5}));
            Assert.AreEqual(-1, new KarateChop().Chop(2, new int[] {1, 3, 5}));
            Assert.AreEqual(-1, new KarateChop().Chop(4, new int[] {1, 3, 5}));
            Assert.AreEqual(-1, new KarateChop().Chop(6, new int[] {1, 3, 5}));
            Assert.AreEqual(0,  new KarateChop().Chop(1, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(1,  new KarateChop().Chop(3, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(2,  new KarateChop().Chop(5, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(3,  new KarateChop().Chop(7, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, new KarateChop().Chop(0, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, new KarateChop().Chop(2, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, new KarateChop().Chop(4, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, new KarateChop().Chop(6, new int[] {1, 3, 5, 7}));
            Assert.AreEqual(-1, new KarateChop().Chop(8, new int[] {1, 3, 5, 7}));
        }
    }
}
