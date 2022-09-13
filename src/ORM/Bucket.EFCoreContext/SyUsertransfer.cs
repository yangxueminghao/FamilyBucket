using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyUsertransfer
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string FormerPrivateUserId { get; set; }
        public string ReceiverPrivateUserId { get; set; }
        public string ReceiverMoblie { get; set; }
        public string ReceiverEmail { get; set; }
        public sbyte Status { get; set; }
        public string Remark { get; set; }
        public DateTime? DateChecked { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
