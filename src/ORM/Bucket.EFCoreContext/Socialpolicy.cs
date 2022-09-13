using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Socialpolicy
    {
        public string PolicyId { get; set; }
        public string AccountNo { get; set; }
        public string VersionNo { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string EffectMonth { get; set; }
        public string ChangeVersion { get; set; }
        public string IgnoreMembers { get; set; }
    }
}
