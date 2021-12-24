using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bucket.MongoDbContext.Mongo
{
    public class MongoDbContextFactory : IMongoDbContextFactory
    {
        private readonly IEnumerable<BucketMongoClient> _clients;
        public MongoDbContextFactory(IEnumerable<BucketMongoClient> clients)
        {
            _clients = clients;
        }

        public BucketMongoClient Get(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            var dbContext = _clients.FirstOrDefault(it => it.DbName.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (dbContext == null)
                throw new ArgumentException("can not find a match mongodbcontext!");

            return dbContext;
        }
    }
}
