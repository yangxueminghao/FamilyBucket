using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyRegion
    {
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
    }
}
