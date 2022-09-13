using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salarymeal
    {
        public string Id { get; set; }
        public string MealName { get; set; }
        public int MealType { get; set; }
        public decimal MealPrice { get; set; }
        public int MealCount { get; set; }
        public sbyte IsValid { get; set; }
        public decimal? DiscountRate { get; set; }
        public DateTime? DisBeginTime { get; set; }
        public DateTime? DisEndTime { get; set; }
        public DateTime MealBtime { get; set; }
        public int MealMonth { get; set; }
        public DateTime? MealEndTime { get; set; }
        public DateTime? AddTime { get; set; }
        public sbyte IsShow { get; set; }
    }
}
