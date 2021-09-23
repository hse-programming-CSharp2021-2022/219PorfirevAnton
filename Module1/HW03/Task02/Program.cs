using System;

namespace Task02
{
    class Program
    {
        static double G(double x, double y)
        {
            if (x < y && x > 0)
            {
                return x + Math.Sin(y);
            }
            else if (x > y && x < 0)
            {
                return y - Math.Cos(x);
            }
            else
            {
                return 0.5 * x * y;
            }
        }
        static void Main(string[] args)
        {
            string[] subs = Console.ReadLine().Split(' ');
            double.TryParse(subs[0], out double x);
            double.TryParse(subs[1], out double y);
            Console.WriteLine(G(x, y));
        }
    }
}
