using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class WeOrder
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal ActualPayment { get; set; }
        public DateTime? DatePaid { get; set; }
        public int Status { get; set; }
        public Guid? UserId { get; set; }
        public int MealCount { get; set; }
        public Guid? InvoiceId { get; set; }
        public DateTime ExpireDate { get; set; }
        public sbyte HasInvoice { get; set; }
        public sbyte Canceled { get; set; }
        public decimal? ExtraAmount { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string ExtraRemark { get; set; }
        public int? OrderType { get; set; }
    }
}
