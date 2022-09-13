using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Policyexpress
    {
        public string NoticeId { get; set; }
        public string NoticeName { get; set; }
        public string PolicyType { get; set; }
        public string City { get; set; }
        public string CostCenterId { get; set; }
        public string CostCenterName { get; set; }
        public string NoticeContent { get; set; }
        public DateTime? EffectTime { get; set; }
        public DateTime? AnnounceTime { get; set; }
        public sbyte IsDelete { get; set; }
        public string PolicyPath { get; set; }
        public string AttachmentPath { get; set; }
        public string AttachmentName { get; set; }
    }
}
