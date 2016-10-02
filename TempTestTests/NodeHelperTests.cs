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
            Assert.AreEqual(n,n1);

            Node n2 = new Node(2);
            n1.NextNode = n2;

            Node nout2 = NodeHelper.ReverseLinkList(n1);

            
            Assert.AreEqual(nout2.NextNode.Data, 1);
            Assert.AreEqual(nout2.Data, 2);
        }
    }
}