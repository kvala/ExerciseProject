using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Tests
{
    [TestClass]
    public class ThrottlerTests
    {
        [TestMethod]
        public void AllowTest()
        {
            var t = new Throttler();
            string[] strs = { "1", "1" };
            var result = new List<bool>();
            Parallel.ForEach(strs, x =>
            {
                result.Add(t.Allow(x));
            });
            
            //.Any will check if there is any false result.
            Assert.AreEqual(result.Any(d => d == false), true);
        }
    }
}