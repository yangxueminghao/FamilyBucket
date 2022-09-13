using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class RoCustomerinfo
    {
        public string Id { get; set; }
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }
        public string MealId { get; set; }
        public int RemainCount { get; set; }
        public int IsValid { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public sbyte IsUse { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
