using System;

namespace Task01
{
    public class Shape
    {
        public const double PI = Math.PI;
        protected double _x, _y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public virtual double Area()
        {
            return _x * _y;
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * _x * _x;
        }
    }

    public class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * _x * _x;
        }
    }

    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * _x * _x + 2 * PI * _x * _y;
        }
    }
    /*
    Output:
    Area of Circle   = 28.27
    Area of Sphere   = 113.10
    Area of Cylinder = 150.80
    */
    class Program
    {
        public static int cmp(Shape a, Shape b)
        {
            if (a is Circle)
            {
                return 1;
            }
            if (b is Circle)
            {
                return -1;
            }
            if (a is Sphere)
            {
                return 1;
            }
            return -1;
        }
        static void Main()
        {
            Random rnd = new Random();
            int n1 = rnd.Next(3, 6);
            int n2 = rnd.Next(3, 6);
            int n3 = rnd.Next(3, 6);
            Shape[] shapes = new Shape[n1 + n2 + n3];
            int i = 0;
            for(; i < n1; ++i)
            {
                shapes[i] = new Circle(rnd.Next() + rnd.Next(0, 6));
            }
            for (; i < n1 + n2; ++i)
            {
                shapes[i] = new Sphere(rnd.Next() + rnd.Next(0, 6));
            }
            for (; i < n1 + n2 + n3; ++i)
            {
                shapes[i] = new Cylinder(rnd.Next() + rnd.Next(0, 6), rnd.Next() + rnd.Next(0, 11));
            }
            Array.Sort(shapes, cmp);
            foreach(var shape in shapes)
            {
                if (shape is Circle)
                {
                    Console.Write("Площадь круга: ");
                }
                if (shape is Sphere)
                {
                    Console.Write("Площадь поверхности сферы: ");
                }
                if (shape is Cylinder)
                {
                    Console.Write("Площадь поверхности цилиндра: ");
                }
                Console.WriteLine(shape.Area());
            }
        }
    }
}
