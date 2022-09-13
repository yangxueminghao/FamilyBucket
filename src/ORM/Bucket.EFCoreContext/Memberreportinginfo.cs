using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Memberreportinginfo
    {
        public int Id { get; set; }
        public Guid MemberId { get; set; }
        public int ApplyInforId { get; set; }
        public string Content { get; set; }
    }
}
