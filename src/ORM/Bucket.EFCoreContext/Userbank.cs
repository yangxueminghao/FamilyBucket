using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Userbank
    {
        public int RowId { get; set; }
        public string OpenName { get; set; }
        public string OpenBank { get; set; }
        public string BankName { get; set; }
        public string BankAccount { get; set; }
        public int Deleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid UserUserId { get; set; }
        public sbyte IsDefault { get; set; }
    }
}
