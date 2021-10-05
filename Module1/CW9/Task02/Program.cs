using System;
using System.Text;

namespace Task01
{
    class Program
    {
        static int OneHexNumber(char hexnumber)
        {
            if ('0' <= hexnumber && hexnumber <= '9')
            {
                return (hexnumber - '0');
            }
            return (hexnumber - 'A') + 10;
        }
        static int ConvertHex2Int(string hexnumber)
        {
            int real = 0;
            int pow = 1;
            for (int i = hexnumber.Length - 1; i > -1; --i)
            {
                real += pow * OneHexNumber(hexnumber[i]);
                pow *= 16;
            }
            return real;
        }
        static string ConvertInt2Bin(int number)
        {
            StringBuilder ans = new StringBuilder(100);
            if (number == 0)
            {
                return "0";
            }
            else
            {
                while (number > 0)
                {
                    ans.Append(Convert.ToString(number % 2));
                    number /= 2;
                }
                StringBuilder rans = new StringBuilder(ans.Length);
                for (int i = ans.Length - 1; i > -1; --i)
                {
                    rans.Append(ans[i]);
                }
                return Convert.ToString(rans);
            }
        }
        static string ConvertHex2Bin(string hexnumber)
        {
            int real = ConvertHex2Int(hexnumber);
            return ConvertInt2Bin(real);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(ConvertHex2Int(s));
            //Console.WriteLine(ConvertInt2Bin(s));
            Console.WriteLine(ConvertHex2Bin(s));
        }
    }
}
