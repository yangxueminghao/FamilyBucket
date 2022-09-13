using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class XkServicebranchs
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ReceiveAddress { get; set; }
        public string BranchLeader { get; set; }
        public sbyte IsActive { get; set; }
        public sbyte IsPersonEssential { get; set; }
        public int SocialEssential { get; set; }
        public int AccEssential { get; set; }
        public string BranchDistrict { get; set; }
        public string AccRatio { get; set; }
        public string Remark { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte IsDelete { get; set; }
    }
}
