using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class CoUsercoupon
    {
        public string CollectId { get; set; }
        public string BagTempId { get; set; }
        public Guid UserId { get; set; }
        public sbyte IsUsed { get; set; }
        public sbyte IsActive { get; set; }
        public DateTime DateFinish { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
