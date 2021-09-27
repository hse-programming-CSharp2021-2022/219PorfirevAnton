using System;

namespace Task06
{
    class Program
    {
        static double Func1(double x)
        {
            double eps = 1e-11;
            double last = -1;
            double s = 0;
            double m = x * x;
            int k = 1, n = 1;
            while(Math.Abs(s - last) > eps)
            {
                last = s;
                s += m * k;
                k *= -1;
                m *= 4 * x * x;
                m /= (2 * n + 1) * (2 * n + 2);
                n++;
            }
            return s;
        }
        static double Func2(double x)
        {
            double eps = 1e-11;
            double last = -1;
            double s = 0;
            double m = 1;
            int n = 1;
            while (Math.Abs(s - last) > eps)
            {
                last = s;
                s += m;
                m *= x;
                m /= n;
                n++;
            }
            return s;
        }
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine(Func2(x));
        }
    }
}
