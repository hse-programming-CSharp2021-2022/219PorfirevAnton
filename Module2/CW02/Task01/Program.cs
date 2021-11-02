using System;

namespace Task01
{
    class MyComplex
    {
        double re, im;
        public MyComplex(double xre = 0, double xim = 0)
        { re = xre; im = xim; }
        public static MyComplex operator --(MyComplex mc)
        { return new MyComplex(mc.re - 1, mc.im - 1); }
        public static MyComplex operator ++(MyComplex mc)
        { return new MyComplex(mc.re + 1, mc.im + 1); }
        public double Mod() { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }
        public static MyComplex operator +(MyComplex self, MyComplex other)
        {
            return new MyComplex(self.re + other.re, self.im + other.im);
        }
        public static MyComplex operator -(MyComplex self, MyComplex other)
        {
            return new MyComplex(self.re - other.re, self.im - other.im);
        }
        public static MyComplex operator *(MyComplex self, MyComplex other)
        {
            return new MyComplex(self.re * other.re - self.im * other.im, self.re * other.im + self.im * other.re);
        }
        public static MyComplex operator /(MyComplex self, double other)
        {
            return new MyComplex(self.re / other, self.im / other);
        }
        public static MyComplex operator /(MyComplex self, MyComplex other)
        {
            return new MyComplex(self.re * other.re + self.im * other.im, self.im * other.re - self.re * other.im) / (other.re * other.re + other.im * other.im);
        }
        public override string ToString()
        {
            return re + " + " + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex a = new MyComplex(1, 2);
            MyComplex b = new MyComplex(3, 4);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(b * (a / b));
        }
    }
}
