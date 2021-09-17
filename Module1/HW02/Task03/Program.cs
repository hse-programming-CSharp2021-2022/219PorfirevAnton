using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double eps = 1e-10;
                double.TryParse(Console.ReadLine(), out double a);
                double.TryParse(Console.ReadLine(), out double b);
                double.TryParse(Console.ReadLine(), out double c);
                double Re = -b / (2 * a);
                Re = (Math.Abs(Re) < eps) ? Math.Abs(Re) : Re;
                double Im = Math.Sqrt(Math.Abs(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine((b * b - 4 * a * c) >= 0 ? Re + Im : Convert.ToString(Re) + "+" + (Math.Abs(Im - 1) >= eps ? Convert.ToString(Im) : "") + "i");
                Console.Write((Math.Abs(Im) > eps) ? ((b * b - 4 * a * c) >= 0 ? Re - Im + "\n" : Convert.ToString(Re) + "-" + (Math.Abs(Im - 1) >= eps ? Convert.ToString(Im) : "") + "i\n") : "");

            }
        }
    }
}
