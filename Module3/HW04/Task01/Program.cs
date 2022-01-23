using System;

namespace Task01
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public string Message { get; set; }
        public RingIsFoundEventArgs(string s) => Message = s;
    }
    public abstract class Creature
    {
        public string Name { get; set; }
        public Creature(string name, string location)
        {
            Name = name;
            Location = location;
        }
        public string Location { get; set; }
        public abstract void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e);
    }
    public class Wizard : Creature
    {
        public Wizard(string name, string location) : base(name, location) { }
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
    public class Hobbit : Creature
    {
        public Hobbit(string name, string location) : base(name, location) {}

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
            Location = e.Message;
        }
    }
    public class Human : Creature
    {
        public Human(string name, string location) : base(name, location) { }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
            Location = e.Message;
        }
    }
    public class Elf : Creature
    {
        public Elf(string name, string location) : base(name, location) { }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
            Location = e.Message;
        }
    }
    public class Dwarf : Creature
    {
        public Dwarf(string name, string location) : base(name, location) { }

        public override void RingIsFoundEventHandlerMethod(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
            Location = e.Message;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Creature[] mainCharacters = new Creature[8];
            Wizard gendalf = new Wizard("Гендальф", "Изенгард");
            string[] hobbitNames = { "Фродо", "Сэм", "Пипин", "Мэрри" };
            for(int i = 0; i < 4; ++i)
            {
                mainCharacters[i] = new Hobbit(hobbitNames[i], "Шир");
            }
            mainCharacters[4] = new Human("Боромир", "Гондор");
            mainCharacters[5] = new Human("Арагорн", "Горцующий Пони");
            mainCharacters[6] = new Dwarf("Гимли", "Эрибор");
            mainCharacters[7] = new Elf("Леголас", "Лихолесье");
            foreach(var character in mainCharacters)
            {
                gendalf.RaiseRingIsFoundEvent += character.RingIsFoundEventHandlerMethod;
            }
            gendalf.SomeThisIsChangedInTheAir();
        }
    }
}
