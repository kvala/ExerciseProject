using System;
using System.Collections.Generic;

namespace TempTest
{
    class Program
    {
        public static Stack<Tree> s = new Stack<Tree>();
        static void Main(string[] args)
        {
            //Tree n1 = new Tree(26);
            //Tree n2 = new Tree(12);
            //Tree n3 = new Tree(14);
            //n1.left = n2;
            //n1.right = n3;

            //Tree n4 = new Tree(5);
            //n2.left = n4;
            //var n5 = new Tree(7);
            //n2.right = n5;

            //Tree n6 = new Tree(4);
            //n3.left = n6;
            //Tree n7 = new Tree(10);
            //n3.right = n7;

            //Tree n8 = new Tree(10);
            //n7.right = n8;

            ////Console.Write(IsSumTree(n1));
            ////Console.Write(IsSumTree(n8));
            //Console.Write(SumTree(n1));

            //var l1 = new ListWithChild(1);

            // var l2 = new ListWithChild(2);
            // var l3 = new ListWithChild(3);
            // var l4 = new ListWithChild(4);
            // var l5 = new ListWithChild(5);
            // var l6 = new ListWithChild(6);

            // var l8 = new ListWithChild(8);

            // l1.NextChild = l2;
            // l2.PreChild = l1;


            // l2.NextChild = l3;
            // l3.PreChild = l2;
            // l2.Child = l5;


            // l3.NextChild = l4;
            // l4.PreChild = l3;

            // l5.NextChild = l6;
            // l5.Child = l8;
            // l6.PreChild = l5;


            //var returntail =  ListWithChildArray.FlattenList(l1, l4);

            // Console.WriteLine(returntail.Data);


            //var n1 = new Node(1);

            //var n2 = new Node(2);
            //var n3 = new Node(3);
            //var n4 = new Node(4);

            //n1.NextNode = n2;
            //n2.NextNode = n3;
            //n3.NextNode = n4;
            ////n4.NextNode = n2;

            //Console.WriteLine(NodeHelper.IsCyclic(n1));

            //var n100 = new Bst(100);

            //var n50 = new Bst(50);
            //var n25 = new Bst(25);
            //var n150 = new Bst(150);

            //n100.Left = n50;
            //n100.Right = n150;

            //n50.Left = n25;



            //BinarySearchHelper.PreOrderTraversalUsingStack(n100);


            //Console.Out.WriteLine(StringHelpers.FindFirstNonRepeatingCharacter("K K"));

            //Console.Out.WriteLine(StringHelpers.RemoveChars("ketan", "e"));


            // Console.WriteLine(StringHelpers.ReverseWord("ketan"));

            //string input = "ketan";

            //char[] i = input.ToCharArray();
            //StringHelpers.ReverseWordChar(i);

            //Console.Out.WriteLine(i);

            //string input = "ketan vala";

            //char[] i = input.ToCharArray();
            //StringHelpers.ReverseWordInString(i);

            //Console.Out.WriteLine(i);


            //Console.Out.WriteLine(StringHelpers.FormatString("abcdef",5,5));

            //int[] a = { 1, 2, 5 };
            //int[] b = { 2, 5 };
            //StringHelpers.MultiplyTwoNumber(a, b);


            //int[][] array2D = {new [] { 1, 2 }, new [] { 3, 4 }, new []{ 5, 6 }, new [] { 7, 8 } };
            //StringHelpers.PrintMatrix(array2D);


            //Console.WriteLine(StringHelpers.StringToInt("100032200113344"));

            //Console.WriteLine(long.MaxValue);

            //Console.WriteLine(int.MaxValue);
            //Console.ReadKey();


            Throttler t = new Throttler();

           Console.Out.WriteLine(t.Allow("1"));
            Console.Out.WriteLine(t.Allow("1"));



        }



        public static int SumTree(Tree node)
        {
            if (node == null)
                return 0;

            int nodeValue = node.Value;
            node.Value = SumTree(node.Left) + SumTree(node.Right);


            return nodeValue + node.Value;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool IsSumTree(Tree root)
        {
            if (root == null)
                return true;

            s.Push(root);
            while (s.Count > 0)
            {
                Tree n = s.Pop();
                if (n.Left == null && n.Right == null)
                {
                    continue;
                }
                int sum = 0;
                if (n.Left != null)
                {
                    s.Push(n.Left);
                    sum += n.Left.Value;
                }

                if (n.Right != null)
                {
                    s.Push(n.Right);
                    sum += n.Right.Value;
                }

                if (n.Value != sum)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
