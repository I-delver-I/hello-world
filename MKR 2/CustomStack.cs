using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MKR_2
{
    public class Stack
    {
        static readonly int maximalSize = 100;
        private int _topPointer = -1;
        private int[] _stack = new int[maximalSize];

        private bool IsEmpty()
        {
            return (_topPointer < 0);
        }

        public bool Push(int data)
        {
            if (_topPointer >= maximalSize)
            {
                return false;
            }
            else
            {
                _stack[++_topPointer] = data;

                return true;
            }
        }
  
        public int Pop()
        {
            if (_topPointer < 0)
            {
                return -1;
            }
            else
            {
                int value = _stack[_topPointer--];
                
                return value;
            }
        }
  
        public int Peek()
        {
            if (_topPointer < 0)
            {
                System.Console.WriteLine("The stack is Underflow");

                return -1;
            }
            else
            {
                System.Console.WriteLine($"The top element of stack: {_stack[_topPointer]}");

                return _stack[_topPointer];
            }
        }
  
        public void Print()
        {
            if (_topPointer < 0)
            {
                Console.WriteLine("Stack Underflow");

                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are:");
                
                for (var i = _topPointer; i >= 0; i--)
                {
                    Console.WriteLine(_stack[i]);
                }
            }
        }
    }
}