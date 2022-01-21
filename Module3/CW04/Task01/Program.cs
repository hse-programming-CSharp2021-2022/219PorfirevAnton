class ConsoleUI
{
    UIString s = new UIString(); // специальная строка
    public UIString S { get { return s; } set { s = value; } }
    public void GetStringFromUI()
    {
        Console.Write("Введите новое значение строки: ");
        string str = Console.ReadLine();
        RefreshUI();
    }
    public void CreateUI()
    {
        RefreshUI();
    }
    public void RefreshUI()
    {      // обновление строки     
        Console.Clear();
        Console.WriteLine("Текст строки: " + s.Str);
    }
}
class Program
{
    static void Main(string[] args)
    {
        ConsoleUI c = new ConsoleUI();
        c.CreateUI(); // запускаем выполнение объекта класса ConsoleUI
        do
        {
            c.GetStringFromUI();  // изменяем значение строки
            Console.WriteLine("Чтобы закончить эксперименты, нажмите ESC...");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}