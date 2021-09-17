using System;

namespace Task05
{
    public class Program
    {
        public static double Max(double a, double b)
        {
            return (a >= b) ? a : b;
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                double.TryParse(Console.ReadLine(), out double a);
                double.TryParse(Console.ReadLine(), out double b);
                double.TryParse(Console.ReadLine(), out double c);
                double p = a + b + c;
                Console.WriteLine(Max(a, Max(b, c)) >= p - Max(a, Max(b, c)) ? "NO" : "YES");
            }
        }
    }
}
