using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод
            int[] a = { 1, 2, 3, 4, 5, 6 };
            int c = a.Length;
            for (int i = 0; i < c - 1; ++i)
            {
                if ((a[i] + a[i + 1]) % 3 == 0)
                {
                    a[i] = a[i] * a[i + 1];
                    for (int j = i + 1; j < c - 1; ++j)
                    {
                        a[j] = a[j + 1];
                    }
                    a[c - 1] = a[c - 2];
                }
                c--;
            }
            for (int i = 0; i < c; ++i)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}