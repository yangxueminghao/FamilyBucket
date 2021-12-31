using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Bucket.MongoDbContext.Test.Model
{
    public class Student
    {
        [BsonRepresentation(BsonType.ObjectId)]       
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string[] Tags { get; set; } = { "good", "like" };
    }
}
