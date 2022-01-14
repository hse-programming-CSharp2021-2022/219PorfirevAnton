using System;

namespace Task01
{
    class A
    {
        public static int[] First(int a)
        {
            int b = a;
            int l = 0;
            if (b == 0)
            {
                l = 1;
            }
            while(b > 0)
            {
                l++;
                b /= 10;
            }
            int[] ans = new int[l];
            l--;
            if (a == 0)
            {
                ans[0] = 0;
            }
            while(a > 0)
            {
                ans[l] = a % 10;
                a /= 10;
            }
            return ans;
        }
        public static void Second(int[] ans)
        {
            for(int i = 0; i < ans.Length; ++i)
            {
                Console.Write(ans[i] + ' ');
            }
            Console.WriteLine();
        }

    }
    class Program
    {
        delegate int[] Row(int a);
        delegate void Print(int[] a);
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(10000, 100000);
            int[] a = new int[10];
            for(int i = 0; i < 10; ++i)
            {
                a[i] = rnd.Next(10, 100);
            }
            Row r = new Row(A.First);
            Print p = new Print(A.Second);
            p(r(n));
            for(int i = 0; i < 10; ++i)
            {
                p(r(a[i]));
            }
        }
    }
}
