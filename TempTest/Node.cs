using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempTest
{
    public class Node
    {
       public Node NextNode;
        public int Data;

        public Node(int value)
        {
            this.Data = value;
        }
    }
}
