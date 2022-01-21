using System;

namespace Task02
{
    static class A
    {
        static public void NewString()
        {
            Console.WriteLine();
        }
        static public void Print(int[,] a)
        {
            for(int i = 0; i < a.Length; ++i)
            {
                for(int j = 0; j < a.GetLength(1); ++j)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
