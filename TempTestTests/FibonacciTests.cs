using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempTest.Tests
{
    [TestClass()]
    public class FibonacciTests
    {
        [TestMethod()]
        public void FibRecursiveTest()
        {
            Assert.AreEqual(Fibonacci.FibRecursive(-1), 1);
            Assert.AreEqual(Fibonacci.FibItr(-1), 1);

            Assert.AreEqual(Fibonacci.FibRecursive(0), 1);
            Assert.AreEqual(Fibonacci.FibItr(0), 1);

            Assert.AreEqual(Fibonacci.FibRecursive(1), 1);
            Assert.AreEqual(Fibonacci.FibItr(1), 1);

            Assert.AreEqual(Fibonacci.FibRecursive(5), 8);
            Assert.AreEqual(Fibonacci.FibItr(5), 8);
        }
    }
}