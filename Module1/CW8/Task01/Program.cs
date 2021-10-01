using System;

namespace Task01
{
    class Program
    {
        static int cmp1(int a, int b)
        {
            if (a % 2 == 0)
                return -1;
            return 1;
        }
        static int cmp2(int a, int b)
        {
            int c1 = (a == 0 ? 1 : 1);
            while(a > 0)
            {
                c1++;
                a /= 10;
            }
            int c2 = (b == 0 ? 1 : 1);
            while (b > 0)
            {
                c2++;
                b /= 10;
            }
            if (c2 > c1)
                return -1;
            return 1;
        }
        static int cmp3(int a, int b)
        {
            int c1 = 0;
            while (a > 0)
            {
                c1 += a % 10;
                a /= 10;
            }
            int c2 = 0;
            while (b > 0)
            {
                c1 += b % 10;
                b /= 10;
            }
            if (c2 > c1)
                return -1;
            return 1;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] a = new int[n];
            for(int i = 0; i < n; ++i)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(0, 1001);
            }
            Array.ForEach(a, elem => Console.Write(Convert.ToString(elem) + " "));
            Array.Sort(a, cmp1);
            Array.ForEach(a, elem => Console.Write(Convert.ToString(elem) + " "));
            Array.Sort(a, cmp2);
            Array.ForEach(a, elem => Console.Write(Convert.ToString(elem) + " "));
            Array.Sort(a, cmp3);
            Array.ForEach(a, elem => Console.Write(Convert.ToString(elem) + " "));
        }
    }
}
