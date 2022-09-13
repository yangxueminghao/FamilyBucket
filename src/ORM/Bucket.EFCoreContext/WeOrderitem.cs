using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeOrderitem
    {
        public string ItemId { get; set; }
        public Guid OrderId { get; set; }
        public Guid? UserId { get; set; }
        public string MealId { get; set; }
        public decimal MealPrice { get; set; }
        public int MealCount { get; set; }
        public decimal Amount { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateSend { get; set; }
        public int? IsSend { get; set; }
        public decimal? ExtraAmount { get; set; }
        public sbyte IsSet { get; set; }
        public sbyte SendTye { get; set; }
        public DateTime? SendTime { get; set; }
        public int? ItemType { get; set; }
    }
}
