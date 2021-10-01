using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            double[] a = new double[n];
            double[] r = new double[n];
            int[] z = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(0, 1001) + rnd.NextDouble();
            }
            for (int i = 0; i < n; ++i)
            {
                z[i] = (int)a[i];
                r[i] = a[i] - z[i];
            }
            Array.Sort(z);
            Array.Sort(r);
            Array.ForEach(z, elem => Console.Write(Convert.ToString(elem) + " "));
            Console.WriteLine();
            Array.ForEach(r, elem => Console.Write(Convert.ToString(elem) + " "));
        }
    }
}
