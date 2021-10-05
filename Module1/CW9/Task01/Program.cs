using System;
using System.Text;
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] q = Console.ReadLine().Split("; ");
            string check = "aeiouyAEIOUY";
            for (int k = 0; k < q.Length; ++k)
            {
                string[] q2 = q[k].Split(' ');
                StringBuilder s = new StringBuilder(1000);
                for (int i = 0; i < q2.Length; ++i)
                {
                    int j = 0;
                    while (j < q2[i].Length && !check.Contains(q2[i][j]))
                    {
                        s.Append(q2[i][j]);
                        ++j;
                    }
                    if (j != q2[i].Length)
                    {
                        s.Append(q2[i][j]);
                    }
                }
                Console.WriteLine(s);
            }
        }
    }
}