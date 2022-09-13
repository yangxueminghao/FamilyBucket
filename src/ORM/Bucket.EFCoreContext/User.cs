using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class User
    {
        public User()
        {
            Invoiceaddress = new HashSet<Invoiceaddress>();
            InvoiceaddressBack = new HashSet<InvoiceaddressBack>();
        }

        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public string Recommender { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserType { get; set; }
        public string Mobile { get; set; }
        public string CompanyName { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ShortCompanyName { get; set; }
        public string FixedPhone { get; set; }
        public string HtNum { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyType { get; set; }
        public sbyte IsMigrate { get; set; }
        public string TerminalType { get; set; }
        public DateTime? FirstOpenTime { get; set; }
        public DateTime? LastOpenTime { get; set; }
        public DateTime? LastCancelTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public string UserAvatarUrl { get; set; }
        public int? DisableType { get; set; }
        public sbyte Deleted { get; set; }
        public string PrivateUserId { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }
        public string PrivateEmail { get; set; }
        public string PrivatePhotoUrl { get; set; }
        public string AddverseRecord { get; set; }
        public DateTime? MessageOpenTime { get; set; }

        public virtual ICollection<Invoiceaddress> Invoiceaddress { get; set; }
        public virtual ICollection<InvoiceaddressBack> InvoiceaddressBack { get; set; }
    }
}
