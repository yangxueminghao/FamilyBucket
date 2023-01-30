using ProtoBuf;
using System;

namespace Bucket.Cache.StackExchangeRedis.Test.Model
{
    [ProtoContract]
    public class Student
    {
        [ProtoMember(1)]
        public long Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public DateTime Birthday { get; set; }

        [ProtoMember(4)]
        public sbyte Sex { get; set; }

        [ProtoMember(5)]
        public int ClassId { get; set; }

        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());    
        }
    }
}
