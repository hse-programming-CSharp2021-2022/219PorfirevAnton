using System;

namespace TaskSetSolution
{
    // Сиквел.
    // У Склад.LIFE большое количество различных складов с различными видами товаров.
    // Руководству важно знать, какие виды товаров находятся на различных складах. Помогите Склад.LIFE. 
    // P.S. В последнее время с заказами все плохо, поэтому на склад только завозят новые виды товаров.
    //
    // На вход программе поступают следующие запросы:
    // 1) add <storage_name> <product_name> - добавить вид товара на склад.
    // 2) get <storage_name> - получить список всех видов товаров на складе.
    // 3) exist <storage_name> <product_name> - узнать находится ли вид товара на складе.
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
                if (command == "exit")
                {
                    return;
                }
                string storage_name = inputLines[1];
                if (command == "add")
                {
                    string product_name = inputLines[2];
                    string all = "";
                    if (RedisClient.Exist(storage_name))
                    {
                        RedisClient.Set(storage_name, RedisClient.Get(storage_name) + $", {product_name}");
                    }
                    else
                    {
                        RedisClient.Set(storage_name, product_name);
                    }
                }
                else if (command == "get")
                {
                    Console.WriteLine(RedisClient.Get(storage_name));
                }
                else
                {
                    string product_name = inputLines[2];
                    if (RedisClient.Exist(storage_name) && RedisClient.Get(storage_name).Contains(product_name))
                    {
                        Console.WriteLine("Лежит");
                    }
                    else
                    {
                        Console.WriteLine("Не лежит");
                    }
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