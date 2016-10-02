using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExerciseProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject.Tests
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