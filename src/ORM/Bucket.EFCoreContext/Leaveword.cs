using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Leaveword
    {
        public Guid LeaveWordId { get; set; }
        public Guid AddUserId { get; set; }
        public string QuestionType { get; set; }
        public string QuestionDescription { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public sbyte ReplyStatus { get; set; }
        public sbyte IsRead { get; set; }
        public sbyte OnlineStatus { get; set; }
        public sbyte IsFirst { get; set; }
        public int ClickCount { get; set; }
        public string ImgPath { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
