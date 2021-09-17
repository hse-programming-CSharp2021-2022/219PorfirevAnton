using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int u);
            int.TryParse(Console.ReadLine(), out int r);
            Console.WriteLine(u / r);
            Console.WriteLine(u * u / r);
        }
    }
}
