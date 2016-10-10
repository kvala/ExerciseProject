using ExerciseProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod()]
        public void IsPalindromTest()
        {
            Assert.IsTrue(StringHelpers.IsPalindrom("abcdcba"));
            Assert.IsTrue(StringHelpers.IsPalindrom("abccba"));
            Assert.IsFalse(StringHelpers.IsPalindrom("123"));
            Assert.IsFalse(StringHelpers.IsPalindrom("ab"));

            Assert.IsTrue(StringHelpers.IsPalindrom(null));
        }

        [TestMethod()]
        public void IsTwoStringsAreNgramsTest()
        {
            Assert.IsTrue(StringHelpers.IsTwoStringsAreNgrams("cat", "tac"));
            Assert.IsFalse(StringHelpers.IsTwoStringsAreNgrams("cac", "tac"));
            Assert.IsFalse(StringHelpers.IsTwoStringsAreNgrams("cat", "cac"));

            Assert.IsTrue(StringHelpers.IsTwoStringsAreNgrams("cac", "acc"));
        }
    }
}