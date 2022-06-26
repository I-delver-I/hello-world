using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class BinaryTree
    {
        public TreeNode Root { get; set; }
        
        public BinaryTree(TreeNode root)
        {
            Root = root;
        }

        public TreeNode RemoveNode(int key, TreeNode root)
        {
            if (root == null)
            {
                return root;
            }

            if (key < root.Number)
            {
                root.LeftNode = RemoveNode(key, root.LeftNode);
            }
            else if (key > root.Number)
            {
                root.RightNode = RemoveNode(key, root.RightNode);
            }
            else
            {
                if (root.LeftNode == null)
                {
                    return root.RightNode;
                }
                else if (root.RightNode == null)
                {
                    return root.LeftNode;
                }

                root.Number = GetMinValue(root.RightNode);
                root.RightNode = RemoveNode(root.Number, root.RightNode);
            }

            return root;
        }

        private int GetMinValue(TreeNode root)
        {
            int minValue = root.Number;

            while (root.LeftNode != null)
            {
                minValue = root.LeftNode.Number;
                root = root.LeftNode;
            }

            return minValue;
        }

        public TreeNode FindNode(TreeNode nodeToFind, TreeNode root)
        {
            TreeNode current = root;

            if (current == null)
            {
                return null;
            }

            if (nodeToFind.Number == current.Number)
            {
                return current;
            }
            
            if (nodeToFind.Number < current.Number)
            {
                return FindNode(nodeToFind, current.LeftNode);
            }
            else
            {
                return FindNode(nodeToFind, current.RightNode);
            }
        }

        public void AddNode(TreeNode nodeToAdd, TreeNode root)
        {
            TreeNode current = root;
            
            if (current.Number > nodeToAdd.Number)
            {
                if (current.LeftNode == null)
                {
                    current.LeftNode = nodeToAdd;
                }
                else
                {
                    AddNode(nodeToAdd, current.LeftNode);
                }
            }
            else
            {
                if (current.RightNode == null)
                {
                    current.RightNode = nodeToAdd;
                }
                else
                {
                    AddNode(nodeToAdd, current.RightNode);
                }
            }
        }

        public void PreOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                System.Console.WriteLine($"{root.Number} ");
                PreOrderTraversal(root.LeftNode);
                PreOrderTraversal(root.RightNode);
            }
        }
    }
}