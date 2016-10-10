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
    public class NodeHelperTests
    {
        [TestMethod()]
        public void ReverseLinkListTest()
        {

            Assert.IsNull(NodeHelper.ReverseLinkList(null));

            Node n1 = new Node(1);

            Assert.IsNull(NodeHelper.ReverseLinkList(null));

            Node n = NodeHelper.ReverseLinkList(n1);
            Assert.AreEqual(n, n1);

            Node n2 = new Node(2);
            n1.NextNode = n2;

            Node nout2 = NodeHelper.ReverseLinkList(n1);


            Assert.AreEqual(nout2.NextNode.Data, 1);
            Assert.AreEqual(nout2.Data, 2);
        }

        [TestMethod()]
        public void NthNodeTest()
        {
            Node n1 = new Node(1);

            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);


            n1.NextNode = n2;
            n2.NextNode = n3;
            n3.NextNode = n4;
            n4.NextNode = n5;

            Assert.AreEqual(3, NodeHelper.NthNode(n1, 3).Data);

            Assert.AreEqual(null, NodeHelper.NthNode(n1, 6));

            Assert.AreEqual(1, NodeHelper.NthNode(n1, 5).Data);
            Assert.AreEqual(5, NodeHelper.NthNode(n1, 1).Data);

            Node p1 = new Node(1);

            Assert.AreEqual(1, NodeHelper.NthNode(p1, 1).Data);


            Assert.AreEqual(null, NodeHelper.NthNode(null, 1));

            Assert.AreEqual(null, NodeHelper.NthNode(null, 10));


        }
    }
}