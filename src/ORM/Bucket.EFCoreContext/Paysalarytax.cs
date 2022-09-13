using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Paysalarytax
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int Type { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? TaxPeriod { get; set; }
        public string TaxNo { get; set; }
    }
}
