using System;
using System.IO;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"Data.txt";
                int.TryParse(Console.ReadLine(), out int n);
                // Создаем файл с данными
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                string[] s = new string[n];
                for (int i = 0; i < n; ++i)
                {
                    int[] c = new int[5];
                    for (int j = 0; j < 5; ++j)
                    {
                        Random rnd = new Random();
                        c[j] = rnd.Next(10, 100);
                    }
                    s[i] = String.Join(' ', c);
                }
                File.WriteAllText(path, String.Join('\n', s) + '\n');
                string readText = File.ReadAllText(path);
                string[] stringValues = readText.Split(new char[] { ' ', '\n' });
                int[] arr = StringArrayToIntArray(stringValues, 5 * n);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                int countodd = 1;
                int counteven = 1;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] % 2 == 0)
                        counteven++;
                    else
                        countodd++;
                }
                int[] evenindex = new int[counteven];
                int[] oddindex = new int[countodd];
                int c1 = 0;
                int c2 = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenindex[c1] = arr[i];
                        c1++;
                    }
                    else
                    {
                        oddindex[c2] = arr[i];
                        arr[i] = 0;
                        c2++;
                    }
                }
                foreach (int i in evenindex)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                foreach (int i in oddindex)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так, попробуйте снова");
            }
        }
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str, int k)
        {
            int[] arr = new int[k];
            if (str.Length != 0)
            {
                for(int i = 0; i < k; ++i)
                {
                    arr[i] = Convert.ToInt32(str[i]);
                }     
            }
            return arr;
        } // end of StringToIntArray()
    } // end of Program
}
