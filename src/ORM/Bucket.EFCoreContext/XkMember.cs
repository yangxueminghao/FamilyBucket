using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkMember
    {
        public Guid MemberId { get; set; }
        public Guid? AccountId { get; set; }
        public string Name { get; set; }
        public string IdcardType { get; set; }
        public string IdcardNumber { get; set; }
        public string Mobile { get; set; }
        public string BranchId { get; set; }
        public Guid? UserId { get; set; }
        public sbyte AttendSocial { get; set; }
        public sbyte AttendHouse { get; set; }
        public string InsuranceType { get; set; }
        public sbyte? AttendBjsocial { get; set; }
        public sbyte? AttendBjhouse { get; set; }
        public decimal? SocialBase { get; set; }
        public decimal? HouseBase { get; set; }
        public DateTime? SocialInsureDate { get; set; }
        public DateTime? HouseInsureDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public sbyte Deleted { get; set; }
        public DateTime? DeletedTime { get; set; }
        public DateTime? SocialBjstartDate { get; set; }
        public DateTime? SocialBjendDate { get; set; }
        public DateTime? HouseBjstartDate { get; set; }
        public DateTime? HouseBjendDate { get; set; }
        public string HousePercent { get; set; }
        public sbyte? IsSocialInsured { get; set; }
        public sbyte? IsHouseInsured { get; set; }
        public sbyte? StopSocial { get; set; }
        public sbyte? StopHouse { get; set; }
        public string SocialStopMonth { get; set; }
        public string HouseStopMonth { get; set; }
        public string HouseType { get; set; }
        public long? SocialPolicyId { get; set; }
        public long? HousePolicyId { get; set; }
        public string LeaveType { get; set; }
        public string ApplyMaterialInfos { get; set; }
    }
}
