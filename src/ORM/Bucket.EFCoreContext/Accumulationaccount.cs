using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Accumulationaccount
    {
        public string AccumulationAccountId { get; set; }
        public string AccumulationAccountName { get; set; }
        public decimal EnterprisePercent { get; set; }
        public decimal PersonPercent { get; set; }
        public sbyte IsEnabled { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? IsActive { get; set; }
    }
}
