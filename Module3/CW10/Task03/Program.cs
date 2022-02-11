using System;
using System.Collections.Generic;


namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            for(int i = 0; i < 10; ++i)
            {
                stack.Push(i);
                queue.Enqueue(i);
            }
            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine(stack.Peek());
            }
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(queue.Peek());
            }
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(stack.Pop());
            }
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
