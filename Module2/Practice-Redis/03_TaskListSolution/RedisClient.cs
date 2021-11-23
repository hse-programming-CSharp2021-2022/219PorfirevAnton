using System;
using StackExchange.Redis;

namespace TaskListSolution
{
    public static class RedisClient
    {
        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString = "localhost")
        {
            redis = ConnectionMultiplexer.Connect("redis-14961.c296.ap-southeast-2-1.ec2.cloud.redislabs.com:14961,password=wmB5TzBa2Y6kGgh01GA6AnfSRghfVkUC,ConnectTimeout=10000,allowAdmin=true");
            database = redis.GetDatabase();
        }

        public static string GetSet(string key, string value)
        {
            return database.StringGetSet(key, value);
        }

        public static bool Exist(string key)
        {
            return database.KeyExists(key);
        }

        public static void Set(string key, string value)
        {
            database.StringSet(key, value);
        }
        public static string Get(string key)
        {
            return database.StringGet(key);
        }
    }
}