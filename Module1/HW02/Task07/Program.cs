using System;

namespace Task07
{
    class Program
    {
        public static string ForTheWholePart(double a)
        {
            return Convert.ToString((int)a + (a < 0 && a - (int)a < 0 ? -1 : 0)) + " " + Convert.ToString(a - (int)a + (a < 0 && a - (int)a < 0 ? 1 : 0));
        }
        public static string SqrtAndSquare(double a)
        {
            if (a >= 0)
            {
                return Convert.ToString(Math.Sqrt(a)) + " " + Convert.ToString(a * a);
            }
            return Convert.ToString(a * a);
        }
        public static void Main(string[] args)
        {
            while (true)
            {
                double.TryParse(Console.ReadLine(), out double x);
                Console.WriteLine(ForTheWholePart(x));
                Console.WriteLine(SqrtAndSquare(x));
            }
        }
    }
}
