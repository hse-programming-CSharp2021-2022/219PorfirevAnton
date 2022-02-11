using System;

namespace Task02
{
    class Queue<T>
        where T: struct
    {
        T head;
        T tail;
        Queue<T> pred;
        Queue<T> next;
        public int Size { get; set; }
        public bool IsEmpty { get; set; }
        public Queue(T head, T tail, Queue<T> pred, Queue<T> next)
        {
            this.head = head;
            this.tail = tail;
            this.pred = pred;
            this.next = next;
            IsEmpty = false;
            Size = 1;
            if (pred != null)
                Size += pred.Size;
            if (next != null)
                Size += next.Size;
        }
        public Queue()
        {
            IsEmpty = true;
        }
        public Queue<T> Nqueue(T newValue)
        {
            if (IsEmpty)
            {
                return new Queue<T>(newValue, newValue, null, null);
            }
            return new Queue<T>(this.head, newValue, null, this);
        }
        public T Dequeue()
        {
            if (IsEmpty)
            {
                throw new ArgumentException();
            }
            T ans = head;
            if (next != null) 
            {
                head = next.head;
                next = next.next;
            }
            else
                IsEmpty = true;
            return ans;
        }
        public T Pick()
        {
            return head;
        }
    }
    struct Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}, LastName: {LastName}, Age: {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> persons = new Queue<Person>();
            for(int i = 0; i < 10; ++i)
            {
                persons = persons.Nqueue(new Person("A", "B", i));
            }
            for(int i = 0; i < 10; ++i)
            {
                Console.WriteLine(persons.Dequeue());
            }
        }
    }
}
