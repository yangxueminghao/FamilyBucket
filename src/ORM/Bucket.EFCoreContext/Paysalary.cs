using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysalary
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Month { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int? PayType { get; set; }
        public DateTime PayTime { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public string ExlUrl { get; set; }
        public string Remark { get; set; }
        public sbyte IsReissue { get; set; }
        public string MemberUrl { get; set; }
        public string MemName { get; set; }
    }
}
