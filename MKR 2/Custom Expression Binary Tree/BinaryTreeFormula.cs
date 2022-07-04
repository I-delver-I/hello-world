using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Expression_Binary_Tree
{
    public class BinaryTreeFormula
    {
        public FormulaNode Root;

        public bool IsEmpty => Root is null;

        public BinaryTreeFormula()
        {
            
        }

        public BinaryTreeFormula(FormulaNode root)
        {
            Root = root;
        }

        public void Print(FormulaNode node, int level = 0)
        {
            if (node != null)
            {
                Print(node.Left, level + 1);
                System.Console.WriteLine($"{new string(' ', level * 5)} -> |{node.Data}|");
                Print(node.Right, level + 1);
            }
        }

        public int Evaluate(FormulaNode root)
        {
            if (root is null)
            {
                return 0;
            }

            if (root.Left is null && root.Right is null)
            {
                return (int)char.GetNumericValue(root.Data);
            }

            int left = Evaluate(root.Left);
            int right = Evaluate(root.Right);

            if (root.Data == '+')
            {
                return left + right;
            }
            else if (root.Data == '*')
            {
                return left * right;
            }
            else if (root.Data == '-')
            {
                return left - right;
            }
            else if (root.Data == '/')
            {
                return left / right;
            }

            return 0;
        }

        public void InOrder(FormulaNode root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                System.Console.WriteLine($"{root.Data} ");
                InOrder(root.Right);
            }
        }

        public void PreOrder(FormulaNode root)
        {
            if (root != null)
            {
                System.Console.Write($"{root.Data} ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        public void PostOrder(FormulaNode root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                System.Console.WriteLine($"{root.Data} ");
            }
        }

        public static BinaryTreeFormula BuildTreeFromPostfix(string text)
        {
            CustomStack<FormulaNode> stack = new CustomStack<FormulaNode>();

            foreach (char symbol in text)
            {
                if (char.IsDigit(symbol))
                {
                    stack.Push(new FormulaNode(symbol));
                }
                else
                {
                    FormulaNode node = new FormulaNode(symbol);
                    node.Right = stack.Pop();
                    node.Left = stack.Pop();
                    stack.Push(node);
                }
            }

            return new BinaryTreeFormula(stack.Peek());
        }

        public static string InfixToPostfix(string text)
        {
            CustomStack<char> stack = new CustomStack<char>();
            StringBuilder result = new StringBuilder();
            text = text.Replace(" ", "");
            
            foreach (char symbol in text)
            {
                //string str = symbol.ToString();

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
    }
}