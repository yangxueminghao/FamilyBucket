using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Companycode
    {
        public int RowId { get; set; }
        public Guid CompanyGuid { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCodes { get; set; }
        public decimal Discount { get; set; }
        public int IsEnable { get; set; }
        public int IsDelete { get; set; }
        public string Operator { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateUpdate { get; set; }
        public int? UserCount { get; set; }
    }
}
