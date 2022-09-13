using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Thumbup
    {
        public int Id { get; set; }
        public Guid AddUserId { get; set; }
        public Guid? LeaveWordId { get; set; }
        public int? ReplyWordId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
