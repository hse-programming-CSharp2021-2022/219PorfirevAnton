using System;

namespace Task03
{
    class Program
    {
        static bool cmp(int elem)
        {
            return elem % 10 == elem / 1000 && (elem / 100) % 10 == (elem / 10) % 10;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] a = new int[n];
            for(int i = 0; i < n; ++i)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(1000, 10000);
            }
            //Array.ForEach(a, elem => Console.Write(Convert.ToString(elem) + " "));
            Console.WriteLine();
            int[] b = Array.FindAll(a, cmp);
            Array.ForEach(b, elem => Console.Write(Convert.ToString(elem) + " "));
        }
    }
}
