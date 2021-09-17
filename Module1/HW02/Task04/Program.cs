using System;

namespace Task04
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                int.TryParse(Console.ReadLine(), out int n);
                while(n > 0)
                {
                    Console.WriteLine(n % 10);
                    n /= 10;
                }
            }
        }
    }
}
