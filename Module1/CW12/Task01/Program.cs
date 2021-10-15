using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task01
{
    class Program
    {
        static bool CheckPal(int t)
        {
            string s = Convert.ToString(t);
            for(int i = 0; i < s.Length / 2; ++i)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static int sumnum(int a)
        {
            int sum = 0;
            while(a > 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
        static int maxnum(int a)
        {
            int ans = 0;
            while (a > 0)
            {
                ans = Math.Max(a % 10, ans);
                a /= 10;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            /*
            string s = "Hell Hell Hello";
            Regex reg = new Regex("Hell");
            var matches = reg.Matches(s);
            foreach (Match m in matches)
                Console.WriteLine(m);
            s = reg.Replace(s, "1111");
            Console.WriteLine(s);

            string s2 = " 111-111-1111";
            Regex reg2 = new Regex(@"\s[0-9]{3}-[0-9]{3}-[0-9]{4}");
            Console.WriteLine(reg2.Match(s2));
            */
            int.TryParse(Console.ReadLine(), out int n);
            int[] a = new int[n];
            for(int i = 0; i < n; ++i)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(1, 10001);
            }
            var ans = from t in a
                          where (t % 3 == 0) && (10 <= t) && (t < 100)
                          select t;
            foreach (var elem in ans)
                Console.Write($"{elem} ");
            Console.WriteLine();

            var ans2 = from t in a
                       where CheckPal(t)
                       orderby t
                       select t;
            foreach (var elem in ans2)
                Console.Write($"{elem} ") ;
            Console.WriteLine();

            var ans3 = from t in a
                       .OrderBy(t => sumnum(t))
                       .ThenBy(t => t)
                       select t;
            foreach (var elem in ans3)
                Console.Write($"{elem} ");
            Console.WriteLine();

            var ans4 = from t in a
                       where (999 < t) && (t < 10000)
                       select t;
            int rans4 = 0;
            foreach (var elem in ans4)
                rans4 += elem;
            Console.WriteLine(rans4);

            var ans5 = from t in a
                       where (9 < t) && (t < 100)
                       select t;
            int rans5 = 100;
            foreach (var elem in ans5)
                rans5 = Math.Min(rans5, elem);
            Console.WriteLine(rans5);

            var ans6 = from t in a
                       select maxnum(t);
            List<int> rans6 = new List<int>();
            foreach (var elem in ans6)
                rans6.Add(elem);
            foreach (var elem in rans6)
                Console.Write($"{elem} ");
            Console.WriteLine();
        }
    }
}
