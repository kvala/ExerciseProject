using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    public class NodeHelper
    {
        public static Node InsertElement(Node inputNode, int data)
        {
            return null;
        }

        public static bool IsCyclic(Node head)
        {

            var slowNode = head;

            if (head?.NextNode == null)
            {
                return false;
            }

            var fastNode = head.NextNode;

            while (true)
            {
                if (fastNode?.NextNode == null)
                {
                    return false;
                }
                if (fastNode == slowNode || fastNode.NextNode == slowNode)
                {
                    return true;

                }
                slowNode = slowNode.NextNode;
                fastNode = fastNode.NextNode.NextNode;
            }
        }


        public static Node ReverseLinkListOld(Node head)
        {
            if (head == null)
            {
                return null;
            }
            Node p = null;
            Node c = head;

            if (head.NextNode == null)
            {
                return head;
            }

            Node n = head.NextNode;

            while (c != null)
            {
                c.NextNode = p;
                p = c;
                c = n;
                n = c.NextNode;
            }

            return c;
        }

        public static Node ReverseLinkList(Node node)
        {
            Node prev = null;
            Node current = node;
            Node next = null;
            while (current != null)
            {
                next = current.NextNode;
                current.NextNode = prev;
                prev = current;
                current = next;
            }
            node = prev;
            return node;
        }


        public static Node NthNode(Node head, int n)
        {
            Node current = head;
            for (int i = 1; i < n; i++)
            {
                if (current != null && current.NextNode != null)
                {
                    current = current.NextNode;
                }
                else
                {
                    return null;
                }
            }

            Node nthNode = head;

            while (current != null && current.NextNode != null)
            {
                current = current.NextNode;
                nthNode = nthNode.NextNode;
            }


            return nthNode;

        }

        public static void PrintLinkedListReverse(Node node)
        {
            if (node == null)
            {
                return;
            }

            if (node.NextNode != null)
            {
                PrintLinkedListReverse(node.NextNode);
            }

            Console.Out.WriteLine(node.Data);
        }
    }
}
