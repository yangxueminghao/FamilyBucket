using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class VUnpaidorder
    {
        public string Oid { get; set; }
        public long BusinessType { get; set; }
        public string MealName { get; set; }
        public string OrderNumber { get; set; }
        public long? OrderType { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid? UserId { get; set; }
        public int PayStatus { get; set; }
        public long Canceled { get; set; }
        public long PayType { get; set; }
    }
}
