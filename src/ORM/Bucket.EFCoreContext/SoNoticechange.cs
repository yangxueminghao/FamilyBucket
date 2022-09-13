using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoNoticechange
    {
        public int ChangeId { get; set; }
        public DateTime CreateTime { get; set; }
        public string NoticeId { get; set; }
        public string IdCard { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public decimal? SocialNumber { get; set; }
        public decimal? AccumucationNumber { get; set; }
        public string ApplyName { get; set; }
        public int ApplyStatus { get; set; }
        public DateTime? ApplyTime { get; set; }
        public string ThirdSerialNumber { get; set; }
        public string CustomerId { get; set; }
        public string Remark { get; set; }
        public string AccumucationAccountId { get; set; }
    }
}
