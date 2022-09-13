using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class EsEmailsend
    {
        public string SendId { get; set; }
        public string TaskId { get; set; }
        public string TempId { get; set; }
        public Guid? MemberId { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
        public string RequestId { get; set; }
    }
}
