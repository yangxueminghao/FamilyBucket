using System;

namespace Bucket.Cache.StackExchangeRedis.Test.Model
{

    public class Student
    {
        
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public sbyte Sex { get; set; }
        public int ClassId { get; set; }

        public override bool Equals(object obj)
        {
            return this.ToString().Equals(obj.ToString());    
        }
    }
}
