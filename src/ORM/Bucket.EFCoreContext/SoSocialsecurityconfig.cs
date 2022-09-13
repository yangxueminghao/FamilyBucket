using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class SoSocialsecurityconfig
    {
        public string Pkid { get; set; }
        public decimal? Areaid { get; set; }
        public string City { get; set; }
        public string Sstype { get; set; }
        public string Insurancetype { get; set; }
        public string Category { get; set; }
        public decimal Lowestfees { get; set; }
        public decimal Highestfees { get; set; }
        public decimal Companyfees { get; set; }
        public decimal Peoplefees { get; set; }
        public decimal? Companypay { get; set; }
        public decimal? Peoplepay { get; set; }
        public string Remark { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Adduserid { get; set; }
        public string Updateuserid { get; set; }
        public decimal? Isdelete { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public decimal? Isactive { get; set; }
        public decimal? Isbacktype { get; set; }
        public decimal? Valuedigit { get; set; }
        public decimal Valuerule { get; set; }
        public string Insurancesort { get; set; }
        public decimal? Valuedigitperson { get; set; }
        public decimal Valueruleperson { get; set; }
        public decimal? Lowestfeesperson { get; set; }
        public decimal? Highestfeesperson { get; set; }
        public decimal? Paytype { get; set; }
        public string Paymonth { get; set; }
    }
}
