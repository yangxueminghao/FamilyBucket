using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Feedbackdetail
    {
        public int Id { get; set; }
        public DateTime? Month { get; set; }
        public string InsuraceName { get; set; }
        public string Status { get; set; }
        public string PolicyVersionId { get; set; }
        public decimal? EnterpriseValue { get; set; }
        public decimal? PersonValue { get; set; }
        public string Remark { get; set; }
        public string FeedbackResultId { get; set; }
        public DateTime? FeedBackTime { get; set; }
    }
}
