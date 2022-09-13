using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Reply
    {
        public int Id { get; set; }
        public Guid LeaveWordId { get; set; }
        public string ReplyContent { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int? ReplyId { get; set; }
        public int ClickCount { get; set; }
        public Guid ReplyUserId { get; set; }
        public string ImgPath { get; set; }
    }
}
