using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Standingbookitem
    {
        public Guid StandingBookItemId { get; set; }
        public string StandingBookItemNumber { get; set; }
        public int StandingBookItemType { get; set; }
        public Guid UserId { get; set; }
        public Guid MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberIdcardNumber { get; set; }
        public string HouseholdType { get; set; }
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string SocialSecurityTypeName { get; set; }
        public sbyte AttendHousefound { get; set; }
        public decimal SocialBase { get; set; }
        public decimal HousefoundBase { get; set; }
        public decimal SocialRatio { get; set; }
        public decimal HousefoundRatio { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatTime { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Timetoken { get; set; }
        public int Status { get; set; }
        public string CityName { get; set; }
        public decimal? ServicePrice { get; set; }
        public Guid InvoiceGuid { get; set; }
        public int InvoceResult { get; set; }
        public string StandingBookDetail { get; set; }
        public Guid SocialSecurityItemId { get; set; }
        public byte[] Version { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? StandingBookHandleCode { get; set; }
        public int? StandingBookHandleResult { get; set; }
        public string StandingBookHandleMsg { get; set; }
        public string HandlePerson { get; set; }
        public DateTime? HandleTime { get; set; }
        public decimal MoreOrMissingAmount { get; set; }
        public decimal StandingBookSocialPay { get; set; }
        public decimal StandingBookHousefoundPay { get; set; }
        public decimal StandingBookTotalPay { get; set; }
        public Guid? ReplenishId { get; set; }
        public string CompanyName { get; set; }
    }
}
