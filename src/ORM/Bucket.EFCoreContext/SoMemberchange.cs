using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoMemberchange
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public int ChangeType { get; set; }
        public int? ApplyType { get; set; }
        public sbyte IsChangeInsureDate { get; set; }
        public string DetailJsonOld { get; set; }
        public string DetailJsonNew { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
        public Guid CreateUserId { get; set; }
        public string ToFynRemark { get; set; }
    }
}
