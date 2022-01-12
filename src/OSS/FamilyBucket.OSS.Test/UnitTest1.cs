using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnceMi.AspNetCore.OSS;
using System;
using Xunit;
using System.IO;

namespace FamilyBucket.OSS.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("shanghai")]
        [InlineData("wuhan")]
        public void TestOSS(string bucketName)
        {
            var services = Init();
            services.AddLogging();
            services.AddOSS();
            IOSSServiceFactory oSSServiceFactory = services.BuildServiceProvider().GetService<IOSSServiceFactory>();
            IOSSService _OSSService = oSSServiceFactory.Create();
            _OSSService.CreateBucketAsync(bucketName);
            var result = _OSSService.ListBucketsAsync().Result;
            var isUplod=_OSSService.PutObjectAsync(bucketName, "myfile", File.OpenRead(@"D:\备份文件\d23fcea51d98587ef7e50d58955557c.png")).Result;
            Assert.NotNull(result);
        }
        public IServiceCollection Init()
        {

            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            return services;
        }
    }
}
