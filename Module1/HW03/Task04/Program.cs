using System;

namespace Task04
{
    class Program
    {
        static double Max(double a, double b)
        {
            return (a >= b ? a : b);
        }
        static void Main(string[] args)
        {
            int[] d = new int[3];
            int.TryParse(Console.ReadLine(), out d[0]);
            int.TryParse(Console.ReadLine(), out d[1]);
            int.TryParse(Console.ReadLine(), out d[2]);
            int ans = 99;
            for (int i = 0; i < 3; ++i)
            {
                if (d[i] % 100 <= ans % 100)
                {
                    ans = d[i];
                }
            }
            Console.WriteLine(ans);
        }
    }
}
