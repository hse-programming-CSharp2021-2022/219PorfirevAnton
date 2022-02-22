using System;
using System.Collections;
namespace Task01
{
    class Fibbonacci : IEnumerable
    {
        int f0 = 1, f1 = 1;
        public IEnumerator GetEnumerator()
        {
            return new FibbonacciEnumerator();
        }
        public IEnumerable NameEnumerator(int n)
        {
            return new FibbonacciEnumerator(n);
        }
        class FibbonacciEnumerator : IEnumerator, IEnumerable
        {
            int f0 = 1, f1 = 1, n;
            int pos = -1;
            public FibbonacciEnumerator(int n = 10)
            {
                this.n = n;
            }
            public object Current => f0;

            public IEnumerator GetEnumerator()
            {
                return this;
            }

            public bool MoveNext()
            {
                if(pos < n - 1)
                {
                    int c = f0;
                    f0 = f1;
                    f1 += c;
                    pos++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                f0 = 1;
                f1 = 1;
                pos = -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fib = new();
            foreach (var elem in fib)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            foreach (var elem in fib.NameEnumerator(7))
            {
                Console.WriteLine(elem);
            }
        }
    }
}
