using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Membermigrate
    {
        public Guid Id { get; set; }
        public Guid OldUserId { get; set; }
        public Guid NewUserId { get; set; }
        public Guid MemberId { get; set; }
        public string MemberName { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
