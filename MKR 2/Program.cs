using System;

namespace MKR_2
{
    public class Program
    {    
        public static void Main(string[] args)
        {
            BinaryTree tree = CaptureBinaryTree();
            System.Console.WriteLine("Tree PreOrder traversal:");
            tree.PreOrderTraversal(tree.Root);
            System.Console.Write("Choose value of node to remove: ");
            tree.RemoveNode(int.Parse(Console.ReadLine()), tree.Root);
            System.Console.WriteLine("Tree PreOrder traversal after deletion:");
            tree.PreOrderTraversal(tree.Root);
        }

        static BinaryTree CaptureBinaryTree()
        {
            System.Console.WriteLine("Capture the root of tree:");
            BinaryTree tree = new BinaryTree(CaptureNode());
            System.Console.WriteLine("Capture the other nodes of tree:");

            do
            {
                tree.AddNode(CaptureNode(), tree.Root);
                System.Console.WriteLine("Enter <Backspace to end typing> or any key to continue");
            }
            while (Console.ReadKey().Key != ConsoleKey.Backspace);

            return tree;
        }

        static Node CaptureNode()
        {
            bool exceptionIsCaught = true;
            Node result = null;

            while (exceptionIsCaught)
            {
                exceptionIsCaught = false;

                try
                {
                    System.Console.Write("Please, enter the node data (number): ");
                    result = new Node(int.Parse(Console.ReadLine()));
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("You entered not a number. Try again");
                    exceptionIsCaught = true;
                }
            }

            return result;
        }
    }
}