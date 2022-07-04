using System;

namespace Custom_Expression_Binary_Tree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string postfix = BinaryTreeFormula.InfixToPostfix("3+1*(9+3)");
            BinaryTreeFormula tree = BinaryTreeFormula.BuildTreeFromPostfix(postfix);
            tree.Print(tree.Root);
            
            System.Console.WriteLine($"The result of expression is: {tree.Evaluate(tree.Root)}");
            tree.PreOrder(tree.Root);
        }
    }
}