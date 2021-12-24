using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Bucket.MongoDbContext.Mongo
{
    public class MongoDbRepository<T> : IMongoDbRepository<T> where T : class, new()
    {
        private readonly IEnumerable<BucketMongoClient> _clients;
        private BucketMongoClient DbContext { get; set; }
        private IMongoCollection<T> Collection { get; set; }

        public MongoDbRepository(IEnumerable<BucketMongoClient> clients)
        {
            _clients = clients;
            DbContext = _clients.FirstOrDefault();
            Collection = DbContext.GetDatabase(DbContext.DbName).GetCollection<T>(typeof(T).Name);
        }
        public void InsertOne(T model)
        {
            Collection.InsertOne(model);
        }
        public UpdateResult UpdateOne<T1>(Expression<Func<T, bool>> exp, Expression<Func<T, T1>> updateExp, T1 value)
        {
            var filter = Builders<T>.Filter.Where(exp);

            var update = Builders<T>.Update.Set(updateExp, value);

            return Collection.UpdateOne(filter, update);
        }
        public DeleteResult DeleteOne(Expression<Func<T, bool>> exp)
        {
            var filter = Builders<T>.Filter.Where(exp);
            return Collection.DeleteOne(filter);
        }
        public IEnumerable<T> Query(Expression<Func<T, bool>> exp)
        {
            return Collection.AsQueryable<T>().Where(exp);
        }

    }
}
