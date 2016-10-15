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

        [TestMethod()]
        public void RearrangePositiveAndNegativeTest()
        {
            int[] input = { 1, -2, -3, 4, 5, 6, 7, 8, -9 };

            CollectionAssert.AreEqual(IntHelper.RearrangePositiveAndNegative(input), input);
        }

        [TestMethod()]
        public void PrintDuplicateInArrayTest()
        {
            int[] input = { -9, -9, 1, 1, 1, 4, 4, 6, 7, 8, 10, 11, 15, 15 };
            IntHelper.PrintDuplicateInArray(input);
        }

        [TestMethod()]
        public void IndexOfRotatedArrayTest()
        {
            int[] input = { 4, 5, 1, 2, 3 };
            Assert.AreEqual(1, IntHelper.IndexOfRotatedArray(input));


            int[] input2 = { 5, 1, 2, 3, 4 };
            Assert.AreEqual(1, IntHelper.IndexOfRotatedArray(input2));

            int[] input3 = { 3, 4, 5, 1, 2 };
            Assert.AreEqual(1, IntHelper.IndexOfRotatedArray(input3));
        }

        [TestMethod()]
        public void RemoveDuplicateFromSortedArrayTest()
        {

            Assert.AreEqual(6, IntHelper.RemoveDuplicateFromSortedArray(new[] { 1, 1, 2, 3, 4, 4, 5, 6, 6 }).Length);


            Assert.AreEqual(1, IntHelper.RemoveDuplicateFromSortedArray(new[] { 1, 1 }).Length);


            Assert.AreEqual(3, IntHelper.RemoveDuplicateFromSortedArray(new[] { 1, 2, 3 }).Length);

            Assert.IsNull(IntHelper.RemoveDuplicateFromSortedArray(null));
        }

        //need to write more test cases
        [TestMethod()]
        public void SubArraySumTest()
        {
            int[] arr = { 10, 2, -2, -20, 10 };
            IntHelper.SubArraySum(arr, arr.Length, -22);
        }

        [TestMethod()]
        public void MergeTwoSortedArraysTest()
        {


            CollectionAssert.AreEqual(new[] { 1, 2, 2, 3, 5, 10, 100, 1000, 10000 },
                IntHelper.MergeTwoSortedArrays(new[] { 1, 2, 3, 100 }, new[] { 2, 5, 10, 1000, 10000 }));



            CollectionAssert.AreEqual(new[] { 1, 2, 5, 10, 1000, 10000 },
                IntHelper.MergeTwoSortedArrays(new[] { 1 }, new[] { 2, 5, 10, 1000, 10000 }));

        }

        [TestMethod()]
        public void LargeNumberTest()
        {
            Assert.AreEqual(742, IntHelper.LargeNumber(427));

            Assert.AreEqual(744, IntHelper.LargeNumber(474));

            Assert.AreEqual(321, IntHelper.LargeNumber(132));

            Assert.AreEqual(210, IntHelper.LargeNumber(102));

            //what should be output? 1 or 100?
            Assert.AreEqual(1, IntHelper.LargeNumber(001));

            Assert.AreEqual(1, IntHelper.LargeNumber(-321));
        }
    }
}