using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 134221905 & 511;
            x = 413354 & 7;

            x = 130 & 3;

            Console.WriteLine(x);

            FindDepth();

            AddTwoLinkedNumbers();

            Console.Read();
        }

        private static void AddTwoLinkedNumbers()
        {
            /*
             * You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

                You may assume the two numbers do not contain any leading zero, except the number 0 itself.

                Example:

                Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
                Output: 7 -> 0 -> 8
                Explanation: 342 + 465 = 807.
             * */
            LinkNode node1 = new LinkNode();
            node1.Item = 2;

            node1.NextNode = new LinkNode();
            node1.NextNode.Item = 4;

            node1.NextNode.NextNode = new LinkNode();
            node1.NextNode.NextNode.Item = 3;

            LinkNode node2 = new LinkNode();
            node2.Item = 5;

            node2.NextNode = new LinkNode();
            node2.NextNode.Item = 6;

            node2.NextNode.NextNode = new LinkNode();
            node2.NextNode.NextNode.Item = 4;

            string num1 = new string(FindNumber(node1, string.Empty).ToCharArray().Reverse().ToArray());
            string num2 = new string(FindNumber(node2, string.Empty).ToCharArray().Reverse().ToArray());

            int result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
        }

        private static string FindNumber(LinkNode node1, string nodeItem)
        {
            if(node1 == null)
            {
                if (string.IsNullOrEmpty(nodeItem))
                {
                    return "0";
                }
                else
                {
                    return nodeItem;
                }
            }
            else
            {
                nodeItem = nodeItem + node1.Item.ToString();
            }

            nodeItem = FindNumber(node1.NextNode, nodeItem);

            return nodeItem;
        }

        private static void FindDepth()
        {
            Tree tree = new Tree();
            tree.TreeId = 1;
            tree.LeftTreeNode = new Tree();
            tree.LeftTreeNode.TreeId = 2;
            tree.LeftTreeNode.LeftTreeNode = new Tree();
            tree.LeftTreeNode.LeftTreeNode.TreeId = 3;
            tree.LeftTreeNode.LeftTreeNode.RightTreeNode = new Tree();
            tree.LeftTreeNode.LeftTreeNode.RightTreeNode.TreeId = 4;
            tree.LeftTreeNode.RightTreeNode = new Tree();
            tree.LeftTreeNode.RightTreeNode.TreeId = 5;

            var val = FindDepthTred(tree);

            Console.WriteLine(val);
        }

        private static int FindDepthTred(Tree treeNode)
        {
            if(treeNode == null)
            {
                return 0;
            }

            var leftNode = FindDepthTred(treeNode.LeftTreeNode);
            var rightNode = FindDepthTred(treeNode.RightTreeNode);
            var maxValue = Math.Max(leftNode, rightNode);
            return maxValue + 1;
        }
    }
}
