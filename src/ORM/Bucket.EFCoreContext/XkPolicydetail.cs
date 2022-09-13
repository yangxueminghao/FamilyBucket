using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkPolicydetail
    {
        public long PolicyDetailId { get; set; }
        public long PolicyId { get; set; }
        public sbyte IsNormal { get; set; }
        public int? Type { get; set; }
        public string Name { get; set; }
        public string StartMonth { get; set; }
        public int IsPeriod { get; set; }
        public string PeridStartMonth { get; set; }
        public string PeridEndMonth { get; set; }
        public decimal EntBasicUpperLimit { get; set; }
        public decimal EntBasicLowerLimit { get; set; }
        public decimal EntPercent { get; set; }
        public decimal EntMinMoney { get; set; }
        public decimal PersonalBasicUpperLimit { get; set; }
        public decimal PersonalBasicLowerLimit { get; set; }
        public decimal PersonalPercent { get; set; }
        public decimal PersonalMinMoney { get; set; }
        public string Remark { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
        public int? EnterpriseBitNumber { get; set; }
        public int? EnterpriseValueRule { get; set; }
        public int? PersonBitNumber { get; set; }
        public int? PersonValueRule { get; set; }
        public int? RepairMonth { get; set; }
        public int? PayType { get; set; }
        public string PayMonth { get; set; }
    }
}
