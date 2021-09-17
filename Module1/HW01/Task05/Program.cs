using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int u);
            int.TryParse(Console.ReadLine(), out int r);
            Console.WriteLine(Math.Sqrt(u * u + r * r));
        }
    }
}
