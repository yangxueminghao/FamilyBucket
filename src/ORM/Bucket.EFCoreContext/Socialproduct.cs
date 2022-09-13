using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Socialproduct
    {
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        public string City { get; set; }
        public string CostCenterCostCenterNo { get; set; }
        public decimal? SellPrice { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public sbyte IsEffect { get; set; }
        public sbyte IsEnabled { get; set; }
    }
}
