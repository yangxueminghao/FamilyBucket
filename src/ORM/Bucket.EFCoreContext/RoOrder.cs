using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class RoOrder
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int OrderType { get; set; }
        public string MealId { get; set; }
        public decimal MealAmount { get; set; }
        public decimal? Discount { get; set; }
        public decimal CouponAmount { get; set; }
        public decimal ActualPayment { get; set; }
        public int PayType { get; set; }
        public int Status { get; set; }
        public string PayFail { get; set; }
        public DateTime? DatePaid { get; set; }
        public Guid? UserId { get; set; }
        public DateTime ExpireDate { get; set; }
        public sbyte HasInvoice { get; set; }
        public Guid? InvoiceId { get; set; }
        public sbyte IsDelete { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
