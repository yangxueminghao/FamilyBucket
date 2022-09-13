using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Socialpolicydetail
    {
        public string Pkid { get; set; }
        public int PolicyDetailId { get; set; }
        public string PolicyId { get; set; }
        public string InsuredCategory { get; set; }
        public decimal EntBasicLowerLimit { get; set; }
        public decimal EntBasicUpperLimit { get; set; }
        public decimal EntPercent { get; set; }
        public decimal EntMinMoney { get; set; }
        public int EntDigit { get; set; }
        public int EntValueType { get; set; }
        public decimal PersonalBasicLowerLimit { get; set; }
        public decimal PersonalBasicUpperLimit { get; set; }
        public decimal PersonalPercent { get; set; }
        public decimal PersonalMinMoney { get; set; }
        public int PersonalDigit { get; set; }
        public int PersonalValueType { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int PaymentCycle { get; set; }
        public string AnnualFeeMonth { get; set; }
        public sbyte IsPayBack { get; set; }
    }
}
