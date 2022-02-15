using System;
using System.IO;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("Task01.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                if(fileStream.Length == 0)
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes("a");
                    fileStream.Write(array, 0, array.Length);
                }
                else
                {
                    byte[] array = new byte[fileStream.Length + 1];
                    fileStream.Read(array, 0, (int)fileStream.Length);
                    if(array[array.Length - 2] == 'c')
                    {
                        Array.ForEach(array, (byte a) => Console.WriteLine((char)a));
                    }
                    array[array.Length - 1] = (byte)(array[array.Length - 2] + 1);
                    fileStream.Write(array, array.Length - 1, 1);
                }
            }
        }
    }
}
