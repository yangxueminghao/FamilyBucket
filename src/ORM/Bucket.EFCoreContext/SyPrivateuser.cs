using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyPrivateuser
    {
        public string PrivateUserId { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }
        public string PrivateEmail { get; set; }
        public string PrivatePhotoUrl { get; set; }
        public string TerminalType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte Deleted { get; set; }
    }
}
