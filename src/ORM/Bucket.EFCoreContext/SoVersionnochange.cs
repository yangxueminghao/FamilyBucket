using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoVersionnochange
    {
        public Guid Id { get; set; }
        public string CityName { get; set; }
        public Guid MemberId { get; set; }
        public string OldSocialVersionNo { get; set; }
        public string NewSocialVersionNo { get; set; }
        public string OldHouseVersionNo { get; set; }
        public string NewHouseVersional { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
