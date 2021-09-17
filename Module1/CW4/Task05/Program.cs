using System;

namespace Task05
{
    class Program
    {
        static public int phi(int n)
        {
            int d = 2, ans = 2;
            while (d * d < n)
            {
                if (n % d == 0)
                {
                    ans += 2;
                }
                d++;
            }
            if(d * d == n)
            {
                ans++;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int k);
            int ans = 0;
            for (int i = 100; i < 1000; ++i)
            {
                if (phi(i) == k)
                {
                    ans++;
                }
            }
            Console.WriteLine(ans);
        }
    }
}
