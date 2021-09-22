using System;

namespace Task01
{
    class Program
    {
        static void Sum(int n, out int s1, out int s2)
        {
            s1 = 0;
            s2 = 0;
            int i = 0;
            while (n > 0)
            {
                s1 += (i % 2 == 0 ? n % 10 : 0);
                s2 += (i % 2 != 0 ? n % 10 : 0);
                n /= 10;
                ++i;
            }
        }
        static void Main(string[] args)
        {
            int s1 = 0, s2 = 0;
            int.TryParse(Console.ReadLine(), out int n);
            Sum(n, out s1, out s2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
