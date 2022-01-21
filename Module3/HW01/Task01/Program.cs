using System;

namespace Task01
{
    class Program
    {
        delegate int Cast(double a); 
        static void Main(string[] args)
        {
            Cast cast1 = delegate (double a) 
            {
                return (int)a % 2 == 0 ? (int)a : (int)a + 1; 
            };
            Cast cast2 = delegate (double a)
            {
                int ans = 0;
                while(a >= 10)
                {
                    a /= 10;
                    ans += 1;
                }
                return ans;
            };
            Console.WriteLine(cast1(163268.7));
            Console.WriteLine(cast2(163268.7));
            Random rnd = new Random();
            for(int i = 0; i < 10; ++i)
            {
                double x = rnd.NextDouble() * rnd.Next(1, 20);
                Console.WriteLine(cast1(x));
                Console.WriteLine(cast2(x));
            }
        }
    }
}
