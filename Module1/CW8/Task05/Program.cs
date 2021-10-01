using System;

namespace Task05
{
    class Program
    {
        static int cmp1(int[] a, int[] b)
        {
            if (a.Length < b.Length)
            {
                return 1;
            }
            return -1;
        }
        static int cmp2(int a, int b)
        {
            if (a < b)
            {
                return 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[][] a = new int[n][];
            for(int i = 0; i < n; ++i)
            {
                Random rnd = new Random();
                Array.Resize(ref a[i], rnd.Next(5, 16));
                for(int j = 0; j < a[i].Length; ++j)
                {
                    a[i][j] = rnd.Next(-10, 11);
                }
                Array.ForEach(a[i], elem => Console.Write(Convert.ToString(elem) + " "));
                Console.WriteLine();
                Array.Sort(a[i], cmp2);
            }
            Array.Sort(a, cmp1);
            Console.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                Array.ForEach(a[i], elem => Console.Write(Convert.ToString(elem) + " "));
                Console.WriteLine();
            }
        }
    }
}
