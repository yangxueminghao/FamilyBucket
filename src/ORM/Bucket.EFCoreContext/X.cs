using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class X
    {
        public Guid PakcageId { get; set; }
        public string PackageName { get; set; }
        public int? ServiceCount { get; set; }
        public decimal Price { get; set; }
        public int? SalesCount { get; set; }
        public DateTime? DateExpired { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int Status { get; set; }
        public string Poster { get; set; }
        public int? PackageType { get; set; }
        public int? IsBackPay { get; set; }
        public int PackageSort { get; set; }
        public sbyte IsNewServiceType { get; set; }
    }
}
