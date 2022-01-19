using Dapper.Contrib.Extensions;
using System;

namespace FamilyBucket.Aop.Client.Model
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public sbyte Sex { get; set; }
        public int ClassId { get; set; }
    }
}
