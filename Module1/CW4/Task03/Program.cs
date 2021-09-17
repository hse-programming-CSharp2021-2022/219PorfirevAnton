using System;

namespace Task03
{
    class Program
    {
        static public int AkermanFunc(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return AkermanFunc(m - 1, 1);
            }
            else
            {
                return AkermanFunc(m - 1, AkermanFunc(m, n - 1));
            }
        }
        static public void Main(string[] args)
        {
            Console.WriteLine(AkermanFunc(3, 1));
        }
    }
}
