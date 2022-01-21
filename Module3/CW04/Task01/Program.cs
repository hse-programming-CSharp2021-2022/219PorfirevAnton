using System;

public class MyEventArgs: EventArgs
{
    public string Str { get; set; }
    public MyEventArgs(string s) => Str = s;
}
public class UIString
{
    string str = "Default text";
    public string Str { get { return str; } private set { str = value; } }
    public void NewStringValueHappendHandler(object sender, MyEventArgs e)
    {
        str = e.Str;
    }
}

class ConsoleUI
{
    event EventHandler<MyEventArgs> NewStringValueHappend;
    UIString s = new UIString(); // специальная строка
    public UIString S { get { return s; } set { s = value; } }
    public void GetStringFromUI()
    {
        Console.Write("Введите новое значение строки: ");
        string str = Console.ReadLine();
        NewStringValueHappend?.Invoke(this, new MyEventArgs(str));
        RefreshUI();
    }
    public void CreateUI()
    {
        NewStringValueHappend += s.NewStringValueHappendHandler;
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