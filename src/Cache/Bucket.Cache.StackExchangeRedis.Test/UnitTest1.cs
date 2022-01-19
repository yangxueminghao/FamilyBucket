using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;
using Bucket.Caching.Extensions;
using Bucket.Caching.StackExchangeRedis;
using Bucket.Caching.Abstractions;

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
                service.Set<string>(key, "fdsgdfg"+i, TimeSpan.FromDays(1));
                service.Get<string>(key);
            }
            
            
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
