using System;

namespace Task07
{
    class Program
    {
        static void GCD_LCM(int a, int b, out int g, out int l)
        {
            int sta = a, stb = b;
            while (a != 0)
            {
                int c = a;
                a = b % a;
                b = c;
            }
            g = b;
            l = (sta * stb) / b;
        }
        static void Main(string[] args)
        {
            int a = 11, b = 1;
            GCD_LCM(a, b, out int g, out int l);
            Console.WriteLine(l);
        }
    }
}
