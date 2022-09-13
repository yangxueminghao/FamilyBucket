using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SyRecommenderinfo
    {
        public string Id { get; set; }
        public string Recommender { get; set; }
        public string ShowName { get; set; }
        public string Qq { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string QrCodeUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public sbyte Deleted { get; set; }
    }
}
