using System;
using System.Collections.Generic;

namespace ExerciseProject
{
    public class BinarySearchHelper
    {
        public static void PreOrderTraversalUsingStack(Bst root)
        {
            var stack = new Stack<Bst>();
            if (root == null)
            {
                return;
            }

            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                Console.Out.WriteLine(node.Data);

                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
        }

        public static bool IsBst(Bst root)
        {
            return IsBstUtility(root, int.MinValue, int.MaxValue);


        }

        public static bool IsBstUtility(Bst root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.Data < min || root.Data > max)
            {
                return false;
            }

            return (IsBstUtility(root.Left, min, root.Data - 1)
                && IsBstUtility(root.Right, root.Data + 1, max));
        }

        public static int MaxDepth(Bst node)
        {
            if (node == null)
                return 0;

            /* compute the depth of each subtree */
            int lDepth = MaxDepth(node.Left);
            int rDepth = MaxDepth(node.Right);

            /* use the larger one */
            if (lDepth > rDepth)
                return (lDepth + 1);

            return (rDepth + 1);
        }

      
    }
}
