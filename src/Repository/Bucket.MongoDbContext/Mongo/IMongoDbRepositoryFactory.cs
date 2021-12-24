using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket.MongoDbContext.Mongo
{
   public interface IMongoDbRepositoryFactory
    {
        IMongoDbRepository<TEntity> Get<TEntity>() where TEntity : class, new();
    }
}
