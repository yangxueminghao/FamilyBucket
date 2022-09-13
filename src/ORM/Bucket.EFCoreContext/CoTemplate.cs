using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class CoTemplate
    {
        public string TempId { get; set; }
        public string Name { get; set; }
        public decimal BaseAmount { get; set; }
        public decimal CouponAmount { get; set; }
        public int Type { get; set; }
        public DateTime? BeginTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Days { get; set; }
        public int Platform { get; set; }
        public string UsedBusiness { get; set; }
        public string Explain { get; set; }
        public string Remark { get; set; }
        public sbyte IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
