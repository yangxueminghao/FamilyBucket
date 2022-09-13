using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class RoMeal
    {
        public string MealId { get; set; }
        public string MealName { get; set; }
        public int CountLimit { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal ActualPrice { get; set; }
        public string EffectiveType { get; set; }
        public int EffectiveDays { get; set; }
        public sbyte IsActive { get; set; }
        public sbyte IsShow { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
