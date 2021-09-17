using System;

namespace Task02
{
    class Program
    {
        static double Min(double a, double b)
        {
            return (a < b ? a : b);
        }
        static double f(double x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double a);
            double.TryParse(Console.ReadLine(), out double b);
            double.TryParse(Console.ReadLine(), out double del);
            double ans = 0, st = a;
            while (st < b)
            {
                double fi = Min(st + del, b);
                ans += (fi - st) * ((f(fi) + f(st)) / 2);
                st = fi;
            }
            Console.WriteLine(ans);
        }
    }
}
