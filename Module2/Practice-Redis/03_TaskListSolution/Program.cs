using System;

namespace TaskListSolution
{
    // Сиквел.
    // Разработчики из HSE company просят доработать ваше приложение!
    // Дело в том, что разработчики тоже ошибаются, и приходится откатывать приложение к предыдущей версии.
    // К тому же, HSE company не хочет расходовать много памяти,
    // поэтому было принято решение хранить только определенное колличество последних версий приложений.
    // 
    // На вход программе подаются запросы следующего типа:
    // 1) add <application_name> <version> - добавить актуальную версию приложения.
    // 2) back <application_name> - откатить приложение до предыдущей версии. Если предыдущей нет, то удалить приложение.
    // 3) get <application_name> - получить актуальную версию приложения. Если приложения нет, то сообщить об этом.
    // 4) exit - завершить программу.
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RedisClient.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            string query;
            while (true)
            {
                Console.WriteLine("input: ");
                query = Console.ReadLine();

                string[] inputLines = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = inputLines[0];
                if(command == "exit")
                {
                    return;
                }
                string application_name = inputLines[1];
                if(command == "add")
                {
                    string version = inputLines[2];
                    if (RedisClient.Exist(application_name))
                    {
                        RedisClient.Set(application_name + "back", RedisClient.Get(application_name));
                    }
                    RedisClient.Set(application_name, version);
                }
                else if(command == "back")
                {
                    RedisClient.Set(application_name, RedisClient.Get(application_name + "back"));
                }
                else
                {
                    Console.WriteLine(RedisClient.Get(application_name));
                }
                /*
                if (RedisClient.Exist(name))
                {
                    Console.WriteLine(RedisClient.Get(name));
                    Console.WriteLine(RedisClient.GetSet(name, newVersion));
                }
                else
                {
                    RedisClient.Set(name, newVersion);
                    Console.WriteLine("newVersion set");
                }
                */
            }
        }
    }
}