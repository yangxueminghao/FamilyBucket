using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Socialsecurityitem
    {
        public Guid ItemId { get; set; }
        public int ItemType { get; set; }
        public Guid UserId { get; set; }
        public Guid MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberIdcardNumber { get; set; }
        public string Mobile { get; set; }
        public string CityName { get; set; }
        public string SocialType { get; set; }
        public string HouseholdType { get; set; }
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string SocialSecurityTypeName { get; set; }
        public sbyte AttendHousefound { get; set; }
        public decimal SocialBase { get; set; }
        public decimal TrueSocialBase { get; set; }
        public sbyte IsSocialPreCharge { get; set; }
        public decimal HousefoundBase { get; set; }
        public decimal TrueHousefoundBase { get; set; }
        public sbyte IsHousePreCharge { get; set; }
        public decimal SocialRatio { get; set; }
        public decimal TrueSocialAmount { get; set; }
        public decimal HousefoundRatio { get; set; }
        public decimal TrueHousefoundAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TrueTotalAmount { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? HouseExpireDate { get; set; }
        public sbyte Canceled { get; set; }
        public string HousefundApplyNumber { get; set; }
        public string SocialOrBothApplyNumber { get; set; }
        public decimal? ServicePrice { get; set; }
        public Guid InvoiceGuid { get; set; }
        public int InvoceResult { get; set; }
        public DateTime? SocialDate { get; set; }
        public DateTime? HouseDate { get; set; }
        public decimal? SocialSecurityRatioSupplyMent { get; set; }
        public decimal? HousefundRatioSupplyMent { get; set; }
        public decimal? TrueSocialSecurityRatioSupplyMent { get; set; }
        public decimal? TrueHousefundRatioSupplyMent { get; set; }
        public DateTime? SocialSupplyStartTime { get; set; }
        public DateTime? SocialSupplyEndTime { get; set; }
        public DateTime? HouseSupplyStartTime { get; set; }
        public DateTime? HouseSupplyEndTime { get; set; }
        public string ProductId { get; set; }
        public string SocialAccountId { get; set; }
        public string HouseAccountId { get; set; }
        public string SocialVersionNo { get; set; }
        public string HouseVersionNo { get; set; }
        public string ApplyMaterialInfos { get; set; }
    }
}
