using System;

namespace Task02
{
    class Program
    {
        static bool Shift(ref char c)
        {
            if (0 <= c - 'a' && c - 'a' < 26)
            {
                int d = c - 'a';
                d = (d + 4) % 26;
                c = (char)((int)'a' + d);
            }
            return 0 <= c - 'a' && c - 'a' < 26;
        }
        static void Main(string[] args)
        {
            char.TryParse(Console.ReadLine(), out char c);
            Shift(ref c);
            Console.WriteLine(c);
        }
    }
}
