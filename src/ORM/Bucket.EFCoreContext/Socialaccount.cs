using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Socialaccount
    {
        public string SocialAccountId { get; set; }
        public string SocialAccountName { get; set; }
        public string InsuredType { get; set; }
        public sbyte IsBreak { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public sbyte IsEnabled { get; set; }
        public int IsActive { get; set; }
    }
}
