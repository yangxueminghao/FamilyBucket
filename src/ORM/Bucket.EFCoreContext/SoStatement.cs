using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoStatement
    {
        public Guid StatementId { get; set; }
        public string StatementNo { get; set; }
        public Guid UserId { get; set; }
        public string StatementName { get; set; }
        public string Month { get; set; }
        public int? Number { get; set; }
        public int? Times { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? EntServicePrice { get; set; }
        public decimal? OtherPrice { get; set; }
        public decimal? CouponAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string OtherFile { get; set; }
        public sbyte Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
