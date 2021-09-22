using System;

namespace Task02
{
    class Program
    {
        static void Ans(int n)
        {
            double s = 0;
            for(int i = 1; i <= n; ++i)
            {
                s += (i + 0.3) / (3 * i * i + 5);
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Ans(n);
        }
    }
}
