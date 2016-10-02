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
    public class StringHelpersTests
    {
        [TestMethod]
        public void StringToIntTest()
        {
            Assert.AreEqual(StringHelpers.StringToInt(null), 0);
        }
    }
}