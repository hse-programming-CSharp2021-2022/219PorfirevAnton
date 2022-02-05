using System;

namespace Task01
{
    struct Person: IComparable<Person>
    {
        string name;
        string lastname;
        int age;
        public Person(string name, string lastname, string tryAge)
        {
            this.name = name;
            this.lastname = lastname;
            if(!int.TryParse(tryAge, out this.age) || this.age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int CompareTo(Person other)
        {
            if (age < other.age)
            {
                return -1;
            }
            return 1;
        }
        public override string ToString()
        {
            return $"{name} {lastname}, age = {age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Person[] characters = new Person[n];
            Random rnd = new Random();
            string[] names = { "Боба", "Энакин", "Оби-ван", "Джаба", "Хан", "Кед", "Дарт" };
            string[] lastnames = { "Фет", "Скайуокер", "Кеноби", "Хат", "Соло", "Бейн", "Мол" };
            for (int i = 0; i < n; ++i)
            {
                int age = rnd.Next(1, 101);
                int index = rnd.Next(0, 7);
                string name = names[index];
                string lastname = lastnames[index];
                characters[i] = new Person(name, lastname, age.ToString());
            }
            Array.ForEach(characters, (Person character) => Console.WriteLine(character));
            Console.WriteLine();
            Array.Sort(characters);
            Array.ForEach(characters, (Person character) => Console.WriteLine(character));
        }
    }
}
