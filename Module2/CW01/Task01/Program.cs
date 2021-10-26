using System;

namespace Task01
{
    class CorrectPolygon
    {
        public int N { get; set;}
        public double Rad { get; set; }
        public CorrectPolygon(int n = 0, double rad = 0)
        {
            N = n;
            Rad = rad;
        }
        public double Perimeter()
        {
            return N * 2 * Rad * Math.Tan(Math.PI / N);
        }
        public double Square()
        {
            return (Rad * this.Perimeter() / 2);
        }
        public string Polygondate()
        {
            return N + " " + Rad + " " + this.Square() + " " + this.Perimeter();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            CorrectPolygon[] arr = new CorrectPolygon[n];
            double[] sq = new double[n];
            double minsq = 0;
            double maxsq = 1e9;
            ConsoleColor t1 = ConsoleColor.Green;
            ConsoleColor t2 = ConsoleColor.Red;
            for (int i = 0; i < n; ++i)
            {
                int.TryParse(Console.ReadLine(), out int m);
                double.TryParse(Console.ReadLine(), out double rad);
                arr[i] = new CorrectPolygon(m, rad);
                sq[i] = arr[i].Square();
                minsq = Math.Min(minsq, sq[i]);
                maxsq = Math.Max(maxsq, sq[i]);
            }
            for(int i = 0; i < n; ++i)
            {
                if (sq[i] == minsq)
                {
                    Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
                    Console.WriteLine(Convert.ToString(sq[i]), t1);
                    Console.ResetColor(); // сбрасываем в стандартный

                }
                else if (sq[i] == maxsq)
                {
                    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                    Console.WriteLine(Convert.ToString(sq[i]), t2);
                    Console.ResetColor(); // сбрасываем в стандартный
                }
                else
                {
                    Console.WriteLine(Convert.ToString(sq[i]));
                }
            }
        }
    }
}
