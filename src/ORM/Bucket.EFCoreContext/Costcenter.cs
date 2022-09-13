using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Costcenter
    {
        public string CostCenterNo { get; set; }
        public string City { get; set; }
        public sbyte IsDefault { get; set; }
        public string SocialAddDeadLine { get; set; }
        public string SocialReduceDeadLine { get; set; }
        public string AccumulationAddDeadLine { get; set; }
        public string AccumulationReduceDeadLine { get; set; }
        public sbyte IsEnabled { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string ChangeDescription { get; set; }
    }
}
