using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Vest
    {
        public Guid VestUserId { get; set; }
        public Guid AdminUserId { get; set; }
        public string VestName { get; set; }
        public string VestImgPath { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
