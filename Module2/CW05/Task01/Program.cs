using System;

namespace Task01
{
    abstract class Animal
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        abstract public string AnimalSound();
        abstract public string AnimalInfo();
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Кличка: {Name}, Возраст: {Age}, Звук: {AnimalSound()}";
        }
    }
    class Dog : Animal
    {
        public Dog(string name, int age, string type, bool isTrained) : base(name, age) { Type = type;  IsTrained = isTrained; }
        public string Type { get; set; }
        public bool IsTrained { get; set; }
        public override string AnimalSound()
        {
            return "Гав";
        }
        public override string AnimalInfo()
        {
            string tr = IsTrained ? "Да" : "Нет";
            return this.ToString() + $", Парода: {Type}, Тренированная ли: {tr}";
        }
    }
    class Cow : Animal
    {
        public Cow(string name, int age, int countMilk) : base(name, age) { CountMilk = countMilk; }
        public int CountMilk { get; set; }
        public override string AnimalSound()
        {
            return "Му";
        }
        public override string AnimalInfo()
        {
            return this.ToString() + $", Кол-во молока: {CountMilk}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Шарик", 3, "Бульдог", true);
            Cow c = new Cow("Мурка", 5, 10);
            Console.WriteLine(d.AnimalInfo());
            Console.WriteLine(c.AnimalInfo());
        }
    }
}
