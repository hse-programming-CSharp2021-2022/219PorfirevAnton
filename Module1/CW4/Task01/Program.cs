using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double now = 0, eps = 1e-13;
            double last = -1;
            int n = 3;
            while ((now - last) > eps)
            {
                last = now;
                now = now + ((double)1 / ((n - 2) * (n - 1) * n));
                n++;
            }
            Console.WriteLine(now);
        }
    }
}
