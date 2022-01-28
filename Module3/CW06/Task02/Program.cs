using System;
using System.Collections.Generic;

namespace Task02
{
    interface IRunable
    {
        void Run();
    }
    interface IJumpable
    {
        void Jump();
    }
    abstract class Animal: IComparable<Animal>
    {
        protected int age;
        public bool isJump;
        public bool isRun;
        public Animal(int age)
        {
            this.age = age;
        }

        public int CompareTo(Animal other)
        {
            if (age < other.age)
                return 1;
            return -1;
        }

        public override string ToString()
        {
            return $"Животное возраста {age}";
        }
    }
    class Cockroach : Animal, IRunable
    {
        int speed;
        public Cockroach(int age, int speed) : base(age) 
        {
            this.speed = speed;
            isJump = false;
            isRun = true;
        }

        public void Run()
        {
            Console.WriteLine($"Таракан возраста {age}, бегает со скоростью {speed}");
        }
    }
    class Kenguru : Animal, IJumpable
    {
        int high;
        public Kenguru(int age, int high): base(age)
        {
            this.high = high;
            isJump = true;
            isRun = false;
        }
        public void Jump()
        {
            Console.WriteLine($"Кенгуру возраста {age}, прыгает на высоту {high}");
        }
    }
    class Сheetah: Animal, IJumpable, IRunable
    {
        int speed;
        int high;
        public Сheetah(int age, int high, int speed) : base(age)
        {
            this.high = high;
            this.speed = speed;
            isJump = true;
            isRun = true;
        }

        public void Jump()
        {
            Console.WriteLine($"Гепард возраста {age}, прыгает на высоту {high}");
        }

        public void Run()
        {
            Console.WriteLine($"Гепард возраста {age}, бегает со скоростью {speed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Animal[] animals = new Animal[n];
            Random rnd = new Random();
            for(int i = 0; i < n; ++i)
            {
                int type = rnd.Next(0, 3);
                switch (type)
                {
                    case 0:
                        animals[i] = new Cockroach(rnd.Next(0, 6), rnd.Next(10, 100));
                        break;
                    case 1:
                        animals[i] = new Kenguru(rnd.Next(0, 10), rnd.Next(1, 7));
                        break;
                    default:
                        animals[i] = new Сheetah(rnd.Next(0, 10), rnd.Next(0, 3), rnd.Next(20, 200));
                        break;
                }
            }
            List<Cockroach> cocroaches = new List<Cockroach>();
            List<Kenguru> kengurues = new List<Kenguru>();
            List<Сheetah> cheetahes = new List<Сheetah>();
            List<Animal> runners = new List<Animal>();
            List<Animal> jumpers = new List<Animal>();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            foreach(var animal in animals)
            {
                if(animal is Kenguru)
                {
                    kengurues.Add(animal as Kenguru);
                }
                else if (animal is Сheetah)
                {
                    cheetahes.Add(animal as Сheetah);
                }
                else
                {
                    cocroaches.Add(animal as Cockroach);
                }
                if (animal.isRun)
                {
                    runners.Add(animal);
                }
                if (animal.isJump)
                {
                    jumpers.Add(animal);
                }
            }
            foreach (var animal in runners)
            {
                animal.Run();
            }
            Array.Sort(animals);
        }
    }
}
s