using System;
using System.Collections;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new();
            int[] mas = new int[n];
            for(int i = 0; i < n; ++i)
            {
                mas[i] = rnd.Next(-1000, 1000);
            }
            var z1 = mas.Select(g => g * g);
            var z2 = mas.Where(g => g > 0 && g < 100);
            var z3 = mas.Where(g => g % 2 == 0).OrderBy(g => -g);
            var z4 = from g in mas
                     group g by (g.ToString()).Length into newColl
                     select newColl;

            Array.ForEach(mas, g => Console.WriteLine(g));
            Console.WriteLine();
            Array.ForEach(z1.ToArray(), g => Console.WriteLine(g));
            Console.WriteLine();
            Array.ForEach(z2.ToArray(), g => Console.WriteLine(g));
            Console.WriteLine();
            Array.ForEach(z3.ToArray(), g => Console.WriteLine(g));
            Console.WriteLine();
            foreach(var elem in z4)
            {
                Console.WriteLine(elem.Key);
                foreach(var elem2 in elem)
                {
                    Console.WriteLine(elem2);
                }
            }
        }
    }
}
