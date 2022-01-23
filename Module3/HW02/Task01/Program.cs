using System;

namespace Task01
{
    class Plant
    {
        double growth;
        int photosensitivity;
        int frostresistance;
        public double Growth
        {
            get
            {
                return growth;
            }
        }
        public int Photosensitivity
        {
            get
            {
                return photosensitivity;
            }
        }
        public int Frostresistance
        {
            get
            {
                return frostresistance;
            }
        }
        public Plant(double growth, int photosensitivity, int frostresistance)
        {
            this.growth = growth;
            this.photosensitivity = photosensitivity;
            this.frostresistance = frostresistance;
        }
        public override string ToString()
        {
            return $"рост: {growth}, светочувствительность: {photosensitivity}, морозоустойчивость: {frostresistance}";
        }
    }
    class Program
    {
        static void Print(Plant plant)
        {
            Console.WriteLine(plant);
        }
        static int cmp(Plant a, Plant b)
        {
            if (a.Photosensitivity % 2 == 0 && b.Photosensitivity % 2 != 0)
            {
                return -1;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Plant[] plants = new Plant[n];
            Random rnd = new Random();
            for(int i = 0; i < n; ++i)
            {
                plants[i] = new Plant(rnd.NextDouble() * 75 + 25, rnd.Next(0, 100), rnd.Next(0, 101));
            }
            Array.ForEach(plants, Print);
            Array.Sort(plants, delegate(Plant a, Plant b) 
            {
                if (a.Growth < b.Growth)
                {
                    return 1;
                }
                return -1;
            });
            Console.WriteLine();
            Array.ForEach(plants, Print);  
            Array.Sort(plants, (Plant a, Plant b) => (a.Frostresistance < b.Frostresistance) ? -1 : 1);
            Console.WriteLine();
            Array.ForEach(plants, Print);
            Array.Sort(plants, cmp);
            Console.WriteLine();
            Array.ForEach(plants, Print);
            Console.WriteLine();
            Plant[] newplants = Array.ConvertAll(plants, (Plant a) => new Plant(a.Growth, a.Photosensitivity, a.Frostresistance % 2 == 0 ? a.Frostresistance / 3 : a.Frostresistance / 2));
            Array.ForEach(newplants, Print);
        }
    }
}
