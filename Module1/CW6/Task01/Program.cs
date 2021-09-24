using System;

namespace Task01
{
    class Program
    {
        static int merge(int a, int b, int l1, int l2)
        {
            int a1 = a;
            int b1 = b;
            int ans = 0;
            while (a1 > 0 && b1 > 0)
            {
                if (a1 / (int)Math.Pow(10, l1 - 1) >= b1 / (int)Math.Pow(10, l2 - 1))
                {
                    ans = ans * 10 + a1 / (int)Math.Pow(10, l1 - 1);
                    a1 %= (int)Math.Pow(10, l1 - 1);
                    l1--;
                }
                else
                {
                    ans = ans * 10 + b1 / (int)Math.Pow(10, l2 - 1);
                    b1 %= (int)Math.Pow(10, l2 - 1);
                    l2--;
                }
            }
            while (a1 > 0)
            {
                ans = ans * 10 + a1 / (int)Math.Pow(10, l1 - 1);
                a1 %= (int)Math.Pow(10, l1 - 1);
                l1--;
            }
            while (b1 > 0)
            {
                ans = ans * 10 + b1 / (int)Math.Pow(10, l2 - 1);
                b1 %= (int)Math.Pow(10, l2 - 1);
                l2--;
            }
            return ans;
        }
        static int merge_sort(int n, int l)
        {
            if (l == 1)
            {
                return n;
            }
            else
            {
                return merge(merge_sort(n / (int)Math.Pow(10, l / 2), l - l / 2), merge_sort(n % (int)Math.Pow(10, l / 2), (l / 2)), l - l / 2, l / 2);
            }
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int l);
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine(merge_sort(n, l));
        }
    }
}
