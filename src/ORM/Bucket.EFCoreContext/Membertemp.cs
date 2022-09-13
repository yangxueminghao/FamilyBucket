using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Membertemp
    {
        public Guid MemberId { get; set; }
        public Guid UserId { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string IdcardType { get; set; }
        public string IdcardNumber { get; set; }
        public string CityName { get; set; }
        public decimal? SocialBase { get; set; }
        public decimal? HouseFoundBase { get; set; }
        public string SocialAddMonth { get; set; }
        public DateTime? SocialDealLine { get; set; }
        public string HouseAddMonth { get; set; }
        public DateTime? HfdealLine { get; set; }
        public int Status { get; set; }
        public string ItemJson { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public sbyte Deleted { get; set; }
    }
}
