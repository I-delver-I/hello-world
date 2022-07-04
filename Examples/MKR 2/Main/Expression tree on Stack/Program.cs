using System;

namespace Expression_tree_on_Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            D4 d4 = new D4(new D2("3+2", "23*6+1", "2+2/2", new B1("8/2*(3-1)"), new B3("6+1-5"), 
                new D3("66+369", "5+25/25")), "6+(8-1)");

            string[] expressions = new string[] { d4.PropD4 };
            string postfix = BinaryExpressionTree.InfixToPostfix(expressions[0]);
            BinaryExpressionTree tree = BinaryExpressionTree.BuildTreeFromPostfix(postfix);
            System.Console.WriteLine($"The binary expression tree:");
            tree.Print(tree.Root);
            System.Console.WriteLine($"The result of evaluation: {tree.Evaluate(tree.Root)}");
            System.Console.WriteLine("Expression in Poland type:");
            tree.PostOrder(tree.Root);
        }
    }
}