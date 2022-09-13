using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Enumconfig
    {
        public int Id { get; set; }
        public string EnumName { get; set; }
        public string EnumValue { get; set; }
        public int? ParentId { get; set; }
        public int IsEnabled { get; set; }
        public int OrderId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Remark { get; set; }
    }
}
