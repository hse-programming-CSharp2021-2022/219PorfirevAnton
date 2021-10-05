using System;
using System.Text;

namespace Task03
{
    class Program
    {
        static string FirstTask(string s)
        {
            string[] a = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", a);
        }
        static int SecondTask(string s)
        {
            string[] a = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i].Length <= 4)
                {
                    count++;
                }
            }
            return count;
        }
        static int ThirdTask(string s)
        {
            string check = "ауоыиэяюёеАУОЫИЭЯЮЁЁ";
            string[] a = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (check.Contains(a[i][0]))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ThirdTask(Console.ReadLine()));
        }
    }
}
