using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeFestival
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public sbyte IsActive { get; set; }
        public sbyte IsDelete { get; set; }
        public sbyte IsLong { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Greetings { get; set; }
        public string Url { get; set; }
    }
}
