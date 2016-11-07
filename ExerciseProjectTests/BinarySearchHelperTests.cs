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

        [TestMethod()]
        public void DeleteRecTest()
        {
            Bst n100 = new Bst(100);


            Bst n175 = new Bst(175);
            Bst n75 = new Bst(75);

            Bst n25 = new Bst(25);

            n100.Left = n75;
            n100.Right = n175;

            n75.Left = n25;

            var node = BinarySearchHelper.DeleteRec(n100, 25);






        }

        [TestMethod]
        public void FlippedBinaryTreeTest()
        {
            Bst n1 = new Bst(1);

            Bst n2 = new Bst(2);
            Bst n3 = new Bst(3);

            Bst n4 = new Bst(4);

            Bst n5 = new Bst(5);

            Bst n6 = new Bst(6);

            Bst n7 = new Bst(7);

            n1.Left = n2;
            n1.Right = n3;

            n2.Left = n4;
            n2.Right = n5;

            n3.Left = n6;
            n3.Right = n7;

            var flippedroot = BinarySearchHelper.FlippedBinaryTree(n1);

            Assert.AreEqual(4, flippedroot.Data);

            //it fails for this condition. We need to figure it out expected output and fix code.

            Bst t2n1 = new Bst(1);

            Bst t2n2 = new Bst(2);


            t2n1.Right = t2n2;

            //var flippedroott2 = BinarySearchHelper.FlippedBinaryTree(t2n1);

        }

        [TestMethod()]
        public void MaxConsecutivePathLengthTest()
        {
            Bst n10 = new Bst(10);
            Bst n11 = new Bst(11);
            Bst n9 = new Bst(9);
            Bst n12 = new Bst(12);
            Bst n13 = new Bst(13);

            Bst n8 = new Bst(8);

            Bst n1 = new Bst(1);

            Bst n2 = new Bst(2);
            Bst n3 = new Bst(3);
            Bst n4 = new Bst(4);

            n10.Left = n11;
            n10.Right = n9;

            n11.Left = n1;
            n11.Right = n12;

            n9.Left = n13;
            n9.Right = n8;

            n1.Right = n2;
            n2.Right = n3;
            n3.Right = n4;

            var count = BinarySearchHelper.MaxConsecutivePathLength(n10);

            Assert.AreEqual(4, count);

        }


        [TestMethod()]
        public void BTreeToCListTest()
        {
            Bst n1 = new Bst(1);

            Bst n2 = new Bst(2);
            Bst n3 = new Bst(3);

            Bst n4 = new Bst(4);
            Bst n5 = new Bst(5);
            Bst n6 = new Bst(6);


            n1.Left = n2;
            n1.Right = n3;

            n2.Left = n4;
            n2.Right = n5;

            n3.Left = n6;



            var linkedlist = BinarySearchHelper.BTreeToCList(n1);
        }

        [TestMethod()]
        public void PrintBoundaryTest()
        {
            Bst n1 = new Bst(1);

            Bst n2 = new Bst(2);
            Bst n3 = new Bst(3);

            Bst n4 = new Bst(4);
            Bst n5 = new Bst(5);
            Bst n6 = new Bst(6);


            n1.Left = n2;
            n1.Right = n3;

            n2.Left = n4;
            n2.Right = n5;

            n3.Left = n6;



             BinarySearchHelper.PrintBoundary(n1);
        }
    }
}