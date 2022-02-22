using System;
using System.Collections;
namespace Task01
{
    class Fibbonacci : IEnumerable
    {
        int f0 = 1, f1 = 1;
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < 10; ++i)
            {
                yield return f0;
                int c = f0;
                f0 = f1;
                f1 += c;
            }
        }
        public IEnumerable NameEnumerator(int n)
        {
            int f0 = 1, f1 = 1;
            for (int i = 0; i < n; ++i)
            {
                yield return f0;
                int c = f0;
                f0 = f1;
                f1 += c;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fib = new();
            foreach(var elem in fib)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            foreach(var elem in fib.NameEnumerator(7))
            {
                Console.WriteLine(elem);
            }
        }
    }
}
