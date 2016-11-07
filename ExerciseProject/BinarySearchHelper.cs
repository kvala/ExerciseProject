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



        /* A recursive function to insert a new key in BST */
        public static Bst DeleteRec(Bst root, int key)
        {
            /* Base Case: If the tree is empty */
            if (root == null)
                return null;

            /* Otherwise, recur down the tree */
            if (key < root.Data)
                root.Left = DeleteRec(root.Left, key);
            else if (key > root.Data)
                root.Right = DeleteRec(root.Right, key);

            // if key is same as root's key, then This is the node
            // to be deleted
            else
            {
                // node with only one child or no child
                if (root.Left == null)
                    return root.Right;
                if (root.Right == null)
                    return root.Left;

                // node with two children: Get the inorder successor (smallest
                // in the Right subtree)
                root.Data = MinValue(root.Right);

                // Delete the inorder successor
                root.Right = DeleteRec(root.Right, root.Data);
            }

            return root;
        }

        public static int MinValue(Bst root)
        {
            int minv = root.Data;
            while (root.Left != null)
            {
                minv = root.Left.Data;
                root = root.Left;
            }
            return minv;
        }


        public static Bst FlippedBinaryTree(Bst root)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Left == null && root.Right == null)
            {
                return root;
            }

            Bst flippedroot = FlippedBinaryTree(root.Left);

            //TODO: This is bug, if there is no left node it will throw exception. Fix it. 
            root.Left.Left = root.Right;
            root.Left.Right = root;

            root.Left = null;
            root.Right = null;


            return flippedroot;
        }




        // Returns the maximum consecutive Path Length
        public static int MaxPathLenUtil(Bst root, int prevVal, int prevLen)
        {
            if (root == null)
                return prevLen;

            // Get the value of Current Node
            // The value of the current node will be
            // prev Node for its left and right children
            int curVal = root.Data;

            // If current node has to be a part of the
            // consecutive path then it should be 1 greater
            // than the value of the previous node
            if (curVal == prevVal + 1)
            {

                // a) Find the length of the Left Path
                // b) Find the length of the Right Path
                // Return the maximum of Left path and Right path
                return Math.Max(MaxPathLenUtil(root.Left, curVal, prevLen + 1),
                           MaxPathLenUtil(root.Right, curVal, prevLen + 1));
            }

            // Find length of the maximum path under subtree rooted with this
            // node (The path may or may not include this node)
            int newPathLen = Math.Max(MaxPathLenUtil(root.Left, curVal, 1),
                                 MaxPathLenUtil(root.Right, curVal, 1));

            // Take the maximum previous path and path under subtree rooted
            // with this node.
            return Math.Max(prevLen, newPathLen);
        }

        // A wrapper over maxPathLenUtil().
        public static int MaxConsecutivePathLength(Bst root)
        {
            // Return 0 if root is NULL
            if (root == null)
                return 0;

            // Else compute Maximum Consecutive Increasing Path
            // Length using maxPathLenUtil.
            return MaxPathLenUtil(root, root.Data - 1, 0);
        }

        //http://www.geeksforgeeks.org/convert-a-binary-tree-to-a-circular-doubly-link-list/
        public static Bst Concatenate(Bst leftList, Bst rightList)
        {
            // If either of the list is empty, then
            // return the other list
            if (leftList == null)
                return rightList;
            if (rightList == null)
                return leftList;

            // Store the last Bst of left List
            Bst leftLast = leftList.Left;

            // Store the last Bst of right List
            Bst rightLast = rightList.Left;

            // Connect the last node of Left List
            // with the first Bst of the right List
            leftLast.Right = rightList;
            rightList.Left = leftLast;

            // left of first node refers to
            // the last node in the list
            leftList.Left = rightLast;

            // Right of last node refers to the first
            // node of the List
            rightLast.Right = leftList;

            // Return the Head of the List
            return leftList;
        }

        // Method converts a tree to a circular
        // Link List and then returns the head
        // of the Link List
        public static Bst BTreeToCList(Bst root)
        {
            if (root == null)
                return null;

            // Recursively convert left and right subtrees
            Bst left = BTreeToCList(root.Left);
            Bst right = BTreeToCList(root.Right);

            // Make a circular linked list of single node
            // (or root). To do so, make the right and
            // left pointers of this node point to itself
            root.Left = root.Right = root;

            // Step 1 (concatenate the left list with the list 
            //         with single node, i.e., current node)
            // Step 2 (concatenate the returned list with the
            //         right List)
            return Concatenate(Concatenate(left, root), right);
        }

        public static void PrintBoundaryLeft(Bst node)
        {
            if (node != null)
            {

                if (node.Left != null)
                {

                    Console.Write(node.Data + " ");
                    PrintBoundaryLeft(node.Left);
                }
                else if (node.Right != null)
                {
                    Console.Write(node.Data + " ");
                    PrintBoundaryLeft(node.Right);
                }
            }

        }

        public static void PrintLeaves(Bst node)
        {
            if (node != null)
            {
                PrintLeaves(node.Left);

                // Print it if it is a leaf node
                if (node.Left == null && node.Right == null)
                    Console.Write(node.Data + " ");
                PrintLeaves(node.Right);
            }
        }

        public static void PrintBoundaryRight(Bst node)
        {
            if (node != null)
            {
                if (node.Right != null)
                {
                    // to ensure bottom up order, first call for right
                    //  subtree, then print this node
                    PrintBoundaryRight(node.Right);
                    Console.Write(node.Data + " ");
                }
                else if (node.Left != null)
                {
                    PrintBoundaryRight(node.Left);
                    Console.Write(node.Data + " ");
                }
                // do nothing if it is a leaf node, this way we avoid
                // duplicates in output
            }
        }


        public static void PrintBoundary(Bst node)
        {
            if (node != null)
            {
                Console.Write(node.Data + " ");

                // Print the left boundary in top-down manner.
                PrintBoundaryLeft(node.Left);

                // Print all leaf nodes
                PrintLeaves(node.Left);
                PrintLeaves(node.Right);

                // Print the right boundary in bottom-up manner
                PrintBoundaryRight(node.Right);
            }
        }

    }
}
