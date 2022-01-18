using System;

namespace Task01
{
    delegate void SqureSizeChanged(double a);
    class Point
    {
        public double x;
        public double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(string s)
        {
            string[] s1 = s.Split();
            double.TryParse(s1[0], out x);
            double.TryParse(s1[1], out y);
        }
        public double Dist(Point other)
        {
            return Math.Sqrt((this.x - other.x) * (this.x - other.x) + (this.y - other.y) * (this.y - other.y));
        }
    }
    class Square
    {
        Point leftUp;
        Point rightDown;
        public Point LeftUp
        {
            get
            {
                return leftUp;
            }
            set
            {
                leftUp = value;
                OnSizeChanged(leftUp.Dist(rightDown) * (1 / Math.Sqrt(2)));
            }
        }
        public Point RightDown
        {
            get
            {
                return rightDown;
            }
            set
            {
                rightDown = value;
                OnSizeChanged(leftUp.Dist(rightDown) * (1 / Math.Sqrt(2)));
            }
        }
        public Square(Point A, Point B)
        {
            leftUp = A;
            rightDown = B;
        }
        public event SqureSizeChanged OnSizeChanged;
    }
    class Program
    {
        static void SquareConsoleInfo(double A)
        {
            Console.WriteLine($"{A:F3}");
        }
        static void Main(string[] args)
        {
            Point leftUP = new Point(Console.ReadLine());
            Point rightDown = new Point(Console.ReadLine());
            Square S = new Square(leftUP, rightDown);
            S.OnSizeChanged += SquareConsoleInfo;
            for(int i = 0; i < 5; ++i)
            {
                Point newPoint = new Point(Console.ReadLine());
                S.RightDown = newPoint;
            }
        }
    }
}
