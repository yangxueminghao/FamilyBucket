using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bucket.EFCoreContext
{
    public partial class Order
    {
        public Guid OrderId { get; set; }
        public string OrderNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal ActualPayment { get; set; }
        public int OrderType { get; set; }
        public DateTime? DatePaid { get; set; }
        public int Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModfied { get; set; }
        public string OrderDescription { get; set; }
        public Guid? InvoiceId { get; set; }
        public DateTime ExpireDate { get; set; }
        public sbyte HasInvoice { get; set; }
        public sbyte Canceled { get; set; }
        public string TradeNo { get; set; }
        public string PayType { get; set; }
        public decimal? ServicePrice { get; set; }
        public decimal? Discount { get; set; }
        public int? OrderIsCheck { get; set; }
        public decimal? DeductiblePrice { get; set; }
        public Guid? OwnerUserId { get; set; }
        public decimal PayAmount { get; set; }
        public decimal? ExtraAmount { get; set; }
        public int? ResetTime { get; set; }
        public decimal? ServiceCityBase { get; set; }
        public decimal? ServiceFee { get; set; }
        public decimal CouponAmount { get; set; }
    }
}
