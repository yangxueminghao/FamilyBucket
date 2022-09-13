using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Links
    {
        public int Id { get; set; }
        public string LinkName { get; set; }
        public string LinkUrl { get; set; }
        public sbyte IsEnable { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime? AddTime { get; set; }
        public string AddUser { get; set; }
        public int? Sort { get; set; }
        public DateTime? EditTime { get; set; }
        public string StationContactor { get; set; }
        public string HttpType { get; set; }
        public sbyte NoFollow { get; set; }
    }
}
