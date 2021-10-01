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
            int k = rnd.Next(0, 100);
            int[] a = new int[99];
            int[] pr = { 53, 59, 61, 67, 71, 73, 79, 83 };
            int ip = rnd.Next(0, 8);
            int rp = pr[ip];
            for (int i = 0; i < 99; ++i)
            {
                a[i] = k + 1;
                k = (k + rp) % 100;
            }
            int s = 0;
            for(int i = 0; i < 99; ++i)
            {
                s += a[i];
            }
            //Print(a);
            Console.WriteLine(5050 - s);
        }
    }
}
