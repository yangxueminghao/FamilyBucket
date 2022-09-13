using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Messagetext
    {
        public Guid Oid { get; set; }
        public DateTime CreateTime { get; set; }
        public int MessageType { get; set; }
        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }
        public int? NodeType { get; set; }
    }
}
