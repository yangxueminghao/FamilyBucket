using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkAccount
    {
        public Guid Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string UnitName { get; set; }
        public string BranchId { get; set; }
        public string DetailAddress { get; set; }
        public Guid UserId { get; set; }
        public string BillDate { get; set; }
        public string ReductionDate { get; set; }
        public string WriteOffDate { get; set; }
        public sbyte? IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
