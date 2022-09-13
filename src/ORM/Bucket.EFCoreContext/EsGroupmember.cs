using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class EsGroupmember
    {
        public Guid MemberId { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string GroupId { get; set; }
        public string Mobile { get; set; }
        public string Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Remark { get; set; }
        public sbyte IsBlackList { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
        public sbyte? IsActive { get; set; }
        public string Reason { get; set; }
    }
}
