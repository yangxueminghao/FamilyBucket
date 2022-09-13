using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salarydiscount
    {
        public int Id { get; set; }
        public string MealId { get; set; }
        public string MealName { get; set; }
        public Guid? UserId { get; set; }
        public decimal Discount { get; set; }
        public DateTime DiscountBeginT { get; set; }
        public DateTime DiscountEndT { get; set; }
        public DateTime CreateTime { get; set; }
        public int? DiscountType { get; set; }
    }
}
