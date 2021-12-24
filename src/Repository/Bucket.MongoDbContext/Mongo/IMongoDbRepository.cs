using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bucket.MongoDbContext.Mongo
{
   public interface IMongoDbRepository<T> where T : class, new()
    {
        void InsertOne(T model);
        UpdateResult UpdateOne<T1>(Expression<Func<T, bool>> exp, Expression<Func<T, T1>> updateExp, T1 valuee);
        DeleteResult DeleteOne(Expression<Func<T, bool>> exp);
        IEnumerable<T> Query(Expression<Func<T, bool>> exp);
    }
}
