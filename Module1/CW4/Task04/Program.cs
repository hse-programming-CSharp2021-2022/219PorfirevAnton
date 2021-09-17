using System;

namespace Task04
{
    class Program
    {
        static public double Total(double b, double p, int n)
        {
            if (n == 1)
            {
                return b * (1 + p);
            }
            else
            {
                return Total(b, p, n - 1) * (1 + p);
            }
        }
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double b);
            double.TryParse(Console.ReadLine(), out double p);
            int.TryParse(Console.ReadLine(), out int n);
            double ans = b;
            for (int i = 0; i < n; ++i)
            {
                ans *= (1 + p);
            }
            Console.WriteLine(ans);
            Console.WriteLine(Total(b, p, n));
        }
    }
}
