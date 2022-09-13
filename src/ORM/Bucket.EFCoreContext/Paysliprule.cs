using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysliprule
    {
        public Guid UserId { get; set; }
        public sbyte IsSend { get; set; }
        public sbyte IsSendWx { get; set; }
        public sbyte IsSendEmail { get; set; }
        public sbyte IsSendMobile { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
