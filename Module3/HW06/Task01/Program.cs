using System;
using System.Collections.Generic;


namespace Task01
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point B)
        {
            return Math.Sqrt((B.X - X) * (B.X - X) + (B.Y - Y) * (B.Y - Y));
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
    class Circle: IComparable<Circle>
    {
        Point O;
        double rad;
        public Circle(double x, double y, double r)
        {
            this.O = new Point(x, y);
            rad = r;
        }
        public override string ToString()
        {
            return $"радиус: {rad}, центр: {O}";
        }

        public int CompareTo(Circle other)
        {
            if (this < other)
                return 1;
            return 1;
        }

        public static bool operator >(Circle W1, Circle W2)
        {
            return W1.O.Distance(new Point()) * W1.rad > W2.O.Distance(new Point()) * W2.rad;
        }
        public static bool operator <(Circle W1, Circle W2)
        {
            return W1.O.Distance(new Point()) * W1.rad < W2.O.Distance(new Point()) * W2.rad;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Circle[] circles1 = new Circle[10];
            Circle[] circles2 = new Circle[10];
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                circles1[i] = new Circle(rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));
                circles2[i] = new Circle(rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));
            }
            Array.Sort(circles1, (Circle circ1, Circle circ2) => (circ1 > circ2 ? 1 : -1));
            Array.Sort(circles2);
            foreach(var circle in circles1)
            {
                Console.WriteLine(circle);
            }
            Console.WriteLine();
            foreach(var circle in circles2)
            {
                Console.WriteLine(circle);
            }
        }
    }
}
