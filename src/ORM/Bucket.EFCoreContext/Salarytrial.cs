using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salarytrial
    {
        public string Id { get; set; }
        public Guid UserId { get; set; }
        public int RemainCount { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Pays { get; set; }
        public string Phone { get; set; }
        public sbyte IsBuy { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
