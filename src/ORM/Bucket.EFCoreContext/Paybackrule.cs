using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paybackrule
    {
        public int Id { get; set; }
        public string PolicyDetailId { get; set; }
        public sbyte IsCrossCycle { get; set; }
        public int? CycleStartYear { get; set; }
        public int? CycleStartMonth { get; set; }
        public int? CycleEndtyear { get; set; }
        public int? CycleEndtMonth { get; set; }
        public int? EnableMonthCount { get; set; }
    }
}
