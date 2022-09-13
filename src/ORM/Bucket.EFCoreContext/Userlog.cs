using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Userlog
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int BusinessType { get; set; }
        public sbyte IsActive { get; set; }
        public string Remark { get; set; }
    }
}
