using System;
using System.Collections;
using System.Linq;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[] mas = new int[n];
            Random rnd = new Random();
            for(int i = 0; i < n; ++i)
            {
                mas[i] = rnd.Next(-10000, 10001);
            }
            var z1 = from g in mas
                     select (g + 20000) % 10;
            var z1_2 = mas.Select(g => (g + 20000) % 10);
            var z2 = from g in mas
                     group g by (g + 20000) % 10 into newColl
                     select newColl;
            var z2_2 = mas.GroupBy(g => (g + 20000) % 10);
            var z3 = from g in mas
                     where g > 0 && g % 2 == 0
                     select g;
            var z3Count = z3.Count();
            var z3_2 = mas.Where(g => (g > 0 && g % 2 == 0));
            var z4 = (from g in mas
                     where g % 2 == 0
                     select g).Sum();
            var z4_2 = mas.Where(g => g % 2 == 0).Sum();
            var z5 = from g in mas
                     orderby Convert.ToInt32((((Math.Abs(g)).ToString())[0])), (g + 20000) % 10
                     select g;
            var z5_2 = mas.OrderBy(g => Convert.ToInt32((((Math.Abs(g)).ToString())[0]))).ThenBy(g => (g + 20000) % 10);

            Array.ForEach(mas, g => Console.WriteLine(g));
            Console.WriteLine();
            foreach(var elem in z1_2)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            foreach (var elem in z2_2)
            {
                Console.WriteLine(elem.Key);
                foreach (var elem2 in elem)
                    Console.WriteLine(elem2);
            }
            Console.WriteLine();
            foreach (var elem in z3)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
            Console.WriteLine(z4);
            Console.WriteLine();
            foreach (var elem in z5)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
        }
    }
}
