using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeMeal
    {
        public string MealId { get; set; }
        public string MealType { get; set; }
        public string MealCode { get; set; }
        public string MealName { get; set; }
        public int? FestivalId { get; set; }
        public decimal MealPrice { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string MealUrl { get; set; }
        public sbyte IsActive { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
