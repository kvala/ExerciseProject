using ExerciseProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExerciseProject.Tests
{
    [TestClass]
    public class BinarySearchHelperTests
    {

        [TestMethod]
        public void IsBstTest()
        {
            Bst n5 = new Bst(5);
            Bst n3 = new Bst(3);
            Bst n2 = new Bst(2);
            Bst n9 = new Bst(9);
            Bst n7 = new Bst(7);

            n5.Left = n3;
            n5.Right = n7;

            n3.Left = n2;
            n3.Right = n9;



            Assert.IsFalse(BinarySearchHelper.IsBst(n5));
        }

        [TestMethod]
        public void MaxDepthTest()
        {
            Bst n5 = new Bst(5);
            Bst n3 = new Bst(3);
            Bst n2 = new Bst(2);
            Bst n9 = new Bst(9);
            Bst n7 = new Bst(7);

            n5.Left = n3;
            n5.Right = n7;

            n3.Left = n2;
            n3.Right = n9;

            Assert.AreEqual(BinarySearchHelper.MaxDepth(n5), 3);

            Assert.AreEqual(BinarySearchHelper.MaxDepth(null), 0);

            var n = new Bst(10);
            Assert.AreEqual(BinarySearchHelper.MaxDepth(n), 1);

        }
    }
}