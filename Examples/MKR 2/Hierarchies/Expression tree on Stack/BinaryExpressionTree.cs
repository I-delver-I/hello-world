using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree_on_Stack
{
    public class BinaryExpressionTree
    {
        public ExpressionNode<char> Root { get; set; }
        public bool IsEmpty => Root is null;

        public BinaryExpressionTree()
        {
        }

        public BinaryExpressionTree(ExpressionNode<char> root)
        {
            Root = root;
        }

        public void Print(ExpressionNode<char> node, int level = 0)
        {
            if (node != null)
            {
                Print(node.Left, level + 1);
                System.Console.WriteLine($"{new string(' ', level * 5)} -> |{node.Data}|");
                Print(node.Right, level + 1);
            }
        }

        public int Evaluate(ExpressionNode<char> root)
        {
            if (root is null)
            {
                return default;
            }

            if (root.Left is null && root.Right is null)
            {
                return (int)Char.GetNumericValue(root.Data);
            }

            int left = Evaluate(root.Left);
            int right = Evaluate(root.Right);

            switch (root.Data)
            {
                case '+':
                    return left + right;
                case '*':
                    return left * right;
                case '-':
                    return left - right;
                case '/':
                    return left / right;
            }

            return default;
        }

        public static BinaryExpressionTree BuildTreeFromPostfix(string text)
        {
            CustomStack<ExpressionNode<char>> stack = new CustomStack<ExpressionNode<char>>();

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    stack.Push(new ExpressionNode<char>(symbol));
                }
                else
                {
                    ExpressionNode<char> node = new ExpressionNode<char>(symbol);
                    node.Right = stack.Pop();
                    node.Left = stack.Pop();
                    stack.Push(node);
                }
            }

            return new BinaryExpressionTree(stack.Peek());
        }

        public static string InfixToPostfix(string text)
        {
            CustomStack<char> stack = new CustomStack<char>();
            StringBuilder result = new StringBuilder();
            text = text.Replace(" ", "");

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    result.Append(symbol);
                }
                else if (symbol == '(')
                {
                    stack.Push(symbol);
                }
                else if (symbol == ')')
                {
                    char temp = stack.Pop();

                    while (temp != '(' && !stack.IsEmpty)
                    {
                        result.Append(temp);
                        temp = stack.Pop();
                    }
                }
                else if (stack.IsEmpty || stack.Peek() == '(')
                {
                    stack.Push(symbol);
                }
                else
                {
                    while (!stack.IsEmpty)
                    {
                        if (HasPriorityPost(symbol, stack.Peek()))
                        {
                            break;
                        }         

                        result.Append(stack.Pop());               
                    }

                    stack.Push(symbol);
                }
            }

            char tempSymbol = stack.Pop();

            while (tempSymbol != default)
            {
                result.Append(tempSymbol);
                tempSymbol = stack.Pop();
            }

            return result.ToString();
        }

        private static bool HasPriorityPost(char op1, char op2)
        {
            if ("*/".Contains(op1) && "+-".Contains(op2))
            {
                return true;
            }

            if ("()".Contains(op2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PreOrder(ExpressionNode<char> root)
        {
            if (root != null)
            {
                System.Console.Write($"{root.Data} ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        public void PostOrder(ExpressionNode<char> parent)
        {
            if (parent != null)
            {
                PostOrder(parent.Left);
                PostOrder(parent.Right);
                System.Console.Write($"{parent.Data} ");
            }
        }
    }
}