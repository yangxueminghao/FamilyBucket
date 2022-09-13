using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyAdminmessage
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BusinessJson { get; set; }
        public string ThirdSerialNumber { get; set; }
        public string Remark { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
