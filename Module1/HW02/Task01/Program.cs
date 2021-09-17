using System;

namespace Task01
{
    class Program
    {
        public static double prod(double a, double b)
        {
            double ans = 0;
            for (int i = 0; i < a; ++i)
            {
                ans += b;
            }
            return ans;
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                double.TryParse(Console.ReadLine(), out double x);
                // это по фану Console.WriteLine(prod(12, prod(x, prod(x, prod(x, x)))) + prod(9, prod(x, prod(x, x))) - prod(3, prod(x, x)) + prod(2, x) - 4);
                Console.WriteLine(x * (x * (x * (12 * x + 9) - 3) + 2) - 4);
            }
        }
    }
}