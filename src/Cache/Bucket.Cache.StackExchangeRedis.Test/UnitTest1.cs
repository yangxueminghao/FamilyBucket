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

namespace Bucket.Cache.StackExchangeRedis.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestRedis()
        {
            var services = Init();
            var service=services.BuildServiceProvider().GetRequiredService<ICachingProvider>();
            for (int i = 0X41; i < 0X5A; i++)
            {
                string key = Convert.ToChar(i).ToString();
                service.Set<string>(key, "张三"+i, TimeSpan.FromDays(1));
                service.Get<string>(key);
            }
            
            
        }
        [Fact]
        public void TestRedisFeature()
        {
            var services = Init();
            var service = services.BuildServiceProvider().GetRequiredService<IRedisCachingProvider>();
            StringBuilder sb =new StringBuilder();
            
            bool isSuc = true;
            for (int i = 1; i < 20; i++)
            {
                Student student = new Student { Id=i, Name = "李四"+new Random().Next(20*i,200*i), Birthday = DateTime.Now.AddDays(6000) };
                isSuc = service.HMSet(nameof(Student)+i, student.ToDic().ToDictionary(k => k.Key, v => v.Value.ToString()));
            }
            for (int i = 1; i < 20; i++)
            {
                Student student = service.HGetAll(nameof(Student) + i).ToDictionary(k => k.Key, v =>(object) v.Value).ToEntity<Student>();
                sb.Append(JsonSerializer.Serialize(student,new JsonSerializerOptions() {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
                }));
            }
            Assert.True(isSuc);
            Assert.NotNull(sb.ToString());

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
