using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Userprofile
    {
        public int RowId { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public string ContactorName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string CertificateImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public byte[] Version { get; set; }
        public string ProImageUrl { get; set; }
        public string NickName { get; set; }
        public Guid UserUserId { get; set; }
        public string ShortCompanyName { get; set; }
        public string FixedPhone { get; set; }
        public string UserType { get; set; }
        public string HtNum { get; set; }
    }
}
