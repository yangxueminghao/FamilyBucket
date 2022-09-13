using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Orderitemdetail
    {
        public Guid Id { get; set; }
        public Guid? ItemId { get; set; }
        public int Type { get; set; }
        public string PayMonth { get; set; }
        public decimal ServicePay { get; set; }
        public string PayDetail { get; set; }
        public string OldPayDetail { get; set; }
    }
}
