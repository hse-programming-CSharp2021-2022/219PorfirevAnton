using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[,] a = new int[n, n];
            int[,] move = {{ 0, 1 }, { -1, 0 }, { 0, -1 }, { 1, 0 }};
            int m = 0, al = 2, i = 0, j = 0;
            a[0, 0] = 1;
            while(al <= n * n)
            {
                while(0 <= i + move[m, 0] && n > i + move[m, 0] && 0 <= j + move[m, 1] && n > j + move[m, 1] && a[i + move[m, 0], j + move[m, 1]] == 0)
                {
                    a[i + move[m, 0], j + move[m, 1]] = al;
                    al++;
                    i += move[m, 0];
                    j += move[m, 1];
                }
                m = (m + 1) % 4;
            }
            for(int q = 0; q < n; ++q)
            {
                for(int k = 0; k < n; ++k)
                {
                    Console.Write(Convert.ToString(a[q, k]) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
