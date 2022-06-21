using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        
        public BinaryTree(Node root)
        {
            Root = root;
        }

        public Node RemoveNode(int key, Node root)
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

        private int GetMinValue(Node root)
        {
            int minValue = root.Number;

            while (root.LeftNode != null)
            {
                minValue = root.LeftNode.Number;
                root = root.LeftNode;
            }

            return minValue;
        }

        public Node FindNode(Node nodeToFind, Node root)
        {
            Node current = root;

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

        public void AddNode(Node nodeToAdd, Node root)
        {
            Node current = root;
            
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

        public void PreOrderTraversal(Node root)
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