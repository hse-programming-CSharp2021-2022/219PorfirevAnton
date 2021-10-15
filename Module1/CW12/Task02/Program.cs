using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Regex reg = new Regex(@"(\W|^){1,}(([A-Z]|[a-z]){4})(\W|$){1,}");
            var matches = reg.Matches(s);
            foreach (var elem in matches)
                Console.WriteLine(elem);
        }
    }
}
