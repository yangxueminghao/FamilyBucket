using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket.MongoDbContext.Mongo
{
   public class MongoDbRepositoryFactory : IMongoDbRepositoryFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public MongoDbRepositoryFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IMongoDbRepository<TEntity> Get<TEntity>() where TEntity : class, new()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                return scope.ServiceProvider.GetRequiredService<IMongoDbRepository<TEntity>>();
            }
        }
    }
}
