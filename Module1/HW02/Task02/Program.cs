using System;

namespace Task02
{
    class Program
    {
        static int Max(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            return b;
        }
        static int Min(int a, int b)
        {
            if (a <= b)
            {
                return a;
            }
            return b;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string s1 = Console.ReadLine();
                int.TryParse(s1, out int p);
                int f = p / 100, s = (p / 10) % 10, t = p % 10;
                int sumn = f + s + t;
                int maxn = Max(f, Max(s, t));
                int minn = Min(f, Min(s, t));
                int midn = sumn - maxn - minn;
                Console.WriteLine(maxn * 100 + midn * 10 + minn);
            }
        }
    }
}
