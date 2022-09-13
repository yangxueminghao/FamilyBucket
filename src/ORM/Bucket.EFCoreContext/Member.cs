using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Member
    {
        public Guid MemberId { get; set; }
        public string Name { get; set; }
        public string CityName { get; set; }
        public string IdcardNumber { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public sbyte AttendSocial { get; set; }
        public sbyte AttendHouseFound { get; set; }
        public decimal SocialBase { get; set; }
        public decimal HouseFoundBase { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public sbyte Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public string HousefundApplyNumber { get; set; }
        public string SocialOrBothApplyNumber { get; set; }
        public Guid? UserId { get; set; }
        public string SupplierCode { get; set; }
        public string ProductNo { get; set; }
        public string SocialAccountId { get; set; }
        public string AccumulationAccountId { get; set; }
        public string SocialVersionNo { get; set; }
        public string HouseVersionNo { get; set; }
        public DateTime? SocialInsureDate { get; set; }
        public DateTime? HouseInsureDate { get; set; }
        public DateTime? InsureExpireDate { get; set; }
        public DateTime? HfinsureExpireDate { get; set; }
        public sbyte? IsSocialInsured { get; set; }
        public sbyte? IsHouseInsured { get; set; }
        public int SocialSupplyStatus { get; set; }
        public int HouseSupplyStatus { get; set; }
        public string IdcardType { get; set; }
    }
}
