using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Invoiceorderinfo
    {
        public Guid Id { get; set; }
        public Guid InvoiceId { get; set; }
        public string OrderId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
