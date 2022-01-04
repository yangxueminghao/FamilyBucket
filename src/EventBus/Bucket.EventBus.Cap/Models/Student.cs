using Microsoft.AspNetCore.Mvc.ModelBinding;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Bucket.EventBus.Cap.Models
{
    [Table("Student")]
    public class Student
    {
        //[BsonRepresentation(BsonType.ObjectId)]
        //[BindNever]
        //public string Id { get; set; }
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public sbyte Sex { get; set; }
    }
}
