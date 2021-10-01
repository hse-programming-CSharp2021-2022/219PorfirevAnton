using System;

namespace Task02
{
    class Program
    {
        static void Print(int[] a)
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
            Random rnd = new Random();
            int[] a = new int[100];
            for (int i = 0; i < 100; ++i)
            {
                a[i] = i + 1;
            }
            for (int i = 0; i < 60; ++i)
            {
                int q = rnd.Next(0, 100);
                a[i] = a[i] ^ a[q];
                a[q] = a[q] ^ a[i];
                a[i] = a[i] ^ a[q];
            }
            int k = rnd.Next(0, 100);
            int p = rnd.Next(0, 100);
            while(k == p)
            {
                k = rnd.Next(0, 100);
                p = rnd.Next(0, 100);
            }
            Print(a);
            a[k] = a[p];
            Array.Sort(a);
            Print(a);
            //while (s != 0)
            //{
            //s ^= a[j];
            //++j;
            //}
            //Print(a);
            //Console.WriteLine(a[j]);
        }
    }
}
