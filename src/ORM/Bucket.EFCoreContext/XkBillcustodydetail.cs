using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkBillcustodydetail
    {
        public Guid DetailId { get; set; }
        public Guid BillId { get; set; }
        public string AccountNumber { get; set; }
        public int PeopleAcount { get; set; }
        public int PeopleTimes { get; set; }
        public decimal? BasicServicePay { get; set; }
        public decimal? PeopleServicePay { get; set; }
        public decimal? AddServicePay { get; set; }
        public decimal ServerPay { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
