using System;

namespace Task02
{
    abstract class Something
    {

    }
    class Lentil : Something
    {
        public double Weight { get; set; }
        public Lentil()
        {
            Random rnd = new Random();
            Weight = rnd.Next() * 2; 
        }
    }
    class Ashes : Something
    {
        public double Volume { get; set; }
        public Ashes()
        {
            Random rnd = new Random();
            Volume = rnd.Next();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Something[] some = new Something[n];
            for(int i = 0; i < n; ++i)
            {
                Random rnd = new Random();
                int type = rnd.Next(0, 2);
                if(type == 1)
                {
                    some[i] = new Lentil();
                }
                else
                {
                    some[i] = new Ashes();
                }
            }
            // тут я не понял
        }
    }
}
