using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Takedatarecord
    {
        public int Pkid { get; set; }
        public string Name { get; set; }
        public DateTime ExecuteTime { get; set; }
        public sbyte? IsEnabled { get; set; }
        public string Remark { get; set; }
    }
}
