using System;
using System.Globalization;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                string s = Console.ReadLine();
                s = s.Remove(s.Length - 1);
                double.TryParse(s, out double b);
                int.TryParse(Console.ReadLine(), out int p);
                Console.WriteLine(((b * p) / 100).ToString("C2", nfi));
            }
        }
    }
}
