using System;
using System.Collections;
namespace Task01
{
    class Fibbonacci : IEnumerable
    {
        int f0 = 1, f1 = 1;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
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
    class TriangleNums : IEnumerable
    {
        int num = 1;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
            {
                yield return num;
                num += (i + 2);
            }
        }
        public IEnumerable NameEnumerator(int n)
        {
            for (int i = 0; i < n; ++i)
            {
                yield return num;
                num += (i + 2);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fibbonacci fib = new();
            TriangleNums nums = new();
            int m = 8;
            int[] ans = new int[m];
            int i = 0;
            foreach (var elem in fib.NameEnumerator(m))
            {
                Console.WriteLine(elem);
                ans[i] = (int)elem;
                i++;
            }
            Console.WriteLine();
            i = 0;
            foreach (var elem in nums.NameEnumerator(m))
            {
                Console.WriteLine(elem);
                ans[i] += (int)elem;
                i++;
            }
            Console.WriteLine();
            foreach(var elem in ans)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
