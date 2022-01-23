using System;

namespace Task01
{
    delegate void CoordChanged(Dot dot);
    class Dot
    {
        public double X { get; set; }
        public double Y { get; set; }
        public event CoordChanged OnCoordChanged;
        Random rnd = new Random();
        public Dot(double x, double y)
        {
            X = x; Y = y;
        }
        public void DotFlow()
        {
            for(int i = 0; i < 10; ++i)
            {
                X = -10 + rnd.NextDouble() * 20;
                Y = -10 + rnd.NextDouble() * 20;
                if (X < 0 && Y < 0)
                {
                    OnCoordChanged(this);
                }
            }
        }
    }
    class Program
    {
        static void PrintInfo(Dot A)
        {
            Console.WriteLine($"{A.X}, {A.Y}");
        }
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double x);
            double.TryParse(Console.ReadLine(), out double y);
            Dot D = new Dot(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }
    }
}
