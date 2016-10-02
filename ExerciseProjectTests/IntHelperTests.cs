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
    public class IntHelperTests
    {
        [TestMethod()]
        public void ArrangeNumbersToFormBiggestNumberTest()
        {
            List<string> s = new List<string> { "54", "546", "548", "60" };
            Assert.AreEqual("6054854654", IntHelper.ArrangeNumbersToFormBiggestNumber(s));
        }
    }
}