using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkServicefee
    {
        public Guid Id { get; set; }
        public string BranchId { get; set; }
        public int? ServiceItem { get; set; }
        public int TypeId { get; set; }
        public decimal? ServiceFee { get; set; }
        public int FeeType { get; set; }
        public int FeeUnit { get; set; }
        public DateTime BeginDate { get; set; }
        public sbyte IsActive { get; set; }
        public Guid? CreateUserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
