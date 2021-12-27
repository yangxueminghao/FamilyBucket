using Bucket.MongoDbContext.Mongo;
using Bucket.MongoDbContext.Test.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace Bucket.MongoDbContext.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsertOne()
        {
            var ser = Init<Student>();
            for (int i = 0; i < 100; i++)
            {
                var std = new Student { Age = i, Name = $"zhang{i}" };
                ser.InsertOne(std);
            }

        }

        [Fact]
        public void TestUpdateOne()
        {

            var ser = Init<Student>();
            //var filter = Builders<Student>.Filter.Where(p => p.Id == 1);
            //var update = Builders<Student>.Update.Set(p => p.Name, "ajsdafskdlajf");
            var result = ser.UpdateOne<string>(p => p.Age == 15, p => p.Name, "lisi");
        }

        [Fact]
        public void TestDeleteOne()
        {
            //var filter = Builders<Student>.Filter.Where(p => p.Id == 1);
            var ser = Init<Student>();
            var result = ser.DeleteOne(p => p.Age == 6);
        }

        [Fact]
        public void TestQuery()
        {
            Expression<Func<Student, bool>> filter = p => (p.Age == 5 || p.Age == 8) && p.Tags.Contains("good");
            var ser = Init<Student>();
            var result = ser.Query(filter).OrderByDescending(p => p.Id).ToList();
            Assert.NotNull(result);
        }
        public IMongoDbRepository<T> Init<T>() where T : class, new()
        {
            var services = new ServiceCollection();

            var conBuilder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json", true, true);
            var con = conBuilder.Build();
            services.AddSingleton<IConfiguration>(con);
            services.AddMongoDbContext()
                .AddMongoDbRepository();
            var ser = services.BuildServiceProvider().GetService<IMongoDbRepository<T>>();
            return ser;

        }
        [Theory]
        [InlineData("bj", "shanghai")]
        [InlineData("changsha", "wuhan")]
        public void TestInsertBson(string addr1, string addr2)
        {
            var ser = Init<BsonDocument>();
            BsonDocument bson = new BsonDocument()
            {
                { "address",new BsonArray{ addr1, addr2 } },

                { "name","li"+addr1}
            };
            ser.InsertOne(bson);
            Assert.Equal(1,1);
        }
    }
}
