using System;
using System.Text;
namespace Task01
{
    class Creature
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public Creature(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }
        public virtual string Run()
        {
            return $"I am running with a speed of {Speed}.";
        }
        public override string ToString()
        {
            return $"My name is {Name}. Also " + this.Run();
        }
    }
    class Dwarf : Creature
    {
        public int Strength { get; set; }
        public Dwarf(string name, double speed, int strength) : base(name, speed)
        {
            if (strength >= 1 && strength <= 20)
            {
                Strength = strength;
            }
            else
            {
                Random rnd = new Random();
                Strength = rnd.Next(5, 21);
            }
        }
        public override string Run()
        {
            return base.Run() + $" My strength is {Strength}";
        }
        public void MakeNewStaff()
        {
            Console.WriteLine("I've created a new staff!");
        }
    }
    class Elf : Creature
    {
        public int Age { get; set; }
        public Elf(string name, double speed, int age) : base(name, speed)
        {
            if (age >= 100 && age <= 200)
            {
                Age = age;
            }
            else
            {
                Random rnd = new Random();
                Age = rnd.Next(5, 21);
            }
            if (Age >= 77 * 2)
            {
                Speed++;
            }
        }
        public override string Run()
        {
            return base.Run();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите кол-во существ: ");
                int.TryParse(Console.ReadLine(), out int n);
                Creature[] arr = new Creature[n];
                for (int i = 0; i < n; ++i)
                {
                    Random rnd = new Random();
                    int c = rnd.Next(1, 11);
                    StringBuilder name = new StringBuilder();
                    name.Append((char)rnd.Next('A', 'Z' + 1));
                    int len = rnd.Next(2, 10);
                    for (int j = 0; j < len; ++j)
                    {
                        int big = rnd.Next(0, 2);
                        if (big == 0)
                        {
                            name.Append((char)rnd.Next('A', 'Z' + 1));
                        }
                        else
                        {
                            name.Append((char)rnd.Next('a', 'z' + 1));
                        }
                    }
                    double speed = rnd.NextDouble() * 8 + 10;
                    int strength = rnd.Next(-50, 50);
                    int age = rnd.Next(100, 201);
                    if (c <= 2)
                    {
                        arr[i] = new Creature(name.ToString(), speed);
                    }
                    else if (c <= 6)
                    {
                        arr[i] = new Dwarf(name.ToString(), speed, strength);
                    }
                    else
                    {
                        arr[i] = new Elf(name.ToString(), speed, age);
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    Console.WriteLine(arr[i]);
                }
                for (int i = 0; i < n; ++i)
                {
                    if (arr[i] is Dwarf)
                    {
                        (arr[i] as Dwarf).MakeNewStaff();
                    }
                }
                Console.WriteLine("Press ENTER");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
