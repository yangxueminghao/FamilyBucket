using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Salarycomment
    {
        public string CommentId { get; set; }
        public int DetailId { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public string ReplyId { get; set; }
        public int ReplyType { get; set; }
    }
}
