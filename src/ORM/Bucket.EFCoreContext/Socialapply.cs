using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Socialapply
    {
        public int Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid ItemId { get; set; }
        public decimal? SocialChangeBase { get; set; }
        public decimal? HouseFoundChangeBase { get; set; }
        public string SocialChangeAccountId { get; set; }
        public string HouseChangeAccountId { get; set; }
        public string SocialChangeVersionNo { get; set; }
        public string HouseChangeVersionNo { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
