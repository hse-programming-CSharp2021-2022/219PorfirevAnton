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
                return (int)a % 2 == 0 ? (int)a : (int)a + 1;
            };
        }
    }
}
