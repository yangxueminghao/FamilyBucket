using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;
using Bucket.Caching.Extensions;
using Bucket.Caching.StackExchangeRedis;
using Bucket.Caching.Abstractions;
using Bucket.Cache.StackExchangeRedis.Test.Model;
using Bucket.Extensions;
using System.Linq;
using System.Text.Json;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Bucket.Caching.StackExchangeRedis.Abstractions;
using StackExchange.Redis;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

namespace Bucket.Cache.StackExchangeRedis.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestRedis()
        {
            var services = Init();
            var service = services.BuildServiceProvider().GetRequiredService<ICachingProvider>();
            for (int i = 0X41; i < 0X5A; i++)
            {
                string key = Convert.ToChar(i).ToString();
                service.Set<string>(key, "张三" + i, TimeSpan.FromDays(1));
                service.Get<string>(key);
            }


        }
        [Fact]
        public void TestRedisFeature()
        {
            var services = Init();
            var service = services.BuildServiceProvider().GetRequiredService<IRedisCachingProvider>();
            StringBuilder sb = new StringBuilder();

            bool isSuc = true;
            for (int i = 1; i < 20; i++)
            {
                Student student = new Student { Id = i, Name = "李四" + new Random().Next(20 * i, 200 * i), Birthday = DateTime.Now.AddDays(6000) };
                isSuc = service.HMSet(nameof(Student) + i, student.ToDic().ToDictionary(k => k.Key, v => v.Value.ToString()));
            }
            for (int i = 1; i < 20; i++)
            {
                Student student = service.HGetAll(nameof(Student) + i).ToDictionary(k => k.Key, v => (object)v.Value).ToEntity<Student>();
                sb.Append(JsonSerializer.Serialize(student, new JsonSerializerOptions()
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                }));
            }
            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisPipeline()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();

            bool isSuc = true;
            var database = redis.GetDatabase();
            var batch = database.CreateBatch();
            batch.StringSetAsync("a", "asjghsd");
            batch.StringSetAsync("b", "ewqrweqr");
            batch.HashSetAsync("h1", "name", "zhafjads");
            batch.HashSetAsync("h1", "age", 34);
            batch.HashSetAsync("h2", "title", "sfdgfdsdfsdfhdf");
            batch.Execute();
            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisScript()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();

            bool isSuc = true;
            var database = redis.GetDatabase();
            const string script = "redis.call('set',@key,@value)";
            var lua = LuaScript.Prepare(script);
            database.ScriptEvaluate(lua, new { key = (RedisKey)"mykey", value = 123 });
            //database.ScriptEvaluate("redis.call('HMSET',@key,@value)", new RedisKey[] {"rediskey1" },new RedisValue[] { "id",123, "name", 456, "title", "lisi" });
            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisPub()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();

            bool isSuc = true;
            var database = redis.GetDatabase();
            var pub = database.Multiplexer.GetSubscriber();
            for (int i = 0; i < 100; i++)
            {
                pub.Publish("chanel1", "fdshgsfjkdgl" + i);
                Thread.Sleep(1000);
            }

            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisSub()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();

            bool isSuc = true;
            var database = redis.GetDatabase();
            {
                Task.Run(() =>
                {
                    var pub = database.Multiplexer.GetSubscriber();
                    for (int i = 0; i < 100; i++)
                    {
                        pub.Publish("chanel1", "fdshgsfjkdgl" + i);
                        Thread.Sleep(1000);
                    }
                });
            }
            var sub = database.Multiplexer.GetSubscriber();
            for (int i = 0; i < 100; i++)
            {
                sub.Subscribe("chanel1", (ch, v) =>
                {
                    sb.Append(v.ToString());
                    sb.AppendLine();
                });
                Thread.Sleep(1000);
            }

            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisTrans()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();

            var database = redis.GetDatabase();
            var tran = database.CreateTransaction();
            //tran.AddCondition(Condition.ListIndexEqual("zlh:1", 0, "zhanglonghao"));
            tran.ListRightPushAsync("zlh:1", "zhanglonghao2");
            tran.AddCondition(Condition.ListIndexNotEqual("zlh:1", 0, "zhanglonghao"));
            tran.ListRightPushAsync("zlh:1", "zhanglonghao3");
            bool committed = tran.Execute();

            Assert.True(committed);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisGeo()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();
            bool isSuc = true;
            var database = redis.GetDatabase();
            database.GeoAdd("sale", 116.325505, 39.923568, "beijing");
            database.GeoAdd("sale", 116.385297, 39.110897, "bazhou");
            database.GeoAdd("sale", 117.217774, 38.999724, "tianjin");
            database.GeoAdd("sale", 117.355754, 40.05403, "jzhou");
            database.GeoAdd("sale", 114.52717, 38.082192, "shijiazhang");
            var result = database.GeoRadius("sale", 116.382422, 39.923125, 100560.00);
            foreach (var item in result)
            {
                sb.AppendLine(item.Member);
            }
            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisStream()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();
            bool isSuc = true;
            var db = redis.GetDatabase();
            //var values = new NameValueEntry[]
            //{
            //    new NameValueEntry("sensor_id", "1234"),
            //    new NameValueEntry("temp", "19.8")
            //};
            List<NameValueEntry> list = new List<NameValueEntry>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new NameValueEntry("temp" + i, i));
            }
            var messageId = db.StreamAdd("sensor_stream", list.ToArray());
            //读取 messageId="0-0"的 stream 中的'所有'消息。
            var messages = db.StreamRead("sensor_stream", "0-0");
            foreach (var item in messages)
            {
                foreach (var subitem in item.Values)
                {
                    sb.AppendLine(JsonSerializer.Serialize(new { Name = subitem.Name.ToString(), Value = subitem.Value.ToString() }));
                }

            }
            //db.StreamDelete("sensor_stream");
            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestRedisCluster()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            StringBuilder sb = new StringBuilder();
            bool isSuc = true;
            var db = redis.GetDatabase();

            for (int i = 0; i < 100; i++)
            {
                db.StringSet("keywetwertwer" + i, i, flags: CommandFlags.DemandMaster);
            }

            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

        }
        [Fact]
        public void TestBitmap()
        {
            var services = Init();
            var redis = services.BuildServiceProvider().GetRequiredService<IRedisDatabaseProvider>();
            var database = redis.GetDatabase();
            Student student = new Student();
            student.Id = 10000;
            //Random random = new Random();
            var key = $"usersign:{DateTime.Now.Year }:{student.Id}";
            for (int i = 0; i < 100; i++)
            {
                database.StringSetBit(key, DateTime.Now.DayOfYear + i, true);
            }
            int count = 0;
            for (int i = 99; i > -1; i--)
            {
                bool isTrue = database.StringGetBit(key, DateTime.Now.DayOfYear + i);
                if (isTrue)
                {
                    count++;
                }
                
            }

            Assert.True(count == 100);

        }
        public IServiceCollection Init()
        {

            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            services.AddCaching(cacheBuilder =>
            {
                cacheBuilder.UseStackExchangeRedis();
            });
            return services;
        }
    }
}
