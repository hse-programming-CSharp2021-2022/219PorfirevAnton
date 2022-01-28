using System;

namespace Task01
{
    class Point
    {
        double x;
        double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double Dist(Point A)
        {
            return Math.Sqrt((A.X - x) * (A.x - x) + (A.y - y) * (A.y - y));
        }
        public static double operator ^(Point A, Point B)
        {
            return A.x * B.x - A.y * B.x;
        }
        public Point Vector(Point B)
        {
            return new Point(B.x - x, B.y - y);
        }
        public override string ToString()
        {
            return $"{x}, {y}";
        }
    }
    class TriangleComp 
    {
        Point A;
        Point B;
        Point C;
        double AB;
        double AC;
        double BC;
        public TriangleComp(Point a, Point b, Point c)
        {
            /*
            A = new Point(a.X, a.Y);
            B = new Point(b.X, b.Y);
            C = new Point(c.X, c.Y);
            */
            A = a;
            B = b;
            C = c;
            AB = A.Dist(B);
            AC = A.Dist(C);
            BC = B.Dist(C);
        }
        public double Area
        {
            get
            {
                return Math.Abs((A.Vector(B) ^ A.Vector(C)) / 2);
            }
        }
        public double Perimetr
        {
            get
            {
                return AB + AC + BC;
            }
        }
        public bool IsInTriangle(Point D)
        {
            TriangleComp tr1 = new TriangleComp(A, B, D);
            TriangleComp tr2 = new TriangleComp(A, C, D);
            TriangleComp tr3 = new TriangleComp(C, B, D);
            return (tr1.Area + tr2.Area + tr3.Area <= this.Area + 1e-9);
        }
        public override string ToString()
        {
            return $"A: {A}; B: {B}; C: {C}; Area: {Area}, Perimetr: {Perimetr}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TriangleComp[] triangles = new TriangleComp[10];
            Random rnd = new Random();
            for(int i = 0; i < 10; ++i)
            {
                triangles[i] = new TriangleComp(new Point(rnd.Next(0, 10), rnd.Next(0, 10)),
                                                new Point(rnd.Next(0, 10), rnd.Next(0, 10)),
                                                new Point(rnd.Next(0, 10), rnd.Next(0, 10)));
            }
            Array.Sort(triangles, (TriangleComp tr1, TriangleComp tr2) => tr1.Area >= tr2.Area ? 1 : -1);
            foreach(var tr in triangles)
            {
                Console.WriteLine(tr);
            }
            Console.WriteLine();
            Array.Sort(triangles, (TriangleComp tr1, TriangleComp tr2) => tr1.Perimetr >= tr2.Perimetr ? -1 : 1);
            foreach (var tr in triangles)
            {
                Console.WriteLine(tr);
            }
        }
    }
}
