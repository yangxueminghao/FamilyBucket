using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkPolicy
    {
        public long PolicyId { get; set; }
        public string PolicyNumber { get; set; }
        public string BranchId { get; set; }
        public string BranchDistrict { get; set; }
        public string AccountId { get; set; }
        public string UnitName { get; set; }
        public string PolicyName { get; set; }
        public string InsuranceType { get; set; }
        public sbyte IsActive { get; set; }
        public string StartMonth { get; set; }
        public int? Source { get; set; }
        public string Remark { get; set; }
        public string AttachAddress { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
