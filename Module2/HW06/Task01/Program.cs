using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
namespace Task01
{
    class MyException : Exception
    {
        public MyException (string message)
            : base(message)
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try //1
            {
                int x = 1;
                int y = x / 0;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //2
            {
                int[] arr = { 1, 2 };
                Console.WriteLine(arr[3]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //3
            {
                string s = "abacaba";
                Console.WriteLine(Convert.ToInt32(s));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //4
            {
                string text = File.ReadAllText("abacaba.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //5
            {
                int a = int.MaxValue;
                Console.WriteLine(checked(a * a));
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //6
            {
                List<int> a = new List<int>();
                a.Add(0);
                Console.WriteLine(a[1]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //7
            {
                StreamReader file = new StreamReader("hi.txt");
                file.Close();
                Console.WriteLine(file.ReadLine());
            }
            catch (ObjectDisposedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //8
            {
                List<int> a = new List<int>();
                for(int i = 0; i < 5; ++i)
                {
                    a.Add(0);
                }
                foreach(var elem in a)
                {
                    a.Add(elem);
                }
                Console.WriteLine(a.Count);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //9
            {
                string path = "wrongPath";
                Directory.SetCurrentDirectory(path);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try //10
            {
                Exception ex = new MyException("big problem");
                throw ex;
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
