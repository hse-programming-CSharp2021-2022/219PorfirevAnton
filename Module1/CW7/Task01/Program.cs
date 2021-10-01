using System;

namespace Task01
{
    class Program
    {
        static void Print(char[] a)
        {
            for (int i = 0; i < a.Length; ++i)
            {
                Console.Write(a[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int k);
            char[] a = new char[k];
            char[] copy = new char[k];
            for (int i = 0; i < k; ++i)
            {
                Random rnd = new Random();
                a[i] = (char)rnd.Next('A', 'Z' + 1);
            }
            Print(a);
            Array.Copy(a, copy, k);
            Array.Sort(a);
            Array.Reverse(a);
            Print(a);
        }
    }
}
