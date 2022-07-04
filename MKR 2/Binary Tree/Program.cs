using System;

namespace Binary_Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = BinaryTreeCapturers.CaptureBinaryTree();
            tree.Print(tree.Root);
        }
    }
}