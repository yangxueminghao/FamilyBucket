using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class VmUser
    {
        public string PrivateUserId { get; set; }
        public string Mobile { get; set; }
        public string NickName { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string CompanyName { get; set; }
        public string ShortCompanyName { get; set; }
        public string HtNum { get; set; }
    }
}
