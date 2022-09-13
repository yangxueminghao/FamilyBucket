using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Messagerecord
    {
        public Guid Oid { get; set; }
        public DateTime CreateTime { get; set; }
        public Guid UserId { get; set; }
        public Guid MessageId { get; set; }
        public sbyte ReadStatus { get; set; }
        public DateTime? ReadTime { get; set; }
        public string TerminalType { get; set; }
        public string JsonText { get; set; }
        public string ShowTitle { get; set; }
        public string SubTitle { get; set; }
        public string MessageDetail { get; set; }
        public string FormId { get; set; }
    }
}
