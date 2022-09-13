using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Attachment
    {
        public Guid AttachmentId { get; set; }
        public string FormId { get; set; }
        public int FormType { get; set; }
        public string AttachmentName { get; set; }
        public string AttachmentUrl { get; set; }
        public DateTime CreateTime { get; set; }
        public sbyte IsDelete { get; set; }
        public Guid? UserId { get; set; }
    }
}
