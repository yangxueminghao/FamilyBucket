using Bucket.Cache.StackExchangeRedis.Test.Model;
using Bucket.Caching.Abstractions;
using Bucket.Caching.Codec.MessagePack;
using Bucket.Caching.Codec.ProtoBuffer;
using Bucket.Caching.Extensions;
using Bucket.Caching.Implementation;
using Bucket.Caching.StackExchangeRedis;
using Bucket.Caching.StackExchangeRedis.Abstractions;
using Bucket.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Bucket.Cache.StackExchangeRedis.Test
{
    public class SerializationTest
    {
        [Fact]
        public void TestSerialize()
        {
            var services = Init();
            var service = services.BuildServiceProvider().GetRequiredService<ICachingSerializer>();
            Student std = new Student { Name = "zhagf", Birthday = DateTime.Now, Sex = 23 };

            var bytes = service.Serialize(std);
            var std0 = service.Deserialize<Student>(bytes);
            Assert.Equal(std, std0);

            var services2 = Init2();
            var service2 = services2.BuildServiceProvider().GetRequiredService<ICachingSerializer>();
            var bytes2 = service2.Serialize(std);
            var std20 = service2.Deserialize<Student>(bytes2);
            var byteStr = Encoding.ASCII.GetString(bytes);
            var byteStr2 = Encoding.ASCII.GetString(bytes2);
            var byteStr8 = Encoding.UTF8.GetString(bytes);
            var byteStr82 = Encoding.UTF8.GetString(bytes2);

            Assert.Equal(std, std20);
            Assert.Equal(std0, std20);
            Assert.True(bytes.Length - bytes2.Length < 0);


            var services3 = Init3();
            var service3 = services3.BuildServiceProvider().GetRequiredService<ICachingSerializer>();
            var bytes3 = service3.Serialize(std);
            var std30 = service3.Deserialize<Student>(bytes3);

            var byteStr3 = Encoding.ASCII.GetString(bytes3);

            Assert.Equal(std, std30);
            Assert.Equal(std0, std30);
            Assert.True(bytes3.Length - bytes.Length < 0);
        }

        public IServiceCollection Init()
        {
            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            //services.AddSingleton<ICachingSerializer, DefaultProtoBufferSerializer>();
            //services.AddSingleton<ICachingSerializer, DefaultJsonCachingSerializer>();
            services.AddSingleton<ICachingSerializer, DefaultMessagePackSerializer>();
            return services;
        }

        public IServiceCollection Init2()
        {
            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            //services.AddSingleton<ICachingSerializer, DefaultProtoBufferSerializer>();
            services.AddSingleton<ICachingSerializer, DefaultJsonCachingSerializer>();
            //services.AddSingleton<ICachingSerializer, DefaultMessagePackSerializer>();
            return services;
        }

        public IServiceCollection Init3()
        {
            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            services.AddSingleton<ICachingSerializer, DefaultProtoBufferSerializer>();
            //services.AddSingleton<ICachingSerializer, DefaultJsonCachingSerializer>();
            //services.AddSingleton<ICachingSerializer, DefaultMessagePackSerializer>();
            return services;
        }
    }
}
