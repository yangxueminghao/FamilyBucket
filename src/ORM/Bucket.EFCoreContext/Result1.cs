using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Result1
    {
        public Guid MemberId { get; set; }
        public string MemberName { get; set; }
        public string Mobile { get; set; }
        public string CityName { get; set; }
        public string IdcardNumber { get; set; }
        public string SocialType { get; set; }
        public sbyte AttendSocial { get; set; }
        public decimal SocialBase { get; set; }
        public sbyte AttendHouseFound { get; set; }
        public decimal HousefoundBase { get; set; }
        public string SocialOrBothApplyNumber { get; set; }
        public string HousefundApplyNumber { get; set; }
        public DateTime? SocialInsureDate { get; set; }
        public DateTime? HouseInsureDate { get; set; }
        public DateTime? InsureExpireDate { get; set; }
        public DateTime? HfinsureExpireDate { get; set; }
        public string AccumulationAccountId { get; set; }
    }
}
