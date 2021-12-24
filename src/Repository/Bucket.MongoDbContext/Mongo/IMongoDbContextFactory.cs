using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket.MongoDbContext.Mongo
{
   public interface IMongoDbContextFactory
    {
        BucketMongoClient Get(string name);
    }
}
