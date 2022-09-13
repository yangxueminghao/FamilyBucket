using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Feedbackresult
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string BusinessType { get; set; }
        public string FeedbackMsg { get; set; }
        public Guid? OrderItemId { get; set; }
        public sbyte? IsPayBack { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public Guid? MemberId { get; set; }
        public string PayBackStatus { get; set; }
        public string AccountId { get; set; }
        public DateTime CreateTime { get; set; }
        public decimal? AccountBase { get; set; }
    }
}
