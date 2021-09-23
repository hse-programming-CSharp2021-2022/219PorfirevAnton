using System;

namespace Task01
{
    class Vector
    {
        public double x;
        public double y;
        public Vector(double X, double Y)
        {
            x = X;
            y = Y;
        }
    }
    class Program
    {
        const double eps = 1e-10;
        static double Cross(Vector a, Vector b)
        {
            return (a.x * b.y - a.y * b.x);
        }
        static double Dot(Vector a, Vector b)
        {
            return (a.x * b.x + a.y * b.y);
        }
        static double Mod(Vector a)
        {
            return Math.Sqrt(a.x * a.x + a.y * a.y);
        }
        static bool CheckSector(Vector OC, Vector OA, Vector OB)
        {

            return Mod(OC) <= 2 + eps && (Cross(OC, OA) >= 0 &&  Cross(OC, OB) <= 0);
        }
        static void Main(string[] args)
        {
            string[] subs = Console.ReadLine().Split(' ');
            double.TryParse(subs[0], out double x);
            double.TryParse(subs[1], out double y);
            Vector OC = new Vector(x, y);
            Vector OA = new Vector(2 * Math.Cos(Math.PI / 4), 2 * Math.Sin(Math.PI / 4));
            Vector OB = new Vector(0, -2);
            Console.WriteLine(CheckSector(OC, OA, OB));
        }
    }
}
