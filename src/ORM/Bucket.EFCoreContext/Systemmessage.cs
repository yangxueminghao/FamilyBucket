using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Systemmessage
    {
        public Guid Id { get; set; }
        public int? MessageType { get; set; }
        public string Title { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateOn { get; set; }
        public string HtmlStr { get; set; }
    }
}
