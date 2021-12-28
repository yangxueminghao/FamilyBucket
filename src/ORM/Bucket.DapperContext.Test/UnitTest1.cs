using Bucket.DapperContext.Dapper;
using Bucket.DapperContext.Test.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Bucket.DapperContext.Test
{
    public class UnitTest1
    {
        public IDapperDbRepository<T> Init<T>() where T : class, new()
        {
            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            services.AddDapperDbContext()
                .AddDapperDbRepository();
            var ser = services.BuildServiceProvider().GetService<IDapperDbRepository<T>>();
            return ser;

        }
        [Theory]
        [InlineData("bj")]
        [InlineData("changsha")]
        public void TestInsert(string name)
        {
            var stu = new Student { Name = name };
            var ser = Init<Student>();

            ser.Insert(stu);
            Assert.Equal(1, 1);
        }
    }
}
