using System;

namespace Task03
{
    class Program
    {
        const double eps = 1e-10;
        static double G(double x)
        {
            if (x <= 0.5 + eps)
            {
                return 1;
            }
            else
            {
                return Math.Sin(Math.PI * (x - 1) / 2);
            }
        }
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine(G(x));
        }
    }
}
