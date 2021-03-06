using System;

namespace Task01
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания
        public double Ro
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
        public double Fi
        {
            get
            {
                return Math.Atan2(Y, X);
            }
        }
        public string PointData
        {   // СВОЙСТВО 
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
    }

    class Program
    {
        static int cmp(Point a, Point b)
        {
            if (a.Ro <= b.Ro)
            {
                return 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                Point[] arr = { a, b, c };
                Array.Sort(arr, cmp);
                foreach (var point in arr)
                {
                    Console.WriteLine(point.PointData); 
                }
            } while (x != 0 || y != 0);
        }
    }
}
