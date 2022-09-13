using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoPrecharge
    {
        public Guid Id { get; set; }
        public string ProductNo { get; set; }
        public string City { get; set; }
        public int? InsuredCategory { get; set; }
        public int? BeginMouth { get; set; }
        public int? EndMouth { get; set; }
        public decimal Percentage { get; set; }
        public sbyte PreCharge { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsActive { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
