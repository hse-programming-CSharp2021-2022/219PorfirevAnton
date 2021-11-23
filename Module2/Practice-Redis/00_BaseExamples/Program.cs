using System;
using System.Linq;
using StackExchange.Redis;

namespace _BaseExamples
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string connectionString = "redis-14961.c296.ap-southeast-2-1.ec2.cloud.redislabs.com";
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis-14961.c296.ap-southeast-2-1.ec2.cloud.redislabs.com:14961,password=wmB5TzBa2Y6kGgh01GA6AnfSRghfVkUC,ConnectTimeout=10000,allowAdmin=true");
            IDatabase database = redis.GetDatabase();
            IServer server = redis.GetServer(connectionString, 14961);

            database.StringSet("test 1", "value 1");
            database.StringSet("test 2", "value 2");

            string str1 = database.StringGet("test 1");
            if (database.KeyExists("test 3"))
            {
                string str3 = database.StringGet("test 3");
                Console.WriteLine(str3);
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine(str1);
        }
    }
}
