using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Extensionsources
    {
        public int Id { get; set; }
        public string SourceChannel { get; set; }
        public string DistinguishWord { get; set; }
        public string SpecificSource { get; set; }
        public DateTime? DateCreate { get; set; }
        public string Remark { get; set; }
    }
}
